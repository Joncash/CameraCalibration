using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModels
{
	/// <summary>
	/// 校正後資料模型
	/// </summary>
	public class CalibratedViewModel
	{
		public string CalibrationStatus_Status { get; set; }
        public string CalibrationStatus_MeanError { get; set; }
        public string CameraParameters_CellWidthSx { get; set; }
        public string CameraParameters_CellHeightSy { get; set; }
        public string CameraParameters_FocalLength { get; set; }
        public string CameraParameters_Kappa { get; set; }
        public string CameraParameters_CenterColumnCx { get; set; }
        public string CameraParameters_CenterRowCy { get; set; }
        public string CameraParameters_ImageWidth { get; set; }
        public string CameraParameters_ImageHeight { get; set; }
        public string CameraPose_X { get; set; }
        public string CameraPose_RotationX { get; set; }
        public string CameraPose_Y { get; set; }
        public string CameraPose_RotationY { get; set; }
        public string CameraPose_Z { get; set; }
        public string CameraPose_RotationZ { get; set; }
        public bool CameraPose_OriginalAtImageCorner { get; set; }
	}
}
