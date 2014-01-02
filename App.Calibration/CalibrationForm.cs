using CalibrationModels;
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
			initCalibrationGrideViewOperatorUI();
			
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

        private void Calibration_Calibration_CalibrateButton_Click(object sender, EventArgs e)
        {
            var settingParameters = getSettingParameters();
            var calibrateParameters = getCalibrateParameters();
            var resultParameters = getCalibrateResultParameters();

            //var dict = new Dictionary<CalibrateResultType, object>();
            //dict.Add(CalibrateResultType.CalibrationStatus_Status, "XX");
            //setCalibrateResultParameters(dict);
        }

        private Dictionary<CalibrateSettingType, object> getSettingParameters()
        {
            Dictionary<CalibrateSettingType, object> parameters = new Dictionary<CalibrateSettingType, object>();
            
            parameters.Add(CalibrateSettingType.CalibrationTaskType,  CalibrationTaskType.FullCalibration);
            parameters.Add(CalibrateSettingType.DescriptionFile,      Settings_CalibrationPlate_DescriptionFile.Text);
            parameters.Add(CalibrateSettingType.Thickness,            Settings_CalibrationPlate_Thickness.Value);
            parameters.Add(CalibrateSettingType.CameraModel,          Settings_CameraParameters_CameraModel.SelectedValue);
            parameters.Add(CalibrateSettingType.CellWidthSx,          Settings_CameraParameters_CameraCellWithSx.Value);
            parameters.Add(CalibrateSettingType.CellHeightSy,         Settings_CameraParameters_CameraCellHeightSy.Value);
            parameters.Add(CalibrateSettingType.ForcalLength,         Settings_CameraParameters_CameraForcal.Value);
            parameters.Add(CalibrateSettingType.Telecentric,          Settings_CameraParameters_Telecentric.Checked);

            return parameters;
        }

        private Dictionary<CalibrateType, object> getCalibrateParameters()
        {
            Dictionary<CalibrateType, object> parameters = new Dictionary<CalibrateType, object>();

            parameters.Add(CalibrateType.ImageSource_Type,                                  Calibration_ImageSource_ImageFiles.Checked ? CalibrateImageSourceType.ImageFiles : CalibrateImageSourceType.ImageAcquisitionAssistant);
            parameters.Add(CalibrateType.ImageSource_ImageAcquisitionAssistant,             Calibration_ImageSource_ImageAcquisitionAssistantComboBox.SelectedValue);
            parameters.Add(CalibrateType.Calibration_LiveTests,                             Calibration_Calibration_LiveTests.Checked);
            parameters.Add(CalibrateType.Calibration_AutoUpdate,                            Calibration_Calibration_AutoUpdate.Checked);
            parameters.Add(CalibrateType.QualityIssues_ImageTests,                          Calibration_QualityIssue_ImageTests.SelectedValue);
            parameters.Add(CalibrateType.QualityIssues_SequenceTests,                       Calibration_QualityIssue_SequenceTests.SelectedValue);
            parameters.Add(CalibrateType.QualityIssues_WarningLevel,                        Calibration_QualityIssue_WarningLevel.Value);
            parameters.Add(CalibrateType.QualityIssues_LiveTests,                           Calibration_QualityIssue_LiveTests.Checked);
            parameters.Add(CalibrateType.LocatingTheCalibrationPlate_GaussianFilterSize,    Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown.Value);
            parameters.Add(CalibrateType.LocatingTheCalibrationPlate_MarkThreshod,          Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown.Value);
            parameters.Add(CalibrateType.LocatingTheCalibrationPlate_MinimumMarkDiameters,  Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown.Value);
            parameters.Add(CalibrateType.ExtractingTheMarkRegions_InitialThreshold,         Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown.Value);
            parameters.Add(CalibrateType.ExtractingTheMarkRegions_ThresholdDecremet,        Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown.Value);
            parameters.Add(CalibrateType.ExtractingTheMarkRegions_MinimumThreshold,         Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown.Value);
            parameters.Add(CalibrateType.ExtractingTheMarkContours_Smoothing,               Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.Value);
            parameters.Add(CalibrateType.ExtractingTheMarkContours_MinimumContourLength,    Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown.Value);
            parameters.Add(CalibrateType.ExtractingTheMarkContours_MaximumMarkDiameters,    Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown.Value);

            return parameters;
        }

        private Dictionary<CalibrateResultType, object> getCalibrateResultParameters()
        {
            Dictionary<CalibrateResultType, object> parameters = new Dictionary<CalibrateResultType, object>();

            parameters.Add(CalibrateResultType.CalibrationStatus_Status,            Result_CalibrationStatus.Text);
            parameters.Add(CalibrateResultType.CalibrationStatus_MeanError,         Result_CalibrationMeanError.Text);
            parameters.Add(CalibrateResultType.CameraParameters_CellWidthSx,        Result_CameraParameter_CellWidthSx.Text);
            parameters.Add(CalibrateResultType.CameraParameters_CellHeightSy,       Result_CameraParameter_CellHeightSy.Text);
            parameters.Add(CalibrateResultType.CameraParameters_FocalLength,        Result_CameraParameter_FocalLength.Text);
            parameters.Add(CalibrateResultType.CameraParameters_Kappa,              Result_CameraParameter_Kappa.Text);
            parameters.Add(CalibrateResultType.CameraParameters_CenterColumnCx,     Result_CameraParameter_CenterColumnCx.Text);
            parameters.Add(CalibrateResultType.CameraParameters_CenterRowCy,        Result_CameraParameter_CenterRowCy.Text);
            parameters.Add(CalibrateResultType.CameraParameters_ImageWidth,         Result_CameraParameter_ImageWidth.Text);
            parameters.Add(CalibrateResultType.CameraParameters_ImageHeight,        Result_CameraParameter_ImageHeight.Text);
            parameters.Add(CalibrateResultType.CameraPose_X,                        Result_CameraPose_X.Text);
            parameters.Add(CalibrateResultType.CameraPose_RotationX,                Result_CameraPose_RotationX.Text);
            parameters.Add(CalibrateResultType.CameraPose_Y,                        Result_CameraPose_Y.Text);
            parameters.Add(CalibrateResultType.CameraPose_RotationY,                Result_CameraPose_RotationY.Text);
            parameters.Add(CalibrateResultType.CameraPose_Z,                        Result_CameraPose_Z.Text);
            parameters.Add(CalibrateResultType.CameraPose_RotationZ,                Result_CameraPose_RotationZ.Text);
            parameters.Add(CalibrateResultType.CameraPose_OriginalAtImageCorner,    Result_CameraPose_OriginalAtImageCorner.Checked);

            return parameters;
        }

        private void setCalibrateResultParameters(Dictionary<CalibrateResultType, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                switch (parameter.Key)
                {
                    case CalibrateResultType.CalibrationStatus_Status:
                        Result_CalibrationStatus.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CalibrationStatus_MeanError:
                        Result_CalibrationMeanError.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraParameters_CellWidthSx:
                        Result_CameraParameter_CellWidthSx.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraParameters_CellHeightSy:
                        Result_CameraParameter_CellHeightSy.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraParameters_FocalLength:
                        Result_CameraParameter_FocalLength.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraParameters_Kappa:
                        Result_CameraParameter_Kappa.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraParameters_CenterColumnCx:
                        Result_CameraParameter_CenterColumnCx.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraParameters_CenterRowCy:
                        Result_CameraParameter_CenterRowCy.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraParameters_ImageWidth:
                        Result_CameraParameter_ImageWidth.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraParameters_ImageHeight:
                        Result_CameraParameter_ImageHeight.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraPose_X:
                        Result_CameraPose_RotationX.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraPose_RotationX:
                        Result_CameraPose_RotationX.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraPose_Y:
                        Result_CameraPose_Y.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraPose_RotationY:
                        Result_CameraPose_RotationY.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraPose_Z:
                        Result_CameraPose_Z.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraPose_RotationZ:
                        Result_CameraPose_RotationZ.Text = getObjectDefaultStringValue(parameter.Value);
                        break;
                    case CalibrateResultType.CameraPose_OriginalAtImageCorner:
                        Result_CameraPose_OriginalAtImageCorner.Checked = getObjectDefaultBoolValue(parameter.Value);
                        break;
                }
            }
        }

		private void Calibration_Calibration_AutoUpdate_CheckedChanged(object sender, EventArgs e)
		{
			Calibration_Calibration_UpdateButton.Enabled = !Calibration_Calibration_AutoUpdate.Checked;
		}

        private void Settings_CalibrationPlate_DescriptionFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Plate Description (*.descr)|*.descr|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.Multiselect = false; 
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Settings_CalibrationPlate_DescriptionFile.Text = openFileDialog.FileName;
            }
        }

        private void Calibration_Calibration_LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Images (*.tif *.tiff *.gif *.bmp *.jpg *.jpeg *.jp2 *.png *.pcx *.pgm *.ppm *.pbm *.xwd *.ima)|*.tif;*.tiff;*.gif;*.bmp;*.jpg;*.jpeg;*.jp2;*.png;*.pcx;*.pgm;*.ppm;*.pbm;*.xwd;*.ima|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.Multiselect = true;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
				var fileNames = openFileDialog.FileNames;
				if (fileNames.Length > 0)
				{
					foreach (var fileName in fileNames)
					{
						// todo asynchronous
						CalibrationImage imageModel = new CalibrationImage()
						{
							Image = fileName
						};

						Calibration_Calibration_GridView.Rows.Add(imageModel.Image, imageModel.Status);
					}
					initCalibrationGrideViewOperatorUI();
					updateQualityIssuedGridView();
				}
            }
        }

		private void Calibration_Calibration_RemoveButton_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in Calibration_Calibration_GridView.SelectedRows)
			{
				Calibration_Calibration_GridView.Rows.Remove(row);
			}
			Calibration_Calibration_GridView.Refresh();
			initCalibrationGrideViewOperatorUI();
			updateQualityIssuedGridView();
		}

		private void Calibration_Calibration_RemoveAllButton_Click(object sender, EventArgs e)
		{
			Calibration_Calibration_GridView.Rows.Clear();
			Calibration_Calibration_GridView.Refresh();
			initCalibrationGrideViewOperatorUI();
			updateQualityIssuedGridView();
		}

		private void initCalibrationGrideViewOperatorUI()
		{
			var enable = Calibration_Calibration_GridView.Rows.Count > 0;
			Calibration_Calibration_RemoveButton.Enabled =
			Calibration_Calibration_RemoveAllButton.Enabled = enable;
		}

		private void updateQualityIssuedGridView()
		{
			for (var i = 0; i < 5; i++)
			{
				Calibration_QualityIssue_GridView.Rows.Add(i.ToString(), " description " + i.ToString(), i.ToString() + "%", "detail " + DateTime.Now.Ticks.ToString());
			}
		}

        private string getObjectDefaultStringValue(object obj)
        {
            return obj != null ? obj.ToString() : String.Empty;
        }

		private bool getObjectDefaultBoolValue(object obj)
        {
            var value = getObjectDefaultStringValue(obj);
            bool result = false;
            if (!Boolean.TryParse(value, out result))
            {
                result = false;
            }

            return result;
        }
    }
}
