using CalibrationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationModule
{
	/// <summary>
	/// 鏡頭校正 Assistant
	/// </summary>
	public class CalibrationAssistant
	{
		#region Public Methods
		/// <summary>
		/// 校正
		/// </summary>
		public void Calibrate()
		{
			//toDo
		}

		/// <summary>
		/// 取得影像品質
		/// </summary>
		/// <param name="image"></param>
		/// <returns></returns>
		public QualityIssue GetCalibImageQualityIssue(CalibImage image)
		{
			//toDo
			return new QualityIssue();
		}

		public void SetCalibImage(CalibImage image)
		{

		}
		public void SetCalibrationParam(object type, object value)
		{

		}

		#endregion
	}
}
