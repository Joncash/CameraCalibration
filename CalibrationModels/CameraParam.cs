using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModels
{
	/// <summary>
	/// 鏡頭參數
	/// </summary>
	public class CameraParam
	{
		public string CameraType { get; set; }
		public double Sx { get; set; }
		public double Sy { get; set; }
		public double Focus { get; set; }
		public bool IsTelecentric { get; set; }
	}
}
