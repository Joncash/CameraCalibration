using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModule
{
	/// <summary>
	/// 校正錯誤事件參數
	/// </summary>
	public class CalibrationErrorEventArgs : EventArgs
	{
		private string _message;
		public string Message { get { return _message; } }
		public object _sender;
		public object Sender { get { return _sender; } }
		public readonly Exception Ex;
		public object Model;
		public CalibrationErrorEventArgs(object sender, Exception ex)
		{
			this.Ex = ex;
			_message = ex.Message;
			_sender = sender;
		}
	}
}
