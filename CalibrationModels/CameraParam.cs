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
		public CameraParam()
		{
			//default value
			Kappa = K1 = K2 = K3 = P1 = P2 = 0.0;

			Vx = Vz = 0;
			Vy = 500.0;
		}
		public CameraModelType CameraType { get; set; }
		public bool IsTelecentric { get; set; }

		#region Common param
		/// <summary>
		/// Cell Width
		/// </summary>
		public double Sx { get; set; }

		/// <summary>
		/// Cell Height
		/// </summary>
		public double Sy { get; set; }

		/// <summary>
		/// FocalLength
		/// </summary>
		public double Focus { get; set; }
		#endregion

		#region AreaScanDivision param
		public double Kappa { get; set; }
		#endregion

		#region AreaScanPolynomial param
		public double K1 { get; set; }
		public double K2 { get; set; }
		public double K3 { get; set; }
		public double P1 { get; set; }
		public double P2 { get; set; }
		#endregion

		#region LineScan Param
		/// <summary>
		/// Motion Vector X
		/// </summary>
		public double Vx { get; set; }

		/// <summary>
		/// Motion Vector Y
		/// </summary>
		public double Vy { get; set; }

		/// <summary>
		/// Motion Vector Z
		/// </summary>
		public double Vz { get; set; }
		#endregion

	}
}