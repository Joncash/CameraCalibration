using CalibrationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Calibration
{
    internal class CalibrationPlateExtractionParameterMapping
    {
		public CalibrateType CalibrateType { get; set; }
        public List<Control> ValueControls { get; set; }
        public Button ResetButton { get; set; }
        public decimal DefaultValue { get; set; }
    }
}
