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
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        Key = "MarkThreshod",
                        DefaultValue = 112,
                        ResetButton = Calibration_PlateExtractionParameters_MarkThreshodResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        Key = "MinimumMarkDiameters",
                        DefaultValue = 5,
                        ResetButton = Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        Key = "InitialThreshold",
                        DefaultValue = 128,
                        ResetButton = Calibration_PlateExtractionParameters_InitialThresholdResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        Key = "ThresholdDecremet",
                        DefaultValue = 10,
                        ResetButton = Calibration_PlateExtractionParameters_ThresholdDecremetResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        Key = "MinimumThreshold",
                        DefaultValue = 18,
                        ResetButton = Calibration_PlateExtractionParameters_MinimumThresholdResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        Key = "SmoothingAlpha",
                        DefaultValue = 0.9M,
                        ResetButton = Calibration_PlateExtractionParameters_SmoothingAlphaResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        Key = "MinimumContourLength",
                        DefaultValue = 15,
                        ResetButton = Calibration_PlateExtractionParameters_MinimumContourLengthResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        Key = "MaximumMarkDiameters",
                        DefaultValue = 100,
                        ResetButton = Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar 
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
                    if (x == Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar)
                    {
                        x.Value = (int)(mapping.DefaultValue * 10); ;
                    }
                    else
                    {
                        x.Value = (int)mapping.DefaultValue;
                    }
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
                    if (currentTrackBar == Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar)
                    {
                        x.Value = ((decimal)currentTrackBar.Value) / 10;
                    }
                    else
                    {
                        x.Value = currentTrackBar.Value;
                    }
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
                    if (currentNumericUpDown == Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown)
                    {
                        x.Value = (int)(currentNumericUpDown.Value * 10);
                    }
                    else
                    {
                        x.Value = (int)currentNumericUpDown.Value;
                    }
                    return true;
                });
            }
        }
    }
}
