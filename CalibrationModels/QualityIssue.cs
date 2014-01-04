using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationModels
{
	/// <summary>
	/// 影像品質物件
	/// </summary>
	public class QualityIssue
	{
		/// <summary>
		/// Quality
		/// </summary>
		public double Score { get; set; }
		// description
		public string Issue { get; set; }
		/// <summary>
		/// Scope
		/// </summary>
		public string Scope { get; set; }
		/// <summary>
		/// Detail
		/// </summary>
		public string Detail { get; set; }

	}
}
