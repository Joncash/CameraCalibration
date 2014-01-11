using CalibrationModels;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationModule
{
	public delegate void AddCalibrationImageEventHandler(object sender, CalibrationEventArgs e);
	public delegate void RemoveCalibrationImageEventHandler(object sender, CalibrationEventArgs e);
	public delegate void SaveCalibrationImageEventHandler(object sender, CalibrationEventArgs e);

	public delegate void SetCalibrationPlateParamEventHandler(object sender, CalibrationEventArgs e);
	public delegate void SetCalibrationImageQualityIssueParamEventHandler(object sender, CalibrationEventArgs e);
	public delegate void SetCameraParamEventHandler(object sender, CalibrationEventArgs e);

	public delegate void CalibrationImageQualityIssueChangedEventHandler(object sender, CalibrationEventArgs e);

	public delegate void CalibrationCompletedEventHandler(object sender, CalibrationEventArgs e);

	public delegate void SaveCalibratedFileEventHandler(object sender, CalibrationEventArgs e);

	public delegate void ErrorEventHandler(object sender, CalibrationErrorEventArgs e);

	/// <summary>
	/// 鏡頭校正 Assistant
	/// </summary>
	public class CalibrationAssistant
	{
		private enum EventNotifyType
		{
			ImageAdded,
			ImageRemoved,
			ImageSaved,
			CalibrationPlateParamChanged,
			CalibrationImageQualityIssueParamChanged,
			CameraParamChanged,
			CalibrationImageQualityIssueChanged,
			CalibrationCompletd,
			CalibratedFileSave,
			Error
		};

		#region private variables

		private List<CalibImage> _calibImages;

		private CalibrationPlateParam _calibPlateParam;
		private CalibrationQualityIssueParam _calibQualityIssueParam;
		private CameraParam _cameraParam;
		private string _calibPlateDescFile;
		private double _thickness = 0.63; //millimeter

		//workers
		private CalibrationWorker _worker;
		#endregion

		#region public variables

		#endregion

		#region 建構子
		/// <summary>
		/// 初始化參數
		/// </summary>
		/// <param name="calibPlateParam">校正片擷取參數 (Calibration Plate Extraction Parameters)</param>
		/// <param name="calibQualityIssueParam">影像品質條件參數 (Quality Issue Conditions)</param>
		/// <param name="cameraParam">鏡頭參數 (Camera Parameters)</param>
		/// <param name="calibPlateDescrFile">校正片描述檔案</param>
		/// <param name="thickness">校正片厚度</param>
		public CalibrationAssistant(CalibrationPlateParam calibPlateParam
									, CalibrationQualityIssueParam calibQualityIssueParam
									, CameraParam cameraParam
									, string calibPlateDescrFile
									, double thickness)
		{
			_calibPlateParam = calibPlateParam;
			_calibQualityIssueParam = calibQualityIssueParam;
			_cameraParam = cameraParam;
			_calibPlateDescFile = calibPlateDescrFile;
			_thickness = thickness;
			init();
		}

		/// <summary>
		/// 初始化參數
		/// </summary>
		/// <param name="cameraParam">鏡頭參數 (Camera Parameters)</param>
		/// <param name="calibPlateDescrFile">校正片描述檔案</param>
		public CalibrationAssistant(CameraParam cameraParam
									, string calibPlateDescrFile)
		{
			_cameraParam = cameraParam;
			_calibPlateDescFile = calibPlateDescrFile;
			init();
		}
		#endregion

		#region Events
		public event AddCalibrationImageEventHandler On_ImageAdded;
		public event RemoveCalibrationImageEventHandler On_ImageRemoved;
		public event SaveCalibrationImageEventHandler On_ImageSaved;

		public event SetCalibrationPlateParamEventHandler On_CalibrationPlateParamChanged;
		public event SetCalibrationImageQualityIssueParamEventHandler On_CalibrationImageQualityIssueParamChanged;
		public event SetCameraParamEventHandler On_CameraParamChanged;

		public event CalibrationImageQualityIssueChangedEventHandler On_CalibrationImageQualityIssueChanged;
		public event CalibrationCompletedEventHandler On_CalibrationCompleted;

		public event SaveCalibratedFileEventHandler On_CalibratedFileSaved;

		public event ErrorEventHandler On_Error;
		#endregion

		#region Public Methods
		public double GetThickness()
		{
			return _thickness;
		}
		public CalibrationQualityIssueParam GetCalibrationQualityIssueParam()
		{
			return _calibQualityIssueParam;
		}
		public CalibrationPlateParam GetCalibrationPlateParam()
		{
			return _calibPlateParam;
		}
		public CalibImage GetCalibImage(string imageID)
		{
			return _calibImages.SingleOrDefault(p => p.ID == imageID);
		}
		public HTuple GetCameraParamHTuple(CalibImage image)
		{
			HTuple campar;
			int paramsListSize = 8;
			int offset = 0;
			bool areaScanPoly = false;
			var mKappa = 0.0;
			var mK1 = 0.0;
			var mK2 = 0.0;
			var mK3 = 0.0;
			var mP1 = 0.0;
			var mP2 = 0.0;
			var mMotionVx = 0.0;
			var mMotionVy = 500.0;
			var mMotionVz = 0.0;
			var mCameraType = _cameraParam.CameraType;
			if (mCameraType == CameraModelType.AreaScanPolynomial)
			{
				paramsListSize = 12;
				offset = 4;
				areaScanPoly = true;
			}

			paramsListSize += (mCameraType == CameraModelType.LineScan) ? 3 : 0;

			campar = new HTuple(paramsListSize);
			campar[0] = (_cameraParam.IsTelecentric ? 0.0 : ((double)_cameraParam.Focus / 1000000.0));

			if (areaScanPoly)
			{
				campar[1] = mK1;
				campar[2] = mK2;
				campar[3] = mK3;
				campar[4] = mP1;
				campar[5] = mP2;
			}
			else
			{
				campar[1] = mKappa;
			}

			campar[2 + offset] = (double)_cameraParam.Sx / 1000000000.0;   // Sx -width   -> * 10^ -9 
			campar[3 + offset] = (double)_cameraParam.Sy / 1000000000.0;  // Sy -height  -> * 10^ -9 
			campar[4 + offset] = image.ImageWidth * 0.5;                  // x -principal point 
			campar[5 + offset] = image.ImageHeight * 0.5;                 // y -principal point 
			campar[6 + offset] = image.ImageWidth;                      // imagewidth 
			campar[7 + offset] = image.ImageHeight;                     // imageheight 

			if (paramsListSize == 11)
			{
				campar[8] = mMotionVx / 1000000.0;
				campar[9] = mMotionVy / 1000000.0;
				campar[10] = mMotionVz / 1000000.0;

				campar[5 + offset] = 0;     // y -principal point = 0 for line scan camera 
			}
			return campar;
		}
		public HTuple GetCameraParamHTuple(string imageID)
		{
			var image = GetCalibImage(imageID);
			return GetCameraParamHTuple(image);
		}
		public string GetCalibPlateDescrFile()
		{
			return _calibPlateDescFile;
		}

		/// <summary>
		/// 加入校正影像
		/// </summary>
		/// <param name="image">CalibImage</param>
		public void AddCalibImage(CalibImage image)
		{
			if (_calibImages == null) _calibImages = new List<CalibImage>();
			_calibImages.Add(image);

			//_worker.RequestCalibrationImageReport(image.ID, "ImageAdded");
			//var model = new CalibImageViewModel() { CalibImageID = image.ID };
			//var eventArgs = new CalibrationEventArgs(model);
			//var sender = this;


			//eventNotify(EventNotifyType.ImageAdded, sender, eventArgs);
		}

		/// <summary>
		/// 加入校正影像
		/// </summary>
		/// <param name="filename">image file path</param>
		public void AddCalibImage(string filename)
		{
			var image = new CalibImage(filename);
			AddCalibImage(image);
		}

		/// <summary>
		/// 移除校正影像
		/// </summary>
		public void RemoveCalibImage(string imageID)
		{
			//ToDo
			var model = true;
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.ImageRemoved, sender, eventArgs);
		}

		/// <summary>
		/// 移除所有校正影像
		/// </summary>
		public void RemoveAllCalibImages()
		{
			//ToDo
			var model = true;
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.ImageRemoved, sender, eventArgs);
		}

		/// <summary>
		/// 儲存校正影像 - online image acquisition only
		/// </summary>
		public void SaveCalibImage(string imageID)
		{
			//ToDo
			var model = true;
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.ImageSaved, sender, eventArgs);
		}

		/// <summary>
		/// 更新校正影像品質資訊
		/// </summary>
		public void UpdateCalibImageQualityIssue(string imageID)
		{
			//ToDo
			var model = new CalibImageViewModel() { CalibImageID = imageID };
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.CalibrationImageQualityIssueChanged, sender, eventArgs);
		}

		/// <summary>
		/// 設定主要參考的校正影像
		/// </summary>
		/// <param name="imageID"></param>
		public void SetCalibImageReference(string imageID)
		{
			//ToDo
		}

		/// <summary>
		/// 設定影像品質檢測條件
		/// </summary>
		/// <param name="type"></param>
		/// <param name="value"></param>
		public void SetCalibImageQualityParam(CalibrateType type, object value)
		{
			//ToDo
			var model = true;
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.CalibrationImageQualityIssueParamChanged, sender, eventArgs);
		}

		/// <summary>
		/// 設定校正片擷取參數
		/// </summary>
		/// <param name="type"></param>
		/// <param name="value"></param>
		public void SetCalibrationPlateParam(CalibrateType type, object value)
		{
			//ToDo
			var model = true;
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.CalibrationPlateParamChanged, sender, eventArgs);
		}

		public void SetCameraParam(CalibrateSettingType type, object value)
		{
			//ToDo
			var model = true;
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.CameraParamChanged, sender, eventArgs);
		}


		/// <summary>
		/// 校正
		/// </summary>
		public void Calibrate()
		{
			//ToDo
			var model = new CalibratedViewModel();
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.CalibrationCompletd, sender, eventArgs);
		}

		public void SaveCalibratedCameraParam(string filepath)
		{
			//ToDo
			var model = true;
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.CalibratedFileSave, sender, eventArgs);
		}

		public void SaveCalibratedCameraPose(string filepath)
		{
			//ToDo
			var model = true;
			var eventArgs = new CalibrationEventArgs(model);
			var sender = this;

			eventNotify(EventNotifyType.CalibratedFileSave, sender, eventArgs);
		}

		#endregion

		#region private Methods
		private void init()
		{
			_worker = new CalibrationWorker(this);
			_worker.ResponseCalibrationReport += responseMessage;
		}
		private void responseMessage(object sender, CalibrationEventArgs e)
		{
			//ToDo
		}
		private void eventNotify(EventNotifyType eventType, object sender, CalibrationEventArgs e)
		{
			switch (eventType)
			{
				case EventNotifyType.CalibratedFileSave:
					if (On_CalibratedFileSaved != null)
						On_CalibratedFileSaved(sender, e);
					break;
				case EventNotifyType.CalibrationCompletd:
					if (On_CalibrationCompleted != null)
						On_CalibrationCompleted(sender, e);
					break;
				case EventNotifyType.CalibrationImageQualityIssueChanged:
					if (On_CalibrationImageQualityIssueChanged != null)
						On_CalibrationImageQualityIssueChanged(sender, e);
					break;
				case EventNotifyType.CalibrationImageQualityIssueParamChanged:
					if (On_CalibrationImageQualityIssueParamChanged != null)
						On_CalibrationImageQualityIssueParamChanged(sender, e);
					break;
				case EventNotifyType.CalibrationPlateParamChanged:
					if (On_CalibrationPlateParamChanged != null)
						On_CalibrationPlateParamChanged(sender, e);
					break;
				case EventNotifyType.CameraParamChanged:
					if (On_CameraParamChanged != null)
						On_CameraParamChanged(sender, e);
					break;
				case EventNotifyType.ImageAdded:
					if (On_ImageAdded != null)
						On_ImageAdded(sender, e);
					break;
				case EventNotifyType.ImageRemoved:
					if (On_ImageRemoved != null)
						On_ImageRemoved(sender, e);
					break;
				case EventNotifyType.ImageSaved:
					if (On_ImageSaved != null)
						On_ImageSaved(sender, e);
					break;
			}
		}
		#endregion
	}
}
