using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModels
{
    public enum CalibrateType
    {
        ImageSource_Type,
        ImageSource_ImageAcquisitionAssistant,
        Calibration_LiveTests,
        Calibration_AutoUpdate,
        QualityIssues_ImageTests,
        QualityIssues_SequenceTests,
        QualityIssues_WarningLevel,
        QualityIssues_LiveTests,
        LocatingTheCalibrationPlate_GaussianFilterSize,
        LocatingTheCalibrationPlate_MarkThreshod,
        LocatingTheCalibrationPlate_MinimumMarkDiameters,
        ExtractingTheMarkRegions_InitialThreshold,
        ExtractingTheMarkRegions_ThresholdDecremet,
        ExtractingTheMarkRegions_MinimumThreshold,
        ExtractingTheMarkContours_Smoothing,
        ExtractingTheMarkContours_MinimumContourLength,
        ExtractingTheMarkContours_MaximumMarkDiameters
    }
    
    public enum CalibrateImageSourceType
    {
        ImageFiles,
        ImageAcquisitionAssistant
    }
}
