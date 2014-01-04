using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationModels
{
    public enum CalibrateSettingType
    {
        CalibrationTaskType,
        DescriptionFile,
        Thickness,
        CameraModel,
        CellWidthSx,
        CellHeightSy,
        ForcalLength,
        Telecentric
    }

    public enum CalibrationTaskType
    {
        FullCalibration
    }

	public enum CameraModelType
	{
		AreaScanDivision,
		AreaScanPolynomial,
		LineScan
	}
}
