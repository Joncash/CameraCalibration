using CalibrationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CalibrationModule
{
	public delegate void CalibrationImageCalculatorEventHandler(object sender, CalibrationEventArgs e);
	public class CalibrationWorker
	{
		#region private variables
		private BackgroundWorker _bg;
		private CalibImageCalculator _calibImageCalculator;
		private CalibrationAssistant _assistant;
		private List<object> _workingStack;
		System.Windows.Forms.Timer _timer;
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

		void _timer_Tick(object sender, EventArgs e)
		{
			if (_workingStack.Count == 0)
			{
				stop();
			}
			else if (!_bg.IsBusy)
			{
				var model = _workingStack[0];
				_bg.RunWorkerAsync(model);
			}
		}

		private void stop()
		{
			_timer.Stop();
		}
		void _bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled)
			{
				//ToDo
			}
		}

		void _bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (ResponseCalibrationReport != null)
			{
				object model = "";
				var args = new CalibrationEventArgs(model);
				ResponseCalibrationReport(sender, args);
			}
		}

		void _bg_DoWork(object sender, DoWorkEventArgs e)
		{
			var worker = sender as BackgroundWorker;
			var data = e.Argument as CalibImageDTO;
			if (data != null)
			{
				//data
				var descFile = _assistant.GetCalibPlateDescrFile();
				var calibImage = _assistant.GetCalibImage(data.ImageID);
				var plateParam = _assistant.GetCalibrationPlateParam();
				var startCameraParam = _assistant.GetCameraParamHTuple(calibImage);
				var plateMarkModel = _calibImageCalculator.GetCalibrationPlateMarkViewModel(descFile, calibImage.GetImage()
																				, plateParam, startCameraParam);
				//_bg.ReportProgress(1, "");
			}
		}
		#endregion
	}
}
