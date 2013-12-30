using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModels
{
    public enum CalibrateResultType
    {
        CalibrationStatus_Status,
        CalibrationStatus_MeanError,
        CameraParameters_CellWidthSx,
        CameraParameters_CellHeightSy,
        CameraParameters_FocalLength,
        CameraParameters_Kappa,
        CameraParameters_CenterColumnCx,
        CameraParameters_CenterRowCy,
        CameraParameters_ImageWidth,
        CameraParameters_ImageHeight,
        CameraPose_X,
        CameraPose_RotationX,
        CameraPose_Y,
        CameraPose_RotationY,
        CameraPose_Z,
        CameraPose_RotationZ,
        CameraPose_OriginalAtImageCorner
    }
}
