using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModels
{
	/// <summary>
	/// 儲存影像的校正狀態及品質資料
	/// </summary>
	public class CalibImageViewModel
	{
		public CalibImageViewModel()
		{
			QualityIssues = new List<QualityIssue>();
#if DEBUG
			//Fake Data
			this.CalibImageID = Guid.NewGuid().ToString();
			this.Status = "OK @" + DateTime.Now.ToString("yyyyMMddHHmmss");
			var qIssue = new QualityIssue()
			{
				Issue = "Good",
				Score = 0.8,
			};
			QualityIssues.Add(qIssue);
#endif
		}
		public string CalibImageID { get; set; }
		public string Status { get; set; }
		public List<QualityIssue> QualityIssues { get; set; }
	}
}
