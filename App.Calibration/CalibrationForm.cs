using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Calibration
{
    public partial class CalibrationForm : Form
    {
        private List<CalibrationPlateExtractionParameterMapping> _calibrationPlateExtractionParameterMapping
        {
            get
            {
                return new List<CalibrationPlateExtractionParameterMapping>() { 
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        Key = "GaussianFilterSize",
                        DefaultValue = 3,
                        ResetButton = Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar 
                        },
                    }
                };
            }
        }

        public CalibrationForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel_Resize(object sender, EventArgs e)
        {
            var flowPanel = sender as FlowLayoutPanel;
            flowPanel.Controls.OfType<Panel>().ToList().ForEach(x => {
                x.Width = flowPanel.Width - 25;
            });
        }

        private void Calibration_PlateExtractionParameters_ResetButton_Click(object sender, EventArgs e)
        {
            var mapping = _calibrationPlateExtractionParameterMapping.SingleOrDefault(x => x.ResetButton == sender);
            if (mapping != null)
            {
                mapping.ValueControls.OfType<TrackBar>().All(x => {
                    x.Value = (int)mapping.DefaultValue;
                    return true;
                });

                mapping.ValueControls.OfType<NumericUpDown>().All(x =>
                {
                    x.Value = mapping.DefaultValue;
                    return true;
                });
            }
        }

        private void Calibration_PlateExtractionParameters_TrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar currentTrackBar = (TrackBar)sender;
            var mapping = _calibrationPlateExtractionParameterMapping.SingleOrDefault(x => x.ValueControls.Any(vc => vc == sender));
            if (mapping != null)
            {
                mapping.ValueControls.OfType<NumericUpDown>().All(x =>
                {
                    x.Value = currentTrackBar.Value;
                    return true;
                });
            }
        }

        private void Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown currentNumericUpDown = (NumericUpDown)sender;
            var mapping = _calibrationPlateExtractionParameterMapping.SingleOrDefault(x => x.ValueControls.Any(vc => vc == sender));
            if (mapping != null)
            {
                mapping.ValueControls.OfType<TrackBar>().All(x =>
                {
                    x.Value = (int)currentNumericUpDown.Value;
                    return true;
                });
            }
        }
    }
}
