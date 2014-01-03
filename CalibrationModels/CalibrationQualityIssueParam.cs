using CalibrationModels.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModels
{
	public class CalibrationQualityIssueParam
	{
		/// <summary>
		/// 影像測試 (All, None, Quick), Default is All
		/// </summary>
		public CalibrationImageTestType ImageTestType = CalibrationImageTestType.All;

		/// <summary>
		/// 序列測試 (All, None, Quick), Default is All
		/// </summary>
		public CalibrationImageSequenceTestType SequenceTestType = CalibrationImageSequenceTestType.All;

		/// <summary>
		/// 警告等級 (%)
		/// </summary>
		public int WarningLevel = 70; // percent
	}
}
