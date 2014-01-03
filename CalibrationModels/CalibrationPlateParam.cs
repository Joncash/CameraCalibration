using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModels
{
	//toDO, 參數的邊界值

	/// <summary>
	/// 校正片的擷取參數
	/// </summary>
	public class CalibrationPlateParam
	{
		public CalibrationPlateParam()
		{
			//設定預設值
			this.GaussianFilterSize = 3;
			this.MarkThreshold = 112;
			this.MinMarkDiam = 5;

			this.StartThresh = 128;
			this.DeltaThresh = 10;
			this.MinThresh = 18;

			this.Alpha = 0.9;
			this.MinContourLength = 15.0;
			this.MaxDiameterMarks = 100.0;

		}

		#region 定位校正片
		/// <summary>
		/// 高斯濾波器大小
		/// </summary>
		public int GaussianFilterSize { get; set; }

		/// <summary>
		/// Mark 門檻值
		/// </summary>
		public int MarkThreshold { get; set; }

		/// <summary>
		/// Minimum mark diameters (最小 Mark 直徑)
		/// </summary>
		public int MinMarkDiam { get; set; }
		#endregion


		#region 擷取標誌區域
		/// <summary>
		/// 初始門檻值
		/// </summary>
		public int StartThresh { get; set; }

		/// <summary>
		/// 門檻值減量
		/// </summary>
		public int DeltaThresh { get; set; }

		/// <summary>
		/// 最小門檻值
		/// </summary>
		public int MinThresh { get; set; }
		#endregion


		#region 抽取 Mark 輪廓
		/// <summary>
		/// 平滑
		/// </summary>
		public double Alpha { get; set; }

		/// <summary>
		/// 最小輪廓長
		/// </summary>
		public double MinContourLength { get; set; }

		/// <summary>
		/// 最大 Mark 直徑
		/// </summary>
		public double MaxDiameterMarks { get; set; }
		#endregion

	}
}
