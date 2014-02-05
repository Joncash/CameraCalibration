using CalibrationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CalibrationModule
{
	public delegate void CalibrationImageCalculatorEventHandler(object sender, CalibrationEventArgs e);

	/// <summary>
	/// 執行取得影像報告工作
	/// 1。將工作放入工作佇列中
	/// 2。依序取得影像報告
	/// 3。回覆報告
	/// </summary>
	public class CalibrationWorker
	{
		#region private variables
		private BackgroundWorker _bg;
		private CalibImageCalculator _calibImageCalculator;
		private CalibrationAssistant _assistant;
		private List<object> _workingStack;
		private System.Windows.Forms.Timer _timer;
		private int _accWorkCount; // 累計工作量
		#endregion

		#region public Delegate
		/// <summary>
		/// Worker 通知結果
		/// </summary>
		public CalibrationImageCalculatorEventHandler ResponseCalibrationReport;
		#endregion

		#region 建構子
		public CalibrationWorker(CalibrationAssistant assistant)
		{
			_assistant = assistant;
			init();
		}
		public CalibrationWorker()
		{
			init();
		}
		#endregion


		#region public methods

		/// <summary>
		/// 取得校正影像報告 (狀態及品質)
		/// </summary>
		/// <param name="imageID"></param>
		/// <param name="userState"></param>
		public void RequestCalibrationImageReport(CalibImageDTO imageDTO)
		{
			_workingStack.Add(imageDTO);
			if (!_timer.Enabled)
				_timer.Start();
		}

		#endregion

		#region private methods
		private void init()
		{
			_workingStack = new List<object>();
			_calibImageCalculator = new CalibImageCalculator();
			_bg = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
			_bg.DoWork += _bg_DoWork;
			_bg.ProgressChanged += _bg_ProgressChanged;
			_bg.RunWorkerCompleted += _bg_RunWorkerCompleted;

			_timer = new System.Windows.Forms.Timer();
			_timer.Interval = 10;//ms
			_timer.Tick += _timer_Tick;
		}

		private void _timer_Tick(object sender, EventArgs e)
		{
			if (_workingStack.Count == 0)
			{
				stopTimer();
			}
			else if (!_bg.IsBusy)
			{
				var model = _workingStack[0];
				_bg.RunWorkerAsync(model);
				stopTimer();
			}
		}

		private void stopTimer()
		{
			_timer.Stop();
		}

		private void _bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled)
			{
				//ToDo
			}
			else
			{
				//分派下一個工作，如果有的話
				_timer.Start();
			}
		}

		void _bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			var model = e.UserState as ReportModel;
			if (ResponseCalibrationReport != null && model != null)
			{
				CalibrationAssistant.EventNotifyType notifyType;
				if (Enum.TryParse<CalibrationAssistant.EventNotifyType>(model.UserState, out notifyType))
				{
					var args = new CalibrationEventArgs(model)
					{
						EventType = notifyType,
					};
					ResponseCalibrationReport(sender, args);
				}
			}
		}

		void _bg_DoWork(object sender, DoWorkEventArgs e)
		{
			var worker = sender as BackgroundWorker;
			var model = e.Argument as CalibImageDTO;
			if (model != null)
			{
				//prepare data
				var descFile = _assistant.GetCalibPlateDescrFile();
				var calibImage = _assistant.GetCalibImage(model.ImageID);
				var plateParam = _assistant.GetCalibrationPlateParam();
				var startCameraParam = _assistant.GetCameraParamHTuple(calibImage);

				//doWork
				var report = _calibImageCalculator.GetCalibtionImageReport(descFile, calibImage, plateParam, startCameraParam);

				//var plateMarkModel = _calibImageCalculator.GetCalibrationPlateMarkViewModel(descFile, calibImage.GetImage()
				//																, plateParam, startCameraParam);

				var reportModel = new ReportModel()
				{
					UserState = model.UserState,
					Model = report,
				};
				_bg.ReportProgress(++_accWorkCount, reportModel);

				//remove work
				_workingStack.RemoveAt(0);
			}
		}
		#endregion

		class ReportModel
		{
			public string UserState { get; set; }
			public object Model { get; set; }
		}
	}
}
