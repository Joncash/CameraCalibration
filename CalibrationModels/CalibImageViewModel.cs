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
			var scopes = new string[] { "影像", "序列" };
			var details = new string[] { "", "影像數太少", "Mark 抽取失敗", "校正片影像不在範圍內", "" };
			Random random = new Random();
			this.CalibImageID = Guid.NewGuid().ToString();
			var score = Math.Round(random.NextDouble(), 2);
			var issue = score > 0.5 ? "Good" : "Bad";
			var scope = scopes[(int)(random.NextDouble() * 10) % 2];
			var detail = details[(int)(random.NextDouble() * 100) % 5];
			this.Status = issue == "Good" ? "OK" : "NG";
			var qIssue = new QualityIssue()
			{
				Issue = issue,
				Score = score,
				Scope = scope,
				Detail = detail,
			};
			QualityIssues.Add(qIssue);
#endif
		}
		public string CalibImageID { get; set; }
		public string Status { get; set; }
		public List<QualityIssue> QualityIssues { get; set; }
	}
}
