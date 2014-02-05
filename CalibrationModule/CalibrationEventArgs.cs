using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModule
{
	/// <summary>
	/// 校正事件通知參數
	/// </summary>
	public class CalibrationEventArgs : EventArgs
	{
		private object _model;
		public CalibrationEventArgs(object model)
		{
			_model = model;
		}
		public object Model { get { return _model; } }

		public void ResetModel(object model)
		{
			_model = model;
		}

		public CalibrationModule.CalibrationAssistant.EventNotifyType EventType;
	}
}
