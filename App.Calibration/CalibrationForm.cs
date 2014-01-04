﻿using CalibrationModels;
using CalibrationModule;
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
				CalibrationPlateParam defaultParam = new CalibrationPlateParam();
                return new List<CalibrationPlateExtractionParameterMapping>() { 
                    new CalibrationPlateExtractionParameterMapping()
                    {
                        CalibrateType = CalibrateType.LocatingTheCalibrationPlate_GaussianFilterSize,
                        DefaultValue = defaultParam.GaussianFilterSize,
                        ResetButton = Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
						CalibrateType = CalibrateType.LocatingTheCalibrationPlate_MarkThreshold,
                        DefaultValue = defaultParam.MarkThreshold,
                        ResetButton = Calibration_PlateExtractionParameters_MarkThresholdResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MarkThresholdNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MarkThresholdTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
						CalibrateType = CalibrateType.LocatingTheCalibrationPlate_MinimumMarkDiameters,
                        DefaultValue = defaultParam.MinMarkDiam,
                        ResetButton = Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
						CalibrateType = CalibrateType.ExtractingTheMarkRegions_InitialThreshold,
                        DefaultValue = defaultParam.StartThresh,
                        ResetButton = Calibration_PlateExtractionParameters_InitialThresholdResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
						CalibrateType = CalibrateType.ExtractingTheMarkRegions_ThresholdDecremet,
                        DefaultValue = defaultParam.DeltaThresh,
                        ResetButton = Calibration_PlateExtractionParameters_ThresholdDecremetResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
						CalibrateType = CalibrateType.ExtractingTheMarkRegions_MinimumThreshold,
                        DefaultValue = defaultParam.MinThresh,
                        ResetButton = Calibration_PlateExtractionParameters_MinimumThresholdResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
						CalibrateType = CalibrateType.ExtractingTheMarkContours_Smoothing,
                        DefaultValue = (decimal)defaultParam.Alpha,
                        ResetButton = Calibration_PlateExtractionParameters_SmoothingAlphaResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
						CalibrateType = CalibrateType.ExtractingTheMarkContours_MinimumContourLength,
                        DefaultValue = (decimal)defaultParam.MinContourLength,
                        ResetButton = Calibration_PlateExtractionParameters_MinimumContourLengthResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar 
                        },
                    },
                    new CalibrationPlateExtractionParameterMapping()
                    {
						CalibrateType = CalibrateType.ExtractingTheMarkContours_MaximumMarkDiameters,
                        DefaultValue = (decimal)defaultParam.MaxDiameterMarks,
                        ResetButton = Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton,
                        ValueControls = new List<Control>(){ 
                            this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown, 
                            this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar 
                        },
                    }
                };
            }
        }
		
		private CalibrationAssistant _assistant = null;
        
		public CalibrationForm()
        {
			InitializeComponent();
			_assistant = new CalibrationAssistant(
									new CalibrationPlateParam(),
									new CalibrationQualityIssueParam(),
									new CameraParam(),
									Settings_CalibrationPlate_DescriptionFile.Text,
									(double)Settings_CalibrationPlate_Thickness.Value
									);
			
			initCalibrationGrideViewOperatorUI();
			initCombox();
		}

		private void initCombox()
		{
			Dictionary<CameraModelType, string> Settings_CameraParameters_CameraModelTypeData = new Dictionary<CameraModelType, string>();
			Settings_CameraParameters_CameraModelTypeData.Add(CameraModelType.AreaScanDivision, "Area Scan ( Division )");
			Settings_CameraParameters_CameraModelTypeData.Add(CameraModelType.AreaScanPolynomial, "Area Scan ( Polynomial )");
			Settings_CameraParameters_CameraModelTypeData.Add(CameraModelType.LineScan, "Line Scan");

			Settings_CameraParameters_CameraModel.DataSource = new BindingSource(Settings_CameraParameters_CameraModelTypeData, null);
			Settings_CameraParameters_CameraModel.DisplayMember = "Value";
			Settings_CameraParameters_CameraModel.ValueMember = "Key";

			Dictionary<QualityIssueTestType, string> Settings_CameraParameters_QualityIssuedTestTypeData = new Dictionary<QualityIssueTestType, string>();
			Settings_CameraParameters_QualityIssuedTestTypeData.Add(QualityIssueTestType.All, "All");
			Settings_CameraParameters_QualityIssuedTestTypeData.Add(QualityIssueTestType.Quick, "Quick");
			Settings_CameraParameters_QualityIssuedTestTypeData.Add(QualityIssueTestType.None, "None");

			Calibration_QualityIssue_ImageTests.DataSource = new BindingSource(Settings_CameraParameters_QualityIssuedTestTypeData, null);
			Calibration_QualityIssue_ImageTests.DisplayMember = "Value";
			Calibration_QualityIssue_ImageTests.ValueMember = "Key";


			Calibration_QualityIssue_SequenceTests.DataSource = new BindingSource(Settings_CameraParameters_QualityIssuedTestTypeData, null);
			Calibration_QualityIssue_SequenceTests.DisplayMember = "Value";
			Calibration_QualityIssue_SequenceTests.ValueMember = "Key";
		}

		private void flowLayoutPanel_Resize(object sender, EventArgs e)
        {
            var flowPanel = sender as FlowLayoutPanel;
            flowPanel.Controls.OfType<Panel>().ToList().ForEach(x => {
                x.Width = flowPanel.Width - 25;
            });
        }

		#region SettingTab Event
		private void Settings_CalibrationPlate_DescriptionFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Plate Description (*.descr)|*.descr|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 0;
			openFileDialog.Multiselect = false;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				_assistant.SetCameraParam(CalibrateSettingType.DescriptionFile, openFileDialog.FileName);
			}
		}

		private void Settings_CalibrationPlate_Thickness_ValueChanged(object sender, EventArgs e)
		{
			var control = ((NumericUpDown)sender);
			_assistant.SetCameraParam(CalibrateSettingType.Thickness, control.Value);
		}

		private void Settings_CameraParameters_CameraModel_SelectedValueChanged(object sender, EventArgs e)
		{
			var control = ((ComboBox)sender);
			_assistant.SetCameraParam(CalibrateSettingType.CameraModel, control.SelectedValue);
		}

		private void Settings_CameraParameters_CameraCellWithSx_ValueChanged(object sender, EventArgs e)
		{
			var control = ((NumericUpDown)sender);
			_assistant.SetCameraParam(CalibrateSettingType.CellWidthSx, control.Value);
		}

		private void Settings_CameraParameters_CameraCellHeightSy_ValueChanged(object sender, EventArgs e)
		{
			var control = ((NumericUpDown)sender);
			_assistant.SetCameraParam(CalibrateSettingType.CellHeightSy, control.Value);
		}

		private void Settings_CameraParameters_CameraForcal_ValueChanged(object sender, EventArgs e)
		{
			var control = ((NumericUpDown)sender);
			_assistant.SetCameraParam(CalibrateSettingType.ForcalLength, control.Value);
		}

		private void Settings_CameraParameters_Telecentric_CheckedChanged(object sender, EventArgs e)
		{
			var control = ((CheckBox)sender);
			_assistant.SetCameraParam(CalibrateSettingType.ForcalLength, control.Checked);
		} 
		#endregion

		#region CalibrationTab Event

		#region Calibration event

		private void Calibration_Calibration_SaveButton_Click(object sender, EventArgs e)
		{
			// todo get imageID
			_assistant.SaveCalibImage("");
		}

		private void Calibration_Calibration_SaveAllButton_Click(object sender, EventArgs e)
		{
			// todo each images
			// todo get imageID
			_assistant.SaveCalibImage("");
		}

		private void Calibration_Calibration_UpdateButton_Click(object sender, EventArgs e)
		{
			// todo get imageID
			_assistant.UpdateCalibImageQualityIssue("");
		}

		private void Calibration_Calibration_SetReferenceButton_Click(object sender, EventArgs e)
		{
			// todo get imageID
			_assistant.SetCalibImageReference("");
		}

		private void Calibration_Calibration_CalibrateButton_Click(object sender, EventArgs e)
		{
			_assistant.Calibrate();
			//var dict = new Dictionary<CalibrateResultType, object>();
			//dict.Add(CalibrateResultType.CalibrationStatus_Status, "XX");
			//setCalibrateResultParameters(dict);
		}

		private void Calibration_Calibration_AutoUpdate_CheckedChanged(object sender, EventArgs e)
		{
			Calibration_Calibration_UpdateButton.Enabled = !Calibration_Calibration_AutoUpdate.Checked;
			_assistant.SetCalibrationPlateParam(CalibrateType.Calibration_AutoUpdate, Calibration_Calibration_AutoUpdate.Checked);
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
						//CalibrationImage imageModel = new CalibrationImage()
						//{
						//	Image = fileName
						//};

						//Calibration_Calibration_GridView.Rows.Add(imageModel.Image, imageModel.Status);
						_assistant.AddCalibImage(fileName);
					}
					//initCalibrationGrideViewOperatorUI();
					//updateQualityIssuedGridView();
				}
			}
		}

		private void Calibration_Calibration_RemoveButton_Click(object sender, EventArgs e)
		{
			// TODO Get ImageID
			_assistant.RemoveCalibImage("");
			//foreach (DataGridViewRow row in Calibration_Calibration_GridView.SelectedRows)
			//{
			//	Calibration_Calibration_GridView.Rows.Remove(row);
			//}
			//Calibration_Calibration_GridView.Refresh();
			//initCalibrationGrideViewOperatorUI();
			//updateQualityIssuedGridView();
		}

		private void Calibration_Calibration_RemoveAllButton_Click(object sender, EventArgs e)
		{
			_assistant.RemoveAllCalibImages();

			//Calibration_Calibration_GridView.Rows.Clear();
			//Calibration_Calibration_GridView.Refresh();
			//initCalibrationGrideViewOperatorUI();
			//updateQualityIssuedGridView();
		}  
		#endregion

		#region Quality Issue
		private void Calibration_QualityIssue_WarningLevel_ValueChanged(object sender, EventArgs e)
		{
			var control = ((ComboBox)sender);
			_assistant.SetCalibrationPlateParam(CalibrateType.QualityIssues_WarningLevel, control.SelectedValue);
		}

		private void Calibration_QualityIssue_SequenceTests_SelectedIndexChanged(object sender, EventArgs e)
		{
			var control = ((ComboBox)sender);
			_assistant.SetCalibrationPlateParam(CalibrateType.QualityIssues_SequenceTests, control.SelectedValue);
		}

		private void Calibration_QualityIssue_ImageTests_SelectedIndexChanged(object sender, EventArgs e)
		{
			var control = ((ComboBox)sender);
			_assistant.SetCalibrationPlateParam(CalibrateType.QualityIssues_ImageTests, control.SelectedValue);
		}

		private void Calibration_QualityIssue_LiveTests_CheckedChanged(object sender, EventArgs e)
		{
			var control = ((CheckBox)sender);
			_assistant.SetCalibrationPlateParam(CalibrateType.QualityIssues_LiveTests, control.Checked);
		}
		#endregion

		#region PlateExtractionParameters event

		private void Calibration_PlateExtractionParameters_ResetButton_Click(object sender, EventArgs e)
		{
			var mapping = _calibrationPlateExtractionParameterMapping.SingleOrDefault(x => x.ResetButton == sender);
			if (mapping != null)
			{
				mapping.ValueControls.OfType<TrackBar>().All(x =>
				{
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
				var currentValue = currentNumericUpDown.Value;
				mapping.ValueControls.OfType<TrackBar>().All(x =>
				{
					if (currentNumericUpDown == Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown)
					{
						x.Value = (int)(currentValue * 10);
					}
					else
					{
						x.Value = (int)currentValue;
					}
					return true;
				});

				_assistant.SetCalibrationPlateParam(mapping.CalibrateType, currentValue);
			}
		} 
		
		#endregion

		#endregion

		#region private method

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
            parameters.Add(CalibrateType.LocatingTheCalibrationPlate_MarkThreshold,          Calibration_PlateExtractionParameters_MarkThresholdNumericUpDown.Value);
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
		
		#endregion

		
    }
}
