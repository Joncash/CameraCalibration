namespace App.Calibration
{
    partial class CalibrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.CalibrationTab = new System.Windows.Forms.TabControl();
			this.SettingsTabPage = new System.Windows.Forms.TabPage();
			this.SettingsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.CalibrationTaskExpandPanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.Settings_CalibrationTask_FullCalibration = new System.Windows.Forms.RadioButton();
			this.CalibrationPlateExpandPanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.Settings_CalibrationPlate_DescriptionFileButton = new System.Windows.Forms.Button();
			this.Settings_CalibrationPlate_DescriptionFile = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Settings_CalibrationPlate_Thickness = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CameraParametersExpandPanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.Settings_CameraParameters_Telecentric = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Settings_CameraParameters_CameraForcal = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Settings_CameraParameters_CameraCellHeightSy = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Settings_CameraParameters_CameraCellWithSx = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.Settings_CameraParameters_CameraModel = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CalibrationTabPage = new System.Windows.Forms.TabPage();
			this.CalibrationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.ImageSourceExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.Calibration_ImageSource_ImageAcquisitionAssistantOpenButton = new System.Windows.Forms.Button();
			this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox = new System.Windows.Forms.ComboBox();
			this.Calibration_ImageSource_ImageAcquisitionAssistantRadioButton = new System.Windows.Forms.RadioButton();
			this.Calibration_ImageSource_ImageFiles = new System.Windows.Forms.RadioButton();
			this.CalibrationExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.Calibration_Calibration_AutoUpdate = new System.Windows.Forms.CheckBox();
			this.Calibration_Calibration_LiveTests = new System.Windows.Forms.CheckBox();
			this.Calibration_Calibration_CalibrateButton = new System.Windows.Forms.Button();
			this.Calibration_Calibration_SetReferenceButton = new System.Windows.Forms.Button();
			this.Calibration_Calibration_UpdateButton = new System.Windows.Forms.Button();
			this.Calibration_Calibration_SaveAllButton = new System.Windows.Forms.Button();
			this.Calibration_Calibration_SaveButton = new System.Windows.Forms.Button();
			this.Calibration_Calibration_RemoveAllButton = new System.Windows.Forms.Button();
			this.Calibration_Calibration_RemoveButton = new System.Windows.Forms.Button();
			this.Calibration_Calibration_LoadButton = new System.Windows.Forms.Button();
			this.Calibration_Calibration_GridView = new System.Windows.Forms.DataGridView();
			this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QualityIssuesExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.Calibration_QualityIssue_LiveTests = new System.Windows.Forms.CheckBox();
			this.Calibration_QualityIssue_WarningLevel = new System.Windows.Forms.NumericUpDown();
			this.label56 = new System.Windows.Forms.Label();
			this.Calibration_QualityIssue_SequenceTests = new System.Windows.Forms.ComboBox();
			this.label55 = new System.Windows.Forms.Label();
			this.Calibration_QualityIssue_ImageTests = new System.Windows.Forms.ComboBox();
			this.label28 = new System.Windows.Forms.Label();
			this.Calibration_QualityIssue_GridView = new System.Windows.Forms.DataGridView();
			this.Scope = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CalibrationPlateExtractionParametersExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton = new System.Windows.Forms.Button();
			this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton = new System.Windows.Forms.Button();
			this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton = new System.Windows.Forms.Button();
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar = new System.Windows.Forms.TrackBar();
			this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar = new System.Windows.Forms.TrackBar();
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar = new System.Windows.Forms.TrackBar();
			this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton = new System.Windows.Forms.Button();
			this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton = new System.Windows.Forms.Button();
			this.Calibration_PlateExtractionParameters_InitialThresholdResetButton = new System.Windows.Forms.Button();
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar = new System.Windows.Forms.TrackBar();
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar = new System.Windows.Forms.TrackBar();
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar = new System.Windows.Forms.TrackBar();
			this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton = new System.Windows.Forms.Button();
			this.Calibration_PlateExtractionParameters_MarkThreshodResetButton = new System.Windows.Forms.Button();
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton = new System.Windows.Forms.Button();
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar = new System.Windows.Forms.TrackBar();
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar = new System.Windows.Forms.TrackBar();
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar = new System.Windows.Forms.TrackBar();
			this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.ResultTabPage = new System.Windows.Forms.TabPage();
			this.ResultFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.label26 = new System.Windows.Forms.Label();
			this.Result_CalibrationMeanError = new System.Windows.Forms.TextBox();
			this.Result_CalibrationStatus = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.CameraParameterExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.label57 = new System.Windows.Forms.Label();
			this.Result_CameraParameter_ExportButton = new System.Windows.Forms.Button();
			this.label35 = new System.Windows.Forms.Label();
			this.Result_CameraParameter_ImageHeight = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.Result_CameraParameter_ImageWidth = new System.Windows.Forms.TextBox();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.Result_CameraParameter_CenterRowCy = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.Result_CameraParameter_CenterColumnCx = new System.Windows.Forms.TextBox();
			this.label42 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.Result_CameraParameter_Kappa = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.Result_CameraParameter_FocalLength = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.Result_CameraParameter_CellHeightSy = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.Result_CameraParameter_CellWidthSx = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.CameraPoseExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
			this.Result_CameraPose_OriginalAtImageCorner = new System.Windows.Forms.CheckBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.Result_CameraPose_RotationZ = new System.Windows.Forms.TextBox();
			this.label49 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.Result_CameraPose_Z = new System.Windows.Forms.TextBox();
			this.label51 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Result_CameraPose_RotationY = new System.Windows.Forms.TextBox();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.Result_CameraPose_Y = new System.Windows.Forms.TextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Result_CameraPose_RotationX = new System.Windows.Forms.TextBox();
			this.label54 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Result_CameraPose_X = new System.Windows.Forms.TextBox();
			this.label47 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.Reult_CameraPose_ExportBatton = new System.Windows.Forms.Button();
			this.CalibrateStatusStrip = new System.Windows.Forms.StatusStrip();
			this.CalibrateStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.CalibrationTab.SuspendLayout();
			this.SettingsTabPage.SuspendLayout();
			this.SettingsFlowLayoutPanel.SuspendLayout();
			this.CalibrationTaskExpandPanel.SuspendLayout();
			this.CalibrationPlateExpandPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Settings_CalibrationPlate_Thickness)).BeginInit();
			this.CameraParametersExpandPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Settings_CameraParameters_CameraForcal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Settings_CameraParameters_CameraCellHeightSy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Settings_CameraParameters_CameraCellWithSx)).BeginInit();
			this.CalibrationTabPage.SuspendLayout();
			this.CalibrationFlowLayoutPanel.SuspendLayout();
			this.ImageSourceExpandCollapsePanel.SuspendLayout();
			this.CalibrationExpandCollapsePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_Calibration_GridView)).BeginInit();
			this.QualityIssuesExpandCollapsePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_QualityIssue_WarningLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_QualityIssue_GridView)).BeginInit();
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown)).BeginInit();
			this.ResultTabPage.SuspendLayout();
			this.ResultFlowLayoutPanel.SuspendLayout();
			this.expandCollapsePanel1.SuspendLayout();
			this.CameraParameterExpandCollapsePanel.SuspendLayout();
			this.CameraPoseExpandCollapsePanel.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.CalibrateStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// CalibrationTab
			// 
			this.CalibrationTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CalibrationTab.Controls.Add(this.SettingsTabPage);
			this.CalibrationTab.Controls.Add(this.CalibrationTabPage);
			this.CalibrationTab.Controls.Add(this.ResultTabPage);
			this.CalibrationTab.Location = new System.Drawing.Point(0, 0);
			this.CalibrationTab.Name = "CalibrationTab";
			this.CalibrationTab.SelectedIndex = 0;
			this.CalibrationTab.Size = new System.Drawing.Size(1017, 606);
			this.CalibrationTab.TabIndex = 0;
			// 
			// SettingsTabPage
			// 
			this.SettingsTabPage.BackColor = System.Drawing.Color.White;
			this.SettingsTabPage.Controls.Add(this.SettingsFlowLayoutPanel);
			this.SettingsTabPage.Location = new System.Drawing.Point(4, 22);
			this.SettingsTabPage.Name = "SettingsTabPage";
			this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.SettingsTabPage.Size = new System.Drawing.Size(1009, 580);
			this.SettingsTabPage.TabIndex = 0;
			this.SettingsTabPage.Text = "設定";
			// 
			// SettingsFlowLayoutPanel
			// 
			this.SettingsFlowLayoutPanel.AutoScroll = true;
			this.SettingsFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.SettingsFlowLayoutPanel.Controls.Add(this.CalibrationTaskExpandPanel);
			this.SettingsFlowLayoutPanel.Controls.Add(this.CalibrationPlateExpandPanel);
			this.SettingsFlowLayoutPanel.Controls.Add(this.CameraParametersExpandPanel);
			this.SettingsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SettingsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.SettingsFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.SettingsFlowLayoutPanel.Name = "SettingsFlowLayoutPanel";
			this.SettingsFlowLayoutPanel.Size = new System.Drawing.Size(1003, 574);
			this.SettingsFlowLayoutPanel.TabIndex = 4;
			this.SettingsFlowLayoutPanel.WrapContents = false;
			this.SettingsFlowLayoutPanel.Resize += new System.EventHandler(this.flowLayoutPanel_Resize);
			// 
			// CalibrationTaskExpandPanel
			// 
			this.CalibrationTaskExpandPanel.BackColor = System.Drawing.Color.Transparent;
			this.CalibrationTaskExpandPanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.CalibrationTaskExpandPanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.CalibrationTaskExpandPanel.Controls.Add(this.Settings_CalibrationTask_FullCalibration);
			this.CalibrationTaskExpandPanel.ExpandedHeight = 0;
			this.CalibrationTaskExpandPanel.IsExpanded = true;
			this.CalibrationTaskExpandPanel.Location = new System.Drawing.Point(3, 3);
			this.CalibrationTaskExpandPanel.Name = "CalibrationTaskExpandPanel";
			this.CalibrationTaskExpandPanel.Size = new System.Drawing.Size(987, 74);
			this.CalibrationTaskExpandPanel.TabIndex = 0;
			this.CalibrationTaskExpandPanel.Text = "Calibration Task";
			this.CalibrationTaskExpandPanel.UseAnimation = false;
			// 
			// Settings_CalibrationTask_FullCalibration
			// 
			this.Settings_CalibrationTask_FullCalibration.AutoSize = true;
			this.Settings_CalibrationTask_FullCalibration.Checked = true;
			this.Settings_CalibrationTask_FullCalibration.Location = new System.Drawing.Point(35, 44);
			this.Settings_CalibrationTask_FullCalibration.Name = "Settings_CalibrationTask_FullCalibration";
			this.Settings_CalibrationTask_FullCalibration.Size = new System.Drawing.Size(292, 19);
			this.Settings_CalibrationTask_FullCalibration.TabIndex = 2;
			this.Settings_CalibrationTask_FullCalibration.TabStop = true;
			this.Settings_CalibrationTask_FullCalibration.Text = "Full Calibration:Pose and all Camera Parameters";
			this.Settings_CalibrationTask_FullCalibration.UseVisualStyleBackColor = true;
			// 
			// CalibrationPlateExpandPanel
			// 
			this.CalibrationPlateExpandPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CalibrationPlateExpandPanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.CalibrationPlateExpandPanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.CalibrationPlateExpandPanel.Controls.Add(this.Settings_CalibrationPlate_DescriptionFileButton);
			this.CalibrationPlateExpandPanel.Controls.Add(this.Settings_CalibrationPlate_DescriptionFile);
			this.CalibrationPlateExpandPanel.Controls.Add(this.label4);
			this.CalibrationPlateExpandPanel.Controls.Add(this.Settings_CalibrationPlate_Thickness);
			this.CalibrationPlateExpandPanel.Controls.Add(this.label2);
			this.CalibrationPlateExpandPanel.Controls.Add(this.label1);
			this.CalibrationPlateExpandPanel.ExpandedHeight = 0;
			this.CalibrationPlateExpandPanel.IsExpanded = true;
			this.CalibrationPlateExpandPanel.Location = new System.Drawing.Point(3, 83);
			this.CalibrationPlateExpandPanel.Name = "CalibrationPlateExpandPanel";
			this.CalibrationPlateExpandPanel.Size = new System.Drawing.Size(987, 119);
			this.CalibrationPlateExpandPanel.TabIndex = 2;
			this.CalibrationPlateExpandPanel.Text = "Calibration Plate";
			this.CalibrationPlateExpandPanel.UseAnimation = false;
			// 
			// Settings_CalibrationPlate_DescriptionFileButton
			// 
			this.Settings_CalibrationPlate_DescriptionFileButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Settings_CalibrationPlate_DescriptionFileButton.Location = new System.Drawing.Point(885, 42);
			this.Settings_CalibrationPlate_DescriptionFileButton.Name = "Settings_CalibrationPlate_DescriptionFileButton";
			this.Settings_CalibrationPlate_DescriptionFileButton.Size = new System.Drawing.Size(75, 23);
			this.Settings_CalibrationPlate_DescriptionFileButton.TabIndex = 6;
			this.Settings_CalibrationPlate_DescriptionFileButton.Text = "Open ...";
			this.Settings_CalibrationPlate_DescriptionFileButton.UseVisualStyleBackColor = true;
			this.Settings_CalibrationPlate_DescriptionFileButton.Click += new System.EventHandler(this.Settings_CalibrationPlate_DescriptionFileButton_Click);
			// 
			// Settings_CalibrationPlate_DescriptionFile
			// 
			this.Settings_CalibrationPlate_DescriptionFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Settings_CalibrationPlate_DescriptionFile.Location = new System.Drawing.Point(196, 43);
			this.Settings_CalibrationPlate_DescriptionFile.Name = "Settings_CalibrationPlate_DescriptionFile";
			this.Settings_CalibrationPlate_DescriptionFile.Size = new System.Drawing.Size(683, 21);
			this.Settings_CalibrationPlate_DescriptionFile.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(433, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "mm";
			// 
			// Settings_CalibrationPlate_Thickness
			// 
			this.Settings_CalibrationPlate_Thickness.DecimalPlaces = 3;
			this.Settings_CalibrationPlate_Thickness.Location = new System.Drawing.Point(196, 81);
			this.Settings_CalibrationPlate_Thickness.Name = "Settings_CalibrationPlate_Thickness";
			this.Settings_CalibrationPlate_Thickness.Size = new System.Drawing.Size(231, 21);
			this.Settings_CalibrationPlate_Thickness.TabIndex = 3;
			this.Settings_CalibrationPlate_Thickness.Value = new decimal(new int[] {
            630,
            0,
            0,
            196608});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Thickness";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Description File";
			// 
			// CameraParametersExpandPanel
			// 
			this.CameraParametersExpandPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CameraParametersExpandPanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.CameraParametersExpandPanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.CameraParametersExpandPanel.Controls.Add(this.Settings_CameraParameters_Telecentric);
			this.CameraParametersExpandPanel.Controls.Add(this.label11);
			this.CameraParametersExpandPanel.Controls.Add(this.label9);
			this.CameraParametersExpandPanel.Controls.Add(this.Settings_CameraParameters_CameraForcal);
			this.CameraParametersExpandPanel.Controls.Add(this.label10);
			this.CameraParametersExpandPanel.Controls.Add(this.label7);
			this.CameraParametersExpandPanel.Controls.Add(this.Settings_CameraParameters_CameraCellHeightSy);
			this.CameraParametersExpandPanel.Controls.Add(this.label8);
			this.CameraParametersExpandPanel.Controls.Add(this.label5);
			this.CameraParametersExpandPanel.Controls.Add(this.Settings_CameraParameters_CameraCellWithSx);
			this.CameraParametersExpandPanel.Controls.Add(this.label6);
			this.CameraParametersExpandPanel.Controls.Add(this.Settings_CameraParameters_CameraModel);
			this.CameraParametersExpandPanel.Controls.Add(this.label3);
			this.CameraParametersExpandPanel.ExpandedHeight = 0;
			this.CameraParametersExpandPanel.IsExpanded = true;
			this.CameraParametersExpandPanel.Location = new System.Drawing.Point(3, 208);
			this.CameraParametersExpandPanel.Name = "CameraParametersExpandPanel";
			this.CameraParametersExpandPanel.Size = new System.Drawing.Size(987, 196);
			this.CameraParametersExpandPanel.TabIndex = 3;
			this.CameraParametersExpandPanel.Text = "Camera Parameters";
			this.CameraParametersExpandPanel.UseAnimation = false;
			// 
			// Settings_CameraParameters_Telecentric
			// 
			this.Settings_CameraParameters_Telecentric.AutoSize = true;
			this.Settings_CameraParameters_Telecentric.Location = new System.Drawing.Point(483, 148);
			this.Settings_CameraParameters_Telecentric.Name = "Settings_CameraParameters_Telecentric";
			this.Settings_CameraParameters_Telecentric.Size = new System.Drawing.Size(86, 19);
			this.Settings_CameraParameters_Telecentric.TabIndex = 55;
			this.Settings_CameraParameters_Telecentric.Text = "Telecentric";
			this.Settings_CameraParameters_Telecentric.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(24, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(973, 2);
			this.label11.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(433, 147);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 15);
			this.label9.TabIndex = 13;
			this.label9.Text = "mm";
			// 
			// Settings_CameraParameters_CameraForcal
			// 
			this.Settings_CameraParameters_CameraForcal.DecimalPlaces = 3;
			this.Settings_CameraParameters_CameraForcal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.Settings_CameraParameters_CameraForcal.Location = new System.Drawing.Point(196, 147);
			this.Settings_CameraParameters_CameraForcal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.Settings_CameraParameters_CameraForcal.Name = "Settings_CameraParameters_CameraForcal";
			this.Settings_CameraParameters_CameraForcal.Size = new System.Drawing.Size(231, 21);
			this.Settings_CameraParameters_CameraForcal.TabIndex = 12;
			this.Settings_CameraParameters_CameraForcal.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(35, 149);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 15);
			this.label10.TabIndex = 11;
			this.label10.Text = "Forcal Length";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(433, 119);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(25, 15);
			this.label7.TabIndex = 10;
			this.label7.Text = "μm";
			// 
			// Settings_CameraParameters_CameraCellHeightSy
			// 
			this.Settings_CameraParameters_CameraCellHeightSy.DecimalPlaces = 3;
			this.Settings_CameraParameters_CameraCellHeightSy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.Settings_CameraParameters_CameraCellHeightSy.Location = new System.Drawing.Point(196, 119);
			this.Settings_CameraParameters_CameraCellHeightSy.Name = "Settings_CameraParameters_CameraCellHeightSy";
			this.Settings_CameraParameters_CameraCellHeightSy.Size = new System.Drawing.Size(231, 21);
			this.Settings_CameraParameters_CameraCellHeightSy.TabIndex = 9;
			this.Settings_CameraParameters_CameraCellHeightSy.Value = new decimal(new int[] {
            83,
            0,
            0,
            65536});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(35, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 15);
			this.label8.TabIndex = 8;
			this.label8.Text = "Cell Height ( Sy )";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(433, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "μm";
			// 
			// Settings_CameraParameters_CameraCellWithSx
			// 
			this.Settings_CameraParameters_CameraCellWithSx.DecimalPlaces = 3;
			this.Settings_CameraParameters_CameraCellWithSx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.Settings_CameraParameters_CameraCellWithSx.Location = new System.Drawing.Point(196, 88);
			this.Settings_CameraParameters_CameraCellWithSx.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.Settings_CameraParameters_CameraCellWithSx.Name = "Settings_CameraParameters_CameraCellWithSx";
			this.Settings_CameraParameters_CameraCellWithSx.Size = new System.Drawing.Size(231, 21);
			this.Settings_CameraParameters_CameraCellWithSx.TabIndex = 6;
			this.Settings_CameraParameters_CameraCellWithSx.Value = new decimal(new int[] {
            83,
            0,
            0,
            65536});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(35, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Cell With ( Sx )";
			// 
			// Settings_CameraParameters_CameraModel
			// 
			this.Settings_CameraParameters_CameraModel.FormattingEnabled = true;
			this.Settings_CameraParameters_CameraModel.Items.AddRange(new object[] {
            "Area Scan ( Division )",
            "Area Scan ( Polynomial )",
            "Line Scan"});
			this.Settings_CameraParameters_CameraModel.Location = new System.Drawing.Point(196, 47);
			this.Settings_CameraParameters_CameraModel.Name = "Settings_CameraParameters_CameraModel";
			this.Settings_CameraParameters_CameraModel.Size = new System.Drawing.Size(231, 21);
			this.Settings_CameraParameters_CameraModel.TabIndex = 4;
			this.Settings_CameraParameters_CameraModel.Text = "Area Scan ( Division )";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Camera Model";
			// 
			// CalibrationTabPage
			// 
			this.CalibrationTabPage.Controls.Add(this.CalibrationFlowLayoutPanel);
			this.CalibrationTabPage.Location = new System.Drawing.Point(4, 22);
			this.CalibrationTabPage.Name = "CalibrationTabPage";
			this.CalibrationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.CalibrationTabPage.Size = new System.Drawing.Size(1009, 580);
			this.CalibrationTabPage.TabIndex = 1;
			this.CalibrationTabPage.Text = "校正";
			this.CalibrationTabPage.UseVisualStyleBackColor = true;
			// 
			// CalibrationFlowLayoutPanel
			// 
			this.CalibrationFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CalibrationFlowLayoutPanel.AutoScroll = true;
			this.CalibrationFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.CalibrationFlowLayoutPanel.Controls.Add(this.ImageSourceExpandCollapsePanel);
			this.CalibrationFlowLayoutPanel.Controls.Add(this.CalibrationExpandCollapsePanel);
			this.CalibrationFlowLayoutPanel.Controls.Add(this.QualityIssuesExpandCollapsePanel);
			this.CalibrationFlowLayoutPanel.Controls.Add(this.CalibrationPlateExtractionParametersExpandCollapsePanel);
			this.CalibrationFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.CalibrationFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.CalibrationFlowLayoutPanel.Name = "CalibrationFlowLayoutPanel";
			this.CalibrationFlowLayoutPanel.Size = new System.Drawing.Size(1003, 574);
			this.CalibrationFlowLayoutPanel.TabIndex = 5;
			this.CalibrationFlowLayoutPanel.WrapContents = false;
			this.CalibrationFlowLayoutPanel.Resize += new System.EventHandler(this.flowLayoutPanel_Resize);
			// 
			// ImageSourceExpandCollapsePanel
			// 
			this.ImageSourceExpandCollapsePanel.BackColor = System.Drawing.Color.Transparent;
			this.ImageSourceExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.ImageSourceExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.ImageSourceExpandCollapsePanel.Controls.Add(this.Calibration_ImageSource_ImageAcquisitionAssistantOpenButton);
			this.ImageSourceExpandCollapsePanel.Controls.Add(this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox);
			this.ImageSourceExpandCollapsePanel.Controls.Add(this.Calibration_ImageSource_ImageAcquisitionAssistantRadioButton);
			this.ImageSourceExpandCollapsePanel.Controls.Add(this.Calibration_ImageSource_ImageFiles);
			this.ImageSourceExpandCollapsePanel.ExpandedHeight = 0;
			this.ImageSourceExpandCollapsePanel.IsExpanded = true;
			this.ImageSourceExpandCollapsePanel.Location = new System.Drawing.Point(3, 3);
			this.ImageSourceExpandCollapsePanel.Name = "ImageSourceExpandCollapsePanel";
			this.ImageSourceExpandCollapsePanel.Size = new System.Drawing.Size(973, 94);
			this.ImageSourceExpandCollapsePanel.TabIndex = 0;
			this.ImageSourceExpandCollapsePanel.Text = "Image Source";
			this.ImageSourceExpandCollapsePanel.UseAnimation = false;
			// 
			// Calibration_ImageSource_ImageAcquisitionAssistantOpenButton
			// 
			this.Calibration_ImageSource_ImageAcquisitionAssistantOpenButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_ImageSource_ImageAcquisitionAssistantOpenButton.Location = new System.Drawing.Point(924, 65);
			this.Calibration_ImageSource_ImageAcquisitionAssistantOpenButton.Name = "Calibration_ImageSource_ImageAcquisitionAssistantOpenButton";
			this.Calibration_ImageSource_ImageAcquisitionAssistantOpenButton.Size = new System.Drawing.Size(45, 23);
			this.Calibration_ImageSource_ImageAcquisitionAssistantOpenButton.TabIndex = 5;
			this.Calibration_ImageSource_ImageAcquisitionAssistantOpenButton.Text = "Open";
			this.Calibration_ImageSource_ImageAcquisitionAssistantOpenButton.UseVisualStyleBackColor = true;
			// 
			// Calibration_ImageSource_ImageAcquisitionAssistantComboBox
			// 
			this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox.FormattingEnabled = true;
			this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox.Items.AddRange(new object[] {
            "Image Acquisition 01"});
			this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox.Location = new System.Drawing.Point(537, 66);
			this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox.Name = "Calibration_ImageSource_ImageAcquisitionAssistantComboBox";
			this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox.Size = new System.Drawing.Size(381, 21);
			this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox.TabIndex = 4;
			this.Calibration_ImageSource_ImageAcquisitionAssistantComboBox.Text = "Image Acquisition 01";
			// 
			// Calibration_ImageSource_ImageAcquisitionAssistantRadioButton
			// 
			this.Calibration_ImageSource_ImageAcquisitionAssistantRadioButton.AutoSize = true;
			this.Calibration_ImageSource_ImageAcquisitionAssistantRadioButton.Location = new System.Drawing.Point(35, 66);
			this.Calibration_ImageSource_ImageAcquisitionAssistantRadioButton.Name = "Calibration_ImageSource_ImageAcquisitionAssistantRadioButton";
			this.Calibration_ImageSource_ImageAcquisitionAssistantRadioButton.Size = new System.Drawing.Size(173, 19);
			this.Calibration_ImageSource_ImageAcquisitionAssistantRadioButton.TabIndex = 3;
			this.Calibration_ImageSource_ImageAcquisitionAssistantRadioButton.Text = "Image Acquisition Assistant";
			this.Calibration_ImageSource_ImageAcquisitionAssistantRadioButton.UseVisualStyleBackColor = true;
			// 
			// Calibration_ImageSource_ImageFiles
			// 
			this.Calibration_ImageSource_ImageFiles.AutoSize = true;
			this.Calibration_ImageSource_ImageFiles.Checked = true;
			this.Calibration_ImageSource_ImageFiles.Location = new System.Drawing.Point(35, 41);
			this.Calibration_ImageSource_ImageFiles.Name = "Calibration_ImageSource_ImageFiles";
			this.Calibration_ImageSource_ImageFiles.Size = new System.Drawing.Size(89, 19);
			this.Calibration_ImageSource_ImageFiles.TabIndex = 2;
			this.Calibration_ImageSource_ImageFiles.TabStop = true;
			this.Calibration_ImageSource_ImageFiles.Text = "Image Files";
			this.Calibration_ImageSource_ImageFiles.UseVisualStyleBackColor = true;
			// 
			// CalibrationExpandCollapsePanel
			// 
			this.CalibrationExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CalibrationExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.CalibrationExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_AutoUpdate);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_LiveTests);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_CalibrateButton);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_SetReferenceButton);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_UpdateButton);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_SaveAllButton);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_SaveButton);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_RemoveAllButton);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_RemoveButton);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_LoadButton);
			this.CalibrationExpandCollapsePanel.Controls.Add(this.Calibration_Calibration_GridView);
			this.CalibrationExpandCollapsePanel.ExpandedHeight = 0;
			this.CalibrationExpandCollapsePanel.IsExpanded = true;
			this.CalibrationExpandCollapsePanel.Location = new System.Drawing.Point(3, 103);
			this.CalibrationExpandCollapsePanel.Name = "CalibrationExpandCollapsePanel";
			this.CalibrationExpandCollapsePanel.Size = new System.Drawing.Size(973, 396);
			this.CalibrationExpandCollapsePanel.TabIndex = 2;
			this.CalibrationExpandCollapsePanel.Text = "Calibration";
			this.CalibrationExpandCollapsePanel.UseAnimation = false;
			// 
			// Calibration_Calibration_AutoUpdate
			// 
			this.Calibration_Calibration_AutoUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_AutoUpdate.AutoSize = true;
			this.Calibration_Calibration_AutoUpdate.Checked = true;
			this.Calibration_Calibration_AutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Calibration_Calibration_AutoUpdate.Location = new System.Drawing.Point(861, 279);
			this.Calibration_Calibration_AutoUpdate.Name = "Calibration_Calibration_AutoUpdate";
			this.Calibration_Calibration_AutoUpdate.Size = new System.Drawing.Size(93, 19);
			this.Calibration_Calibration_AutoUpdate.TabIndex = 12;
			this.Calibration_Calibration_AutoUpdate.Text = "Auto Update";
			this.Calibration_Calibration_AutoUpdate.UseVisualStyleBackColor = true;
			this.Calibration_Calibration_AutoUpdate.CheckedChanged += new System.EventHandler(this.Calibration_Calibration_AutoUpdate_CheckedChanged);
			// 
			// Calibration_Calibration_LiveTests
			// 
			this.Calibration_Calibration_LiveTests.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_LiveTests.AutoSize = true;
			this.Calibration_Calibration_LiveTests.Enabled = false;
			this.Calibration_Calibration_LiveTests.Location = new System.Drawing.Point(861, 88);
			this.Calibration_Calibration_LiveTests.Name = "Calibration_Calibration_LiveTests";
			this.Calibration_Calibration_LiveTests.Size = new System.Drawing.Size(80, 19);
			this.Calibration_Calibration_LiveTests.TabIndex = 11;
			this.Calibration_Calibration_LiveTests.Text = "Live Tests";
			this.Calibration_Calibration_LiveTests.UseVisualStyleBackColor = true;
			// 
			// Calibration_Calibration_CalibrateButton
			// 
			this.Calibration_Calibration_CalibrateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_CalibrateButton.Location = new System.Drawing.Point(859, 343);
			this.Calibration_Calibration_CalibrateButton.Name = "Calibration_Calibration_CalibrateButton";
			this.Calibration_Calibration_CalibrateButton.Size = new System.Drawing.Size(110, 23);
			this.Calibration_Calibration_CalibrateButton.TabIndex = 10;
			this.Calibration_Calibration_CalibrateButton.Text = "Calibrate";
			this.Calibration_Calibration_CalibrateButton.UseVisualStyleBackColor = true;
			this.Calibration_Calibration_CalibrateButton.Click += new System.EventHandler(this.Calibration_Calibration_CalibrateButton_Click);
			// 
			// Calibration_Calibration_SetReferenceButton
			// 
			this.Calibration_Calibration_SetReferenceButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_SetReferenceButton.Location = new System.Drawing.Point(859, 314);
			this.Calibration_Calibration_SetReferenceButton.Name = "Calibration_Calibration_SetReferenceButton";
			this.Calibration_Calibration_SetReferenceButton.Size = new System.Drawing.Size(110, 23);
			this.Calibration_Calibration_SetReferenceButton.TabIndex = 9;
			this.Calibration_Calibration_SetReferenceButton.Text = "Set Reference";
			this.Calibration_Calibration_SetReferenceButton.UseVisualStyleBackColor = true;
			// 
			// Calibration_Calibration_UpdateButton
			// 
			this.Calibration_Calibration_UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_UpdateButton.Enabled = false;
			this.Calibration_Calibration_UpdateButton.Location = new System.Drawing.Point(859, 250);
			this.Calibration_Calibration_UpdateButton.Name = "Calibration_Calibration_UpdateButton";
			this.Calibration_Calibration_UpdateButton.Size = new System.Drawing.Size(110, 23);
			this.Calibration_Calibration_UpdateButton.TabIndex = 8;
			this.Calibration_Calibration_UpdateButton.Text = "Update ...";
			this.Calibration_Calibration_UpdateButton.UseVisualStyleBackColor = true;
			// 
			// Calibration_Calibration_SaveAllButton
			// 
			this.Calibration_Calibration_SaveAllButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_SaveAllButton.Enabled = false;
			this.Calibration_Calibration_SaveAllButton.Location = new System.Drawing.Point(859, 206);
			this.Calibration_Calibration_SaveAllButton.Name = "Calibration_Calibration_SaveAllButton";
			this.Calibration_Calibration_SaveAllButton.Size = new System.Drawing.Size(110, 23);
			this.Calibration_Calibration_SaveAllButton.TabIndex = 7;
			this.Calibration_Calibration_SaveAllButton.Text = "Save All ...";
			this.Calibration_Calibration_SaveAllButton.UseVisualStyleBackColor = true;
			// 
			// Calibration_Calibration_SaveButton
			// 
			this.Calibration_Calibration_SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_SaveButton.Enabled = false;
			this.Calibration_Calibration_SaveButton.Location = new System.Drawing.Point(859, 177);
			this.Calibration_Calibration_SaveButton.Name = "Calibration_Calibration_SaveButton";
			this.Calibration_Calibration_SaveButton.Size = new System.Drawing.Size(110, 23);
			this.Calibration_Calibration_SaveButton.TabIndex = 6;
			this.Calibration_Calibration_SaveButton.Text = "Save ...";
			this.Calibration_Calibration_SaveButton.UseVisualStyleBackColor = true;
			// 
			// Calibration_Calibration_RemoveAllButton
			// 
			this.Calibration_Calibration_RemoveAllButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_RemoveAllButton.Location = new System.Drawing.Point(859, 148);
			this.Calibration_Calibration_RemoveAllButton.Name = "Calibration_Calibration_RemoveAllButton";
			this.Calibration_Calibration_RemoveAllButton.Size = new System.Drawing.Size(110, 23);
			this.Calibration_Calibration_RemoveAllButton.TabIndex = 5;
			this.Calibration_Calibration_RemoveAllButton.Text = "Remove All";
			this.Calibration_Calibration_RemoveAllButton.UseVisualStyleBackColor = true;
			this.Calibration_Calibration_RemoveAllButton.Click += new System.EventHandler(this.Calibration_Calibration_RemoveAllButton_Click);
			// 
			// Calibration_Calibration_RemoveButton
			// 
			this.Calibration_Calibration_RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_RemoveButton.Location = new System.Drawing.Point(859, 119);
			this.Calibration_Calibration_RemoveButton.Name = "Calibration_Calibration_RemoveButton";
			this.Calibration_Calibration_RemoveButton.Size = new System.Drawing.Size(110, 23);
			this.Calibration_Calibration_RemoveButton.TabIndex = 4;
			this.Calibration_Calibration_RemoveButton.Text = "Remove";
			this.Calibration_Calibration_RemoveButton.UseVisualStyleBackColor = true;
			this.Calibration_Calibration_RemoveButton.Click += new System.EventHandler(this.Calibration_Calibration_RemoveButton_Click);
			// 
			// Calibration_Calibration_LoadButton
			// 
			this.Calibration_Calibration_LoadButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_Calibration_LoadButton.Location = new System.Drawing.Point(859, 59);
			this.Calibration_Calibration_LoadButton.Name = "Calibration_Calibration_LoadButton";
			this.Calibration_Calibration_LoadButton.Size = new System.Drawing.Size(110, 23);
			this.Calibration_Calibration_LoadButton.TabIndex = 3;
			this.Calibration_Calibration_LoadButton.Text = "Load ...";
			this.Calibration_Calibration_LoadButton.UseVisualStyleBackColor = true;
			this.Calibration_Calibration_LoadButton.Click += new System.EventHandler(this.Calibration_Calibration_LoadButton_Click);
			// 
			// Calibration_Calibration_GridView
			// 
			this.Calibration_Calibration_GridView.AllowUserToAddRows = false;
			this.Calibration_Calibration_GridView.AllowUserToDeleteRows = false;
			this.Calibration_Calibration_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_Calibration_GridView.BackgroundColor = System.Drawing.Color.White;
			this.Calibration_Calibration_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Calibration_Calibration_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Status});
			this.Calibration_Calibration_GridView.Location = new System.Drawing.Point(21, 59);
			this.Calibration_Calibration_GridView.Name = "Calibration_Calibration_GridView";
			this.Calibration_Calibration_GridView.ReadOnly = true;
			this.Calibration_Calibration_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Calibration_Calibration_GridView.Size = new System.Drawing.Size(820, 323);
			this.Calibration_Calibration_GridView.TabIndex = 2;
			// 
			// Image
			// 
			this.Image.HeaderText = "Image";
			this.Image.Name = "Image";
			this.Image.ReadOnly = true;
			this.Image.Width = 150;
			// 
			// Status
			// 
			this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Status.HeaderText = "Status";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			// 
			// QualityIssuesExpandCollapsePanel
			// 
			this.QualityIssuesExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.QualityIssuesExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.QualityIssuesExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.QualityIssuesExpandCollapsePanel.Controls.Add(this.Calibration_QualityIssue_LiveTests);
			this.QualityIssuesExpandCollapsePanel.Controls.Add(this.Calibration_QualityIssue_WarningLevel);
			this.QualityIssuesExpandCollapsePanel.Controls.Add(this.label56);
			this.QualityIssuesExpandCollapsePanel.Controls.Add(this.Calibration_QualityIssue_SequenceTests);
			this.QualityIssuesExpandCollapsePanel.Controls.Add(this.label55);
			this.QualityIssuesExpandCollapsePanel.Controls.Add(this.Calibration_QualityIssue_ImageTests);
			this.QualityIssuesExpandCollapsePanel.Controls.Add(this.label28);
			this.QualityIssuesExpandCollapsePanel.Controls.Add(this.Calibration_QualityIssue_GridView);
			this.QualityIssuesExpandCollapsePanel.ExpandedHeight = 0;
			this.QualityIssuesExpandCollapsePanel.IsExpanded = true;
			this.QualityIssuesExpandCollapsePanel.Location = new System.Drawing.Point(3, 505);
			this.QualityIssuesExpandCollapsePanel.Name = "QualityIssuesExpandCollapsePanel";
			this.QualityIssuesExpandCollapsePanel.Size = new System.Drawing.Size(973, 248);
			this.QualityIssuesExpandCollapsePanel.TabIndex = 3;
			this.QualityIssuesExpandCollapsePanel.Text = "Quality Issues";
			this.QualityIssuesExpandCollapsePanel.UseAnimation = false;
			// 
			// Calibration_QualityIssue_LiveTests
			// 
			this.Calibration_QualityIssue_LiveTests.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_QualityIssue_LiveTests.AutoSize = true;
			this.Calibration_QualityIssue_LiveTests.Checked = true;
			this.Calibration_QualityIssue_LiveTests.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Calibration_QualityIssue_LiveTests.Location = new System.Drawing.Point(861, 219);
			this.Calibration_QualityIssue_LiveTests.Name = "Calibration_QualityIssue_LiveTests";
			this.Calibration_QualityIssue_LiveTests.Size = new System.Drawing.Size(80, 19);
			this.Calibration_QualityIssue_LiveTests.TabIndex = 8;
			this.Calibration_QualityIssue_LiveTests.Text = "Live Tests";
			this.Calibration_QualityIssue_LiveTests.UseVisualStyleBackColor = true;
			// 
			// Calibration_QualityIssue_WarningLevel
			// 
			this.Calibration_QualityIssue_WarningLevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_QualityIssue_WarningLevel.Location = new System.Drawing.Point(861, 180);
			this.Calibration_QualityIssue_WarningLevel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.Calibration_QualityIssue_WarningLevel.Name = "Calibration_QualityIssue_WarningLevel";
			this.Calibration_QualityIssue_WarningLevel.Size = new System.Drawing.Size(90, 21);
			this.Calibration_QualityIssue_WarningLevel.TabIndex = 7;
			this.Calibration_QualityIssue_WarningLevel.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
			// 
			// label56
			// 
			this.label56.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label56.AutoSize = true;
			this.label56.Location = new System.Drawing.Point(858, 159);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(113, 15);
			this.label56.TabIndex = 6;
			this.label56.Text = "Warning Level ( % )";
			// 
			// Calibration_QualityIssue_SequenceTests
			// 
			this.Calibration_QualityIssue_SequenceTests.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_QualityIssue_SequenceTests.FormattingEnabled = true;
			this.Calibration_QualityIssue_SequenceTests.Items.AddRange(new object[] {
            "All",
            "Quick",
            "None"});
			this.Calibration_QualityIssue_SequenceTests.Location = new System.Drawing.Point(861, 119);
			this.Calibration_QualityIssue_SequenceTests.Name = "Calibration_QualityIssue_SequenceTests";
			this.Calibration_QualityIssue_SequenceTests.Size = new System.Drawing.Size(90, 21);
			this.Calibration_QualityIssue_SequenceTests.TabIndex = 5;
			this.Calibration_QualityIssue_SequenceTests.Text = "All";
			// 
			// label55
			// 
			this.label55.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label55.AutoSize = true;
			this.label55.Location = new System.Drawing.Point(858, 99);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(95, 15);
			this.label55.TabIndex = 4;
			this.label55.Text = "Sequence Tests";
			// 
			// Calibration_QualityIssue_ImageTests
			// 
			this.Calibration_QualityIssue_ImageTests.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_QualityIssue_ImageTests.FormattingEnabled = true;
			this.Calibration_QualityIssue_ImageTests.Items.AddRange(new object[] {
            "All",
            "Quick",
            "None"});
			this.Calibration_QualityIssue_ImageTests.Location = new System.Drawing.Point(861, 65);
			this.Calibration_QualityIssue_ImageTests.Name = "Calibration_QualityIssue_ImageTests";
			this.Calibration_QualityIssue_ImageTests.Size = new System.Drawing.Size(90, 21);
			this.Calibration_QualityIssue_ImageTests.TabIndex = 3;
			this.Calibration_QualityIssue_ImageTests.Text = "All";
			// 
			// label28
			// 
			this.label28.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(858, 45);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(74, 15);
			this.label28.TabIndex = 2;
			this.label28.Text = "Image Tests";
			// 
			// Calibration_QualityIssue_GridView
			// 
			this.Calibration_QualityIssue_GridView.AllowUserToAddRows = false;
			this.Calibration_QualityIssue_GridView.AllowUserToDeleteRows = false;
			this.Calibration_QualityIssue_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_QualityIssue_GridView.BackgroundColor = System.Drawing.Color.White;
			this.Calibration_QualityIssue_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Calibration_QualityIssue_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Scope,
            this.Description,
            this.Quality,
            this.Details});
			this.Calibration_QualityIssue_GridView.Location = new System.Drawing.Point(21, 45);
			this.Calibration_QualityIssue_GridView.Name = "Calibration_QualityIssue_GridView";
			this.Calibration_QualityIssue_GridView.ReadOnly = true;
			this.Calibration_QualityIssue_GridView.Size = new System.Drawing.Size(820, 200);
			this.Calibration_QualityIssue_GridView.TabIndex = 1;
			// 
			// Scope
			// 
			this.Scope.HeaderText = "Scope";
			this.Scope.Name = "Scope";
			this.Scope.ReadOnly = true;
			this.Scope.Width = 150;
			// 
			// Description
			// 
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.ReadOnly = true;
			this.Description.Width = 150;
			// 
			// Quality
			// 
			this.Quality.HeaderText = "Quality";
			this.Quality.Name = "Quality";
			this.Quality.ReadOnly = true;
			this.Quality.Width = 80;
			// 
			// Details
			// 
			this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Details.HeaderText = "Details";
			this.Details.Name = "Details";
			this.Details.ReadOnly = true;
			// 
			// CalibrationPlateExtractionParametersExpandCollapsePanel
			// 
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label20);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label21);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label22);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label23);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_InitialThresholdResetButton);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label16);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label17);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label18);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label19);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MarkThreshodResetButton);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label15);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label14);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label13);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Controls.Add(this.label12);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.ExpandedHeight = 0;
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.IsExpanded = true;
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Location = new System.Drawing.Point(3, 759);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Name = "CalibrationPlateExtractionParametersExpandCollapsePanel";
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Size = new System.Drawing.Size(973, 490);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.TabIndex = 4;
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.Text = "Calibration Plate Extraction Parameters";
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.UseAnimation = false;
			// 
			// Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton
			// 
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton.Location = new System.Drawing.Point(925, 427);
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton.Name = "Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton";
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton.Size = new System.Drawing.Size(48, 23);
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton.TabIndex = 53;
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton.Text = "reset";
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton.UseVisualStyleBackColor = true;
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton.Click += new System.EventHandler(this.Calibration_PlateExtractionParameters_ResetButton_Click);
			// 
			// Calibration_PlateExtractionParameters_MinimumContourLengthResetButton
			// 
			this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton.Location = new System.Drawing.Point(925, 390);
			this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton.Name = "Calibration_PlateExtractionParameters_MinimumContourLengthResetButton";
			this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton.Size = new System.Drawing.Size(48, 23);
			this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton.TabIndex = 52;
			this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton.Text = "reset";
			this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton.UseVisualStyleBackColor = true;
			this.Calibration_PlateExtractionParameters_MinimumContourLengthResetButton.Click += new System.EventHandler(this.Calibration_PlateExtractionParameters_ResetButton_Click);
			// 
			// Calibration_PlateExtractionParameters_SmoothingAlphaResetButton
			// 
			this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton.Location = new System.Drawing.Point(925, 353);
			this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton.Name = "Calibration_PlateExtractionParameters_SmoothingAlphaResetButton";
			this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton.Size = new System.Drawing.Size(48, 23);
			this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton.TabIndex = 51;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton.Text = "reset";
			this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton.UseVisualStyleBackColor = true;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaResetButton.Click += new System.EventHandler(this.Calibration_PlateExtractionParameters_ResetButton_Click);
			// 
			// Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar
			// 
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar.BackColor = System.Drawing.Color.White;
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar.Location = new System.Drawing.Point(239, 428);
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar.Maximum = 500;
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar.Name = "Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar";
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar.Size = new System.Drawing.Size(674, 45);
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar.TabIndex = 50;
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_TrackBar_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar
			// 
			this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar.BackColor = System.Drawing.Color.White;
			this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar.Location = new System.Drawing.Point(239, 391);
			this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar.Maximum = 500;
			this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar.Name = "Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar";
			this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar.Size = new System.Drawing.Size(674, 45);
			this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar.TabIndex = 49;
			this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_TrackBar_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar
			// 
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.BackColor = System.Drawing.Color.White;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.Location = new System.Drawing.Point(239, 356);
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.Maximum = 20;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.Minimum = 1;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.Name = "Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar";
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.Size = new System.Drawing.Size(674, 45);
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.TabIndex = 48;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.Value = 9;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_TrackBar_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown
			// 
			this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown.DecimalPlaces = 2;
			this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown.Location = new System.Drawing.Point(176, 392);
			this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown.Name = "Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown";
			this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown.Size = new System.Drawing.Size(58, 21);
			this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown.TabIndex = 47;
			this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown.Value = new decimal(new int[] {
            1500,
            0,
            0,
            131072});
			this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown
			// 
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.DecimalPlaces = 2;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.Location = new System.Drawing.Point(176, 357);
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            131072});
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.Name = "Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown";
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.Size = new System.Drawing.Size(58, 21);
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.TabIndex = 46;
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.Value = new decimal(new int[] {
            90,
            0,
            0,
            131072});
			this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown
			// 
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown.DecimalPlaces = 2;
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown.Location = new System.Drawing.Point(176, 429);
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown.Name = "Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown";
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown.Size = new System.Drawing.Size(58, 21);
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown.TabIndex = 45;
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(18, 431);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(154, 15);
			this.label20.TabIndex = 44;
			this.label20.Text = "Maximum Mark Diameters";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(18, 394);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(147, 15);
			this.label21.TabIndex = 43;
			this.label21.Text = "Minimum Contour Length";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(18, 357);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(115, 15);
			this.label22.TabIndex = 42;
			this.label22.Text = "Smoothing ( Alpha )";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label23.Location = new System.Drawing.Point(15, 325);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(164, 15);
			this.label23.TabIndex = 41;
			this.label23.Text = "Extracting the Mark Contours";
			// 
			// Calibration_PlateExtractionParameters_MinimumThresholdResetButton
			// 
			this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton.Location = new System.Drawing.Point(925, 287);
			this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton.Name = "Calibration_PlateExtractionParameters_MinimumThresholdResetButton";
			this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton.Size = new System.Drawing.Size(48, 23);
			this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton.TabIndex = 40;
			this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton.Text = "reset";
			this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton.UseVisualStyleBackColor = true;
			this.Calibration_PlateExtractionParameters_MinimumThresholdResetButton.Click += new System.EventHandler(this.Calibration_PlateExtractionParameters_ResetButton_Click);
			// 
			// Calibration_PlateExtractionParameters_ThresholdDecremetResetButton
			// 
			this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton.Location = new System.Drawing.Point(925, 250);
			this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton.Name = "Calibration_PlateExtractionParameters_ThresholdDecremetResetButton";
			this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton.Size = new System.Drawing.Size(48, 23);
			this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton.TabIndex = 39;
			this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton.Text = "reset";
			this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton.UseVisualStyleBackColor = true;
			this.Calibration_PlateExtractionParameters_ThresholdDecremetResetButton.Click += new System.EventHandler(this.Calibration_PlateExtractionParameters_ResetButton_Click);
			// 
			// Calibration_PlateExtractionParameters_InitialThresholdResetButton
			// 
			this.Calibration_PlateExtractionParameters_InitialThresholdResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_PlateExtractionParameters_InitialThresholdResetButton.Location = new System.Drawing.Point(925, 213);
			this.Calibration_PlateExtractionParameters_InitialThresholdResetButton.Name = "Calibration_PlateExtractionParameters_InitialThresholdResetButton";
			this.Calibration_PlateExtractionParameters_InitialThresholdResetButton.Size = new System.Drawing.Size(48, 23);
			this.Calibration_PlateExtractionParameters_InitialThresholdResetButton.TabIndex = 38;
			this.Calibration_PlateExtractionParameters_InitialThresholdResetButton.Text = "reset";
			this.Calibration_PlateExtractionParameters_InitialThresholdResetButton.UseVisualStyleBackColor = true;
			this.Calibration_PlateExtractionParameters_InitialThresholdResetButton.Click += new System.EventHandler(this.Calibration_PlateExtractionParameters_ResetButton_Click);
			// 
			// Calibration_PlateExtractionParameters_MinimumThresholdTrackBar
			// 
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.BackColor = System.Drawing.Color.White;
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.Location = new System.Drawing.Point(239, 288);
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.Maximum = 100;
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.Minimum = 1;
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.Name = "Calibration_PlateExtractionParameters_MinimumThresholdTrackBar";
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.Size = new System.Drawing.Size(674, 45);
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.TabIndex = 37;
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.Value = 18;
			this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_TrackBar_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar
			// 
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.BackColor = System.Drawing.Color.White;
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.Location = new System.Drawing.Point(239, 251);
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.Maximum = 100;
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.Minimum = 1;
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.Name = "Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar";
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.Size = new System.Drawing.Size(674, 45);
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.TabIndex = 36;
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.Value = 10;
			this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_TrackBar_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_InitialThresholdTrackBar
			// 
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.BackColor = System.Drawing.Color.White;
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.Location = new System.Drawing.Point(239, 216);
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.Maximum = 255;
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.Minimum = 1;
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.Name = "Calibration_PlateExtractionParameters_InitialThresholdTrackBar";
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.Size = new System.Drawing.Size(674, 45);
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.TabIndex = 35;
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.Value = 128;
			this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_TrackBar_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown
			// 
			this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown.Location = new System.Drawing.Point(176, 252);
			this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown.Name = "Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown";
			this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown.Size = new System.Drawing.Size(58, 21);
			this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown.TabIndex = 34;
			this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown
			// 
			this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown.Location = new System.Drawing.Point(176, 217);
			this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown.Name = "Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown";
			this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown.Size = new System.Drawing.Size(58, 21);
			this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown.TabIndex = 33;
			this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown
			// 
			this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown.Location = new System.Drawing.Point(176, 289);
			this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown.Name = "Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown";
			this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown.Size = new System.Drawing.Size(58, 21);
			this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown.TabIndex = 32;
			this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(18, 291);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(118, 15);
			this.label16.TabIndex = 31;
			this.label16.Text = "Minimum Threshold";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(18, 254);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(119, 15);
			this.label17.TabIndex = 30;
			this.label17.Text = "Threshold Decremet";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(18, 217);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(94, 15);
			this.label18.TabIndex = 29;
			this.label18.Text = "Initial Threshold";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label19.Location = new System.Drawing.Point(15, 185);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(161, 15);
			this.label19.TabIndex = 28;
			this.label19.Text = "Extracting the Mark Regions";
			// 
			// Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton
			// 
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton.Location = new System.Drawing.Point(925, 146);
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton.Name = "Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton";
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton.Size = new System.Drawing.Size(48, 23);
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton.TabIndex = 27;
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton.Text = "reset";
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton.UseVisualStyleBackColor = true;
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton.Click += new System.EventHandler(this.Calibration_PlateExtractionParameters_ResetButton_Click);
			// 
			// Calibration_PlateExtractionParameters_MarkThreshodResetButton
			// 
			this.Calibration_PlateExtractionParameters_MarkThreshodResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_PlateExtractionParameters_MarkThreshodResetButton.Location = new System.Drawing.Point(925, 109);
			this.Calibration_PlateExtractionParameters_MarkThreshodResetButton.Name = "Calibration_PlateExtractionParameters_MarkThreshodResetButton";
			this.Calibration_PlateExtractionParameters_MarkThreshodResetButton.Size = new System.Drawing.Size(48, 23);
			this.Calibration_PlateExtractionParameters_MarkThreshodResetButton.TabIndex = 26;
			this.Calibration_PlateExtractionParameters_MarkThreshodResetButton.Text = "reset";
			this.Calibration_PlateExtractionParameters_MarkThreshodResetButton.UseVisualStyleBackColor = true;
			this.Calibration_PlateExtractionParameters_MarkThreshodResetButton.Click += new System.EventHandler(this.Calibration_PlateExtractionParameters_ResetButton_Click);
			// 
			// Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton
			// 
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton.Location = new System.Drawing.Point(925, 72);
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton.Name = "Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton";
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton.Size = new System.Drawing.Size(48, 23);
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton.TabIndex = 25;
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton.Text = "reset";
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton.UseVisualStyleBackColor = true;
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton.Click += new System.EventHandler(this.Calibration_PlateExtractionParameters_ResetButton_Click);
			// 
			// Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar
			// 
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar.BackColor = System.Drawing.Color.White;
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar.Location = new System.Drawing.Point(239, 147);
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar.Maximum = 100;
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar.Name = "Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar";
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar.Size = new System.Drawing.Size(674, 45);
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar.TabIndex = 24;
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar.Value = 5;
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_TrackBar_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_MarkThreshodTrackBar
			// 
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar.BackColor = System.Drawing.Color.White;
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar.Location = new System.Drawing.Point(239, 110);
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar.Maximum = 255;
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar.Name = "Calibration_PlateExtractionParameters_MarkThreshodTrackBar";
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar.Size = new System.Drawing.Size(674, 45);
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar.TabIndex = 23;
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar.Value = 112;
			this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_TrackBar_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar
			// 
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar.BackColor = System.Drawing.Color.White;
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar.Location = new System.Drawing.Point(239, 75);
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar.Maximum = 11;
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar.Name = "Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar";
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar.Size = new System.Drawing.Size(674, 45);
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar.TabIndex = 22;
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar.Value = 3;
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_TrackBar_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown
			// 
			this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown.Location = new System.Drawing.Point(176, 111);
			this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown.Name = "Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown";
			this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown.Size = new System.Drawing.Size(58, 21);
			this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown.TabIndex = 7;
			this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown.Value = new decimal(new int[] {
            112,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown
			// 
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown.Location = new System.Drawing.Point(176, 76);
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown.Name = "Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown";
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown.Size = new System.Drawing.Size(58, 21);
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown.TabIndex = 6;
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged);
			// 
			// Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown
			// 
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown.Location = new System.Drawing.Point(176, 148);
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown.Name = "Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown";
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown.Size = new System.Drawing.Size(58, 21);
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown.TabIndex = 5;
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown.ValueChanged += new System.EventHandler(this.Calibration_PlateExtractionParameters_NumericUpDown_ValueChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(18, 150);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(151, 15);
			this.label15.TabIndex = 4;
			this.label15.Text = "Minimum Mark Diameters";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(18, 113);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(90, 15);
			this.label14.TabIndex = 3;
			this.label14.Text = "Mark Threshod";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(18, 76);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(116, 15);
			this.label13.TabIndex = 2;
			this.label13.Text = "Gaussian Filter Size";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(15, 44);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(167, 15);
			this.label12.TabIndex = 1;
			this.label12.Text = "Locating the Calibration Plate";
			// 
			// ResultTabPage
			// 
			this.ResultTabPage.Controls.Add(this.ResultFlowLayoutPanel);
			this.ResultTabPage.Location = new System.Drawing.Point(4, 22);
			this.ResultTabPage.Name = "ResultTabPage";
			this.ResultTabPage.Size = new System.Drawing.Size(1009, 580);
			this.ResultTabPage.TabIndex = 2;
			this.ResultTabPage.Text = "結果";
			this.ResultTabPage.UseVisualStyleBackColor = true;
			// 
			// ResultFlowLayoutPanel
			// 
			this.ResultFlowLayoutPanel.AutoScroll = true;
			this.ResultFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.ResultFlowLayoutPanel.Controls.Add(this.expandCollapsePanel1);
			this.ResultFlowLayoutPanel.Controls.Add(this.CameraParameterExpandCollapsePanel);
			this.ResultFlowLayoutPanel.Controls.Add(this.CameraPoseExpandCollapsePanel);
			this.ResultFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResultFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.ResultFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.ResultFlowLayoutPanel.Name = "ResultFlowLayoutPanel";
			this.ResultFlowLayoutPanel.Size = new System.Drawing.Size(1009, 580);
			this.ResultFlowLayoutPanel.TabIndex = 6;
			this.ResultFlowLayoutPanel.WrapContents = false;
			this.ResultFlowLayoutPanel.Resize += new System.EventHandler(this.flowLayoutPanel_Resize);
			// 
			// expandCollapsePanel1
			// 
			this.expandCollapsePanel1.BackColor = System.Drawing.Color.Transparent;
			this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.expandCollapsePanel1.Controls.Add(this.label26);
			this.expandCollapsePanel1.Controls.Add(this.Result_CalibrationMeanError);
			this.expandCollapsePanel1.Controls.Add(this.Result_CalibrationStatus);
			this.expandCollapsePanel1.Controls.Add(this.label25);
			this.expandCollapsePanel1.Controls.Add(this.label24);
			this.expandCollapsePanel1.ExpandedHeight = 0;
			this.expandCollapsePanel1.IsExpanded = true;
			this.expandCollapsePanel1.Location = new System.Drawing.Point(3, 3);
			this.expandCollapsePanel1.Name = "expandCollapsePanel1";
			this.expandCollapsePanel1.Size = new System.Drawing.Size(985, 110);
			this.expandCollapsePanel1.TabIndex = 0;
			this.expandCollapsePanel1.Text = "Calibration Status";
			this.expandCollapsePanel1.UseAnimation = false;
			// 
			// label26
			// 
			this.label26.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(931, 77);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(39, 15);
			this.label26.TabIndex = 6;
			this.label26.Text = "pixels";
			// 
			// Result_CalibrationMeanError
			// 
			this.Result_CalibrationMeanError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CalibrationMeanError.Location = new System.Drawing.Point(107, 76);
			this.Result_CalibrationMeanError.Name = "Result_CalibrationMeanError";
			this.Result_CalibrationMeanError.Size = new System.Drawing.Size(818, 21);
			this.Result_CalibrationMeanError.TabIndex = 5;
			// 
			// Result_CalibrationStatus
			// 
			this.Result_CalibrationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CalibrationStatus.Location = new System.Drawing.Point(107, 46);
			this.Result_CalibrationStatus.Name = "Result_CalibrationStatus";
			this.Result_CalibrationStatus.Size = new System.Drawing.Size(864, 21);
			this.Result_CalibrationStatus.TabIndex = 4;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(27, 79);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(69, 15);
			this.label25.TabIndex = 3;
			this.label25.Text = "Mean Error";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(27, 49);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(41, 15);
			this.label24.TabIndex = 2;
			this.label24.Text = "Status";
			// 
			// CameraParameterExpandCollapsePanel
			// 
			this.CameraParameterExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CameraParameterExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.CameraParameterExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label57);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.Result_CameraParameter_ExportButton);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label35);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.Result_CameraParameter_ImageHeight);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label36);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label37);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.Result_CameraParameter_ImageWidth);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label38);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label39);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.Result_CameraParameter_CenterRowCy);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label40);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label41);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.Result_CameraParameter_CenterColumnCx);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label42);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label33);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.Result_CameraParameter_Kappa);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label34);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label31);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.Result_CameraParameter_FocalLength);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label32);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label29);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.Result_CameraParameter_CellHeightSy);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label30);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label27);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.Result_CameraParameter_CellWidthSx);
			this.CameraParameterExpandCollapsePanel.Controls.Add(this.label);
			this.CameraParameterExpandCollapsePanel.ExpandedHeight = 0;
			this.CameraParameterExpandCollapsePanel.IsExpanded = true;
			this.CameraParameterExpandCollapsePanel.Location = new System.Drawing.Point(3, 119);
			this.CameraParameterExpandCollapsePanel.Name = "CameraParameterExpandCollapsePanel";
			this.CameraParameterExpandCollapsePanel.Size = new System.Drawing.Size(985, 272);
			this.CameraParameterExpandCollapsePanel.TabIndex = 2;
			this.CameraParameterExpandCollapsePanel.Text = "Camera Parameters";
			this.CameraParameterExpandCollapsePanel.UseAnimation = false;
			// 
			// label57
			// 
			this.label57.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label57.AutoSize = true;
			this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label57.Location = new System.Drawing.Point(660, 127);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(9, 9);
			this.label57.TabIndex = 32;
			this.label57.Text = "2";
			// 
			// Result_CameraParameter_ExportButton
			// 
			this.Result_CameraParameter_ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Result_CameraParameter_ExportButton.Location = new System.Drawing.Point(901, 48);
			this.Result_CameraParameter_ExportButton.Name = "Result_CameraParameter_ExportButton";
			this.Result_CameraParameter_ExportButton.Size = new System.Drawing.Size(75, 23);
			this.Result_CameraParameter_ExportButton.TabIndex = 31;
			this.Result_CameraParameter_ExportButton.Text = "Save...";
			this.Result_CameraParameter_ExportButton.UseVisualStyleBackColor = true;
			// 
			// label35
			// 
			this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(638, 237);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(39, 15);
			this.label35.TabIndex = 30;
			this.label35.Text = "pixels";
			// 
			// Result_CameraParameter_ImageHeight
			// 
			this.Result_CameraParameter_ImageHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraParameter_ImageHeight.Location = new System.Drawing.Point(145, 235);
			this.Result_CameraParameter_ImageHeight.Name = "Result_CameraParameter_ImageHeight";
			this.Result_CameraParameter_ImageHeight.Size = new System.Drawing.Size(491, 21);
			this.Result_CameraParameter_ImageHeight.TabIndex = 29;
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(21, 238);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(81, 15);
			this.label36.TabIndex = 28;
			this.label36.Text = "Image Height";
			// 
			// label37
			// 
			this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(638, 210);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(39, 15);
			this.label37.TabIndex = 27;
			this.label37.Text = "pixels";
			// 
			// Result_CameraParameter_ImageWidth
			// 
			this.Result_CameraParameter_ImageWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraParameter_ImageWidth.Location = new System.Drawing.Point(145, 208);
			this.Result_CameraParameter_ImageWidth.Name = "Result_CameraParameter_ImageWidth";
			this.Result_CameraParameter_ImageWidth.Size = new System.Drawing.Size(491, 21);
			this.Result_CameraParameter_ImageWidth.TabIndex = 26;
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(21, 211);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(76, 15);
			this.label38.TabIndex = 25;
			this.label38.Text = "Image Width";
			// 
			// label39
			// 
			this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(638, 183);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(39, 15);
			this.label39.TabIndex = 24;
			this.label39.Text = "pixels";
			// 
			// Result_CameraParameter_CenterRowCy
			// 
			this.Result_CameraParameter_CenterRowCy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraParameter_CenterRowCy.Location = new System.Drawing.Point(145, 181);
			this.Result_CameraParameter_CenterRowCy.Name = "Result_CameraParameter_CenterRowCy";
			this.Result_CameraParameter_CenterRowCy.Size = new System.Drawing.Size(491, 21);
			this.Result_CameraParameter_CenterRowCy.TabIndex = 23;
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Location = new System.Drawing.Point(21, 184);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(101, 15);
			this.label40.TabIndex = 22;
			this.label40.Text = "Center Row ( Cy )";
			// 
			// label41
			// 
			this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label41.AutoSize = true;
			this.label41.Location = new System.Drawing.Point(638, 156);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(39, 15);
			this.label41.TabIndex = 21;
			this.label41.Text = "pixels";
			// 
			// Result_CameraParameter_CenterColumnCx
			// 
			this.Result_CameraParameter_CenterColumnCx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraParameter_CenterColumnCx.Location = new System.Drawing.Point(145, 154);
			this.Result_CameraParameter_CenterColumnCx.Name = "Result_CameraParameter_CenterColumnCx";
			this.Result_CameraParameter_CenterColumnCx.Size = new System.Drawing.Size(491, 21);
			this.Result_CameraParameter_CenterColumnCx.TabIndex = 20;
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Location = new System.Drawing.Point(21, 157);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(120, 15);
			this.label42.TabIndex = 19;
			this.label42.Text = "Center Column ( Cx )";
			// 
			// label33
			// 
			this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(638, 129);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(28, 15);
			this.label33.TabIndex = 18;
			this.label33.Text = "1/m";
			// 
			// Result_CameraParameter_Kappa
			// 
			this.Result_CameraParameter_Kappa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraParameter_Kappa.Location = new System.Drawing.Point(145, 127);
			this.Result_CameraParameter_Kappa.Name = "Result_CameraParameter_Kappa";
			this.Result_CameraParameter_Kappa.Size = new System.Drawing.Size(491, 21);
			this.Result_CameraParameter_Kappa.TabIndex = 17;
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(21, 130);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(43, 15);
			this.label34.TabIndex = 16;
			this.label34.Text = "Kappa";
			// 
			// label31
			// 
			this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(638, 102);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(29, 15);
			this.label31.TabIndex = 15;
			this.label31.Text = "mm";
			// 
			// Result_CameraParameter_FocalLength
			// 
			this.Result_CameraParameter_FocalLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraParameter_FocalLength.Location = new System.Drawing.Point(145, 100);
			this.Result_CameraParameter_FocalLength.Name = "Result_CameraParameter_FocalLength";
			this.Result_CameraParameter_FocalLength.Size = new System.Drawing.Size(491, 21);
			this.Result_CameraParameter_FocalLength.TabIndex = 14;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(21, 103);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(78, 15);
			this.label32.TabIndex = 13;
			this.label32.Text = "Focal Length";
			// 
			// label29
			// 
			this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(638, 75);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(25, 15);
			this.label29.TabIndex = 12;
			this.label29.Text = "μm";
			// 
			// Result_CameraParameter_CellHeightSy
			// 
			this.Result_CameraParameter_CellHeightSy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraParameter_CellHeightSy.Location = new System.Drawing.Point(145, 73);
			this.Result_CameraParameter_CellHeightSy.Name = "Result_CameraParameter_CellHeightSy";
			this.Result_CameraParameter_CellHeightSy.Size = new System.Drawing.Size(491, 21);
			this.Result_CameraParameter_CellHeightSy.TabIndex = 11;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(21, 76);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(97, 15);
			this.label30.TabIndex = 10;
			this.label30.Text = "Cell Height ( Sy )";
			// 
			// label27
			// 
			this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(638, 48);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(25, 15);
			this.label27.TabIndex = 9;
			this.label27.Text = "μm";
			// 
			// Result_CameraParameter_CellWidthSx
			// 
			this.Result_CameraParameter_CellWidthSx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraParameter_CellWidthSx.Location = new System.Drawing.Point(145, 46);
			this.Result_CameraParameter_CellWidthSx.Name = "Result_CameraParameter_CellWidthSx";
			this.Result_CameraParameter_CellWidthSx.Size = new System.Drawing.Size(491, 21);
			this.Result_CameraParameter_CellWidthSx.TabIndex = 8;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(21, 49);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(93, 15);
			this.label.TabIndex = 7;
			this.label.Text = "Cell Width ( Sx )";
			// 
			// CameraPoseExpandCollapsePanel
			// 
			this.CameraPoseExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CameraPoseExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
			this.CameraPoseExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
			this.CameraPoseExpandCollapsePanel.Controls.Add(this.Result_CameraPose_OriginalAtImageCorner);
			this.CameraPoseExpandCollapsePanel.Controls.Add(this.panel5);
			this.CameraPoseExpandCollapsePanel.Controls.Add(this.panel6);
			this.CameraPoseExpandCollapsePanel.Controls.Add(this.panel3);
			this.CameraPoseExpandCollapsePanel.Controls.Add(this.panel4);
			this.CameraPoseExpandCollapsePanel.Controls.Add(this.panel2);
			this.CameraPoseExpandCollapsePanel.Controls.Add(this.panel1);
			this.CameraPoseExpandCollapsePanel.Controls.Add(this.Reult_CameraPose_ExportBatton);
			this.CameraPoseExpandCollapsePanel.ExpandedHeight = 0;
			this.CameraPoseExpandCollapsePanel.IsExpanded = true;
			this.CameraPoseExpandCollapsePanel.Location = new System.Drawing.Point(3, 397);
			this.CameraPoseExpandCollapsePanel.Name = "CameraPoseExpandCollapsePanel";
			this.CameraPoseExpandCollapsePanel.Size = new System.Drawing.Size(985, 179);
			this.CameraPoseExpandCollapsePanel.TabIndex = 3;
			this.CameraPoseExpandCollapsePanel.Text = "Camera Pose";
			this.CameraPoseExpandCollapsePanel.UseAnimation = false;
			// 
			// Result_CameraPose_OriginalAtImageCorner
			// 
			this.Result_CameraPose_OriginalAtImageCorner.AutoSize = true;
			this.Result_CameraPose_OriginalAtImageCorner.Location = new System.Drawing.Point(22, 150);
			this.Result_CameraPose_OriginalAtImageCorner.Name = "Result_CameraPose_OriginalAtImageCorner";
			this.Result_CameraPose_OriginalAtImageCorner.Size = new System.Drawing.Size(150, 19);
			this.Result_CameraPose_OriginalAtImageCorner.TabIndex = 54;
			this.Result_CameraPose_OriginalAtImageCorner.Text = "Origin at Image Corner";
			this.Result_CameraPose_OriginalAtImageCorner.UseVisualStyleBackColor = true;
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.Controls.Add(this.Result_CameraPose_RotationZ);
			this.panel5.Controls.Add(this.label49);
			this.panel5.Controls.Add(this.label50);
			this.panel5.Location = new System.Drawing.Point(426, 114);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(460, 29);
			this.panel5.TabIndex = 53;
			// 
			// Result_CameraPose_RotationZ
			// 
			this.Result_CameraPose_RotationZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraPose_RotationZ.Location = new System.Drawing.Point(69, 4);
			this.Result_CameraPose_RotationZ.Name = "Result_CameraPose_RotationZ";
			this.Result_CameraPose_RotationZ.Size = new System.Drawing.Size(333, 21);
			this.Result_CameraPose_RotationZ.TabIndex = 41;
			// 
			// label49
			// 
			this.label49.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label49.AutoSize = true;
			this.label49.Location = new System.Drawing.Point(2, 8);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(63, 15);
			this.label49.TabIndex = 40;
			this.label49.Text = "Rotation Z";
			// 
			// label50
			// 
			this.label50.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label50.AutoSize = true;
			this.label50.Location = new System.Drawing.Point(405, 7);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(52, 15);
			this.label50.TabIndex = 42;
			this.label50.Text = "degrees";
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.Controls.Add(this.Result_CameraPose_Z);
			this.panel6.Controls.Add(this.label51);
			this.panel6.Controls.Add(this.label52);
			this.panel6.Location = new System.Drawing.Point(22, 114);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(405, 29);
			this.panel6.TabIndex = 52;
			// 
			// Result_CameraPose_Z
			// 
			this.Result_CameraPose_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraPose_Z.Location = new System.Drawing.Point(20, 4);
			this.Result_CameraPose_Z.Name = "Result_CameraPose_Z";
			this.Result_CameraPose_Z.Size = new System.Drawing.Size(338, 21);
			this.Result_CameraPose_Z.TabIndex = 32;
			// 
			// label51
			// 
			this.label51.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label51.AutoSize = true;
			this.label51.Location = new System.Drawing.Point(361, 6);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(29, 15);
			this.label51.TabIndex = 33;
			this.label51.Text = "mm";
			// 
			// label52
			// 
			this.label52.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label52.AutoSize = true;
			this.label52.Location = new System.Drawing.Point(3, 7);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(14, 15);
			this.label52.TabIndex = 31;
			this.label52.Text = "Z";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.Result_CameraPose_RotationY);
			this.panel3.Controls.Add(this.label43);
			this.panel3.Controls.Add(this.label44);
			this.panel3.Location = new System.Drawing.Point(426, 79);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(460, 29);
			this.panel3.TabIndex = 53;
			// 
			// Result_CameraPose_RotationY
			// 
			this.Result_CameraPose_RotationY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraPose_RotationY.Location = new System.Drawing.Point(69, 4);
			this.Result_CameraPose_RotationY.Name = "Result_CameraPose_RotationY";
			this.Result_CameraPose_RotationY.Size = new System.Drawing.Size(333, 21);
			this.Result_CameraPose_RotationY.TabIndex = 41;
			// 
			// label43
			// 
			this.label43.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label43.AutoSize = true;
			this.label43.Location = new System.Drawing.Point(2, 8);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(63, 15);
			this.label43.TabIndex = 40;
			this.label43.Text = "Rotation Y";
			// 
			// label44
			// 
			this.label44.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label44.AutoSize = true;
			this.label44.Location = new System.Drawing.Point(405, 7);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(52, 15);
			this.label44.TabIndex = 42;
			this.label44.Text = "degrees";
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.Result_CameraPose_Y);
			this.panel4.Controls.Add(this.label45);
			this.panel4.Controls.Add(this.label46);
			this.panel4.Location = new System.Drawing.Point(22, 79);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(405, 29);
			this.panel4.TabIndex = 52;
			// 
			// Result_CameraPose_Y
			// 
			this.Result_CameraPose_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraPose_Y.Location = new System.Drawing.Point(20, 4);
			this.Result_CameraPose_Y.Name = "Result_CameraPose_Y";
			this.Result_CameraPose_Y.Size = new System.Drawing.Size(338, 21);
			this.Result_CameraPose_Y.TabIndex = 32;
			// 
			// label45
			// 
			this.label45.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label45.AutoSize = true;
			this.label45.Location = new System.Drawing.Point(361, 6);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(29, 15);
			this.label45.TabIndex = 33;
			this.label45.Text = "mm";
			// 
			// label46
			// 
			this.label46.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label46.AutoSize = true;
			this.label46.Location = new System.Drawing.Point(3, 7);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(14, 15);
			this.label46.TabIndex = 31;
			this.label46.Text = "Y";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.Result_CameraPose_RotationX);
			this.panel2.Controls.Add(this.label54);
			this.panel2.Controls.Add(this.label53);
			this.panel2.Location = new System.Drawing.Point(426, 44);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(460, 29);
			this.panel2.TabIndex = 51;
			// 
			// Result_CameraPose_RotationX
			// 
			this.Result_CameraPose_RotationX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraPose_RotationX.Location = new System.Drawing.Point(69, 4);
			this.Result_CameraPose_RotationX.Name = "Result_CameraPose_RotationX";
			this.Result_CameraPose_RotationX.Size = new System.Drawing.Size(333, 21);
			this.Result_CameraPose_RotationX.TabIndex = 41;
			// 
			// label54
			// 
			this.label54.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label54.AutoSize = true;
			this.label54.Location = new System.Drawing.Point(2, 8);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(64, 15);
			this.label54.TabIndex = 40;
			this.label54.Text = "Rotation X";
			// 
			// label53
			// 
			this.label53.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label53.AutoSize = true;
			this.label53.Location = new System.Drawing.Point(405, 7);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(52, 15);
			this.label53.TabIndex = 42;
			this.label53.Text = "degrees";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.Result_CameraPose_X);
			this.panel1.Controls.Add(this.label47);
			this.panel1.Controls.Add(this.label48);
			this.panel1.Location = new System.Drawing.Point(22, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(405, 29);
			this.panel1.TabIndex = 50;
			// 
			// Result_CameraPose_X
			// 
			this.Result_CameraPose_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Result_CameraPose_X.Location = new System.Drawing.Point(20, 4);
			this.Result_CameraPose_X.Name = "Result_CameraPose_X";
			this.Result_CameraPose_X.Size = new System.Drawing.Size(338, 21);
			this.Result_CameraPose_X.TabIndex = 32;
			// 
			// label47
			// 
			this.label47.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label47.AutoSize = true;
			this.label47.Location = new System.Drawing.Point(361, 6);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(29, 15);
			this.label47.TabIndex = 33;
			this.label47.Text = "mm";
			// 
			// label48
			// 
			this.label48.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label48.AutoSize = true;
			this.label48.Location = new System.Drawing.Point(3, 7);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(15, 15);
			this.label48.TabIndex = 31;
			this.label48.Text = "X";
			// 
			// Reult_CameraPose_ExportBatton
			// 
			this.Reult_CameraPose_ExportBatton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Reult_CameraPose_ExportBatton.Location = new System.Drawing.Point(901, 44);
			this.Reult_CameraPose_ExportBatton.Name = "Reult_CameraPose_ExportBatton";
			this.Reult_CameraPose_ExportBatton.Size = new System.Drawing.Size(75, 23);
			this.Reult_CameraPose_ExportBatton.TabIndex = 49;
			this.Reult_CameraPose_ExportBatton.Text = "Save...";
			this.Reult_CameraPose_ExportBatton.UseVisualStyleBackColor = true;
			// 
			// CalibrateStatusStrip
			// 
			this.CalibrateStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalibrateStripStatusLabel});
			this.CalibrateStatusStrip.Location = new System.Drawing.Point(0, 584);
			this.CalibrateStatusStrip.Name = "CalibrateStatusStrip";
			this.CalibrateStatusStrip.Size = new System.Drawing.Size(1017, 22);
			this.CalibrateStatusStrip.TabIndex = 1;
			this.CalibrateStatusStrip.Text = "statusStrip";
			// 
			// CalibrateStripStatusLabel
			// 
			this.CalibrateStripStatusLabel.Name = "CalibrateStripStatusLabel";
			this.CalibrateStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// CalibrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1017, 606);
			this.Controls.Add(this.CalibrateStatusStrip);
			this.Controls.Add(this.CalibrationTab);
			this.MinimumSize = new System.Drawing.Size(700, 600);
			this.Name = "CalibrationForm";
			this.Text = "Camera Calibration";
			this.CalibrationTab.ResumeLayout(false);
			this.SettingsTabPage.ResumeLayout(false);
			this.SettingsFlowLayoutPanel.ResumeLayout(false);
			this.CalibrationTaskExpandPanel.ResumeLayout(false);
			this.CalibrationTaskExpandPanel.PerformLayout();
			this.CalibrationPlateExpandPanel.ResumeLayout(false);
			this.CalibrationPlateExpandPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Settings_CalibrationPlate_Thickness)).EndInit();
			this.CameraParametersExpandPanel.ResumeLayout(false);
			this.CameraParametersExpandPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Settings_CameraParameters_CameraForcal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Settings_CameraParameters_CameraCellHeightSy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Settings_CameraParameters_CameraCellWithSx)).EndInit();
			this.CalibrationTabPage.ResumeLayout(false);
			this.CalibrationFlowLayoutPanel.ResumeLayout(false);
			this.ImageSourceExpandCollapsePanel.ResumeLayout(false);
			this.ImageSourceExpandCollapsePanel.PerformLayout();
			this.CalibrationExpandCollapsePanel.ResumeLayout(false);
			this.CalibrationExpandCollapsePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_Calibration_GridView)).EndInit();
			this.QualityIssuesExpandCollapsePanel.ResumeLayout(false);
			this.QualityIssuesExpandCollapsePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_QualityIssue_WarningLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_QualityIssue_GridView)).EndInit();
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.ResumeLayout(false);
			this.CalibrationPlateExtractionParametersExpandCollapsePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumThresholdTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_InitialThresholdTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MarkThreshodTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown)).EndInit();
			this.ResultTabPage.ResumeLayout(false);
			this.ResultFlowLayoutPanel.ResumeLayout(false);
			this.expandCollapsePanel1.ResumeLayout(false);
			this.expandCollapsePanel1.PerformLayout();
			this.CameraParameterExpandCollapsePanel.ResumeLayout(false);
			this.CameraParameterExpandCollapsePanel.PerformLayout();
			this.CameraPoseExpandCollapsePanel.ResumeLayout(false);
			this.CameraPoseExpandCollapsePanel.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.CalibrateStatusStrip.ResumeLayout(false);
			this.CalibrateStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl CalibrationTab;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.TabPage CalibrationTabPage;
        private System.Windows.Forms.TabPage ResultTabPage;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CalibrationTaskExpandPanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CalibrationPlateExpandPanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CameraParametersExpandPanel;
        private System.Windows.Forms.FlowLayoutPanel SettingsFlowLayoutPanel;
        private System.Windows.Forms.RadioButton Settings_CalibrationTask_FullCalibration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Settings_CalibrationPlate_Thickness;
        private System.Windows.Forms.ComboBox Settings_CameraParameters_CameraModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Settings_CameraParameters_CameraCellHeightSy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Settings_CameraParameters_CameraCellWithSx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Settings_CameraParameters_CameraForcal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel CalibrationFlowLayoutPanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ImageSourceExpandCollapsePanel;
        private System.Windows.Forms.RadioButton Calibration_ImageSource_ImageFiles;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CalibrationExpandCollapsePanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel QualityIssuesExpandCollapsePanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CalibrationPlateExtractionParametersExpandCollapsePanel;
        private System.Windows.Forms.FlowLayoutPanel ResultFlowLayoutPanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CameraParameterExpandCollapsePanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CameraPoseExpandCollapsePanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Calibration_PlateExtractionParameters_MarkThreshodNumericUpDown;
        private System.Windows.Forms.NumericUpDown Calibration_PlateExtractionParameters_GaussianFilterSizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown Calibration_PlateExtractionParameters_MinimumMarkDiametersNumericUpDown;
        private System.Windows.Forms.TrackBar Calibration_PlateExtractionParameters_GaussianFilterSizeTrackBar;
        private System.Windows.Forms.TrackBar Calibration_PlateExtractionParameters_MinimumMarkDiametersTrackBar;
        private System.Windows.Forms.TrackBar Calibration_PlateExtractionParameters_MarkThreshodTrackBar;
        private System.Windows.Forms.Button Calibration_PlateExtractionParameters_MinimumMarkDiametersResetButton;
        private System.Windows.Forms.Button Calibration_PlateExtractionParameters_MarkThreshodResetButton;
        private System.Windows.Forms.Button Calibration_PlateExtractionParameters_GaussianFilterSizeResetButton;
        private System.Windows.Forms.Button Calibration_PlateExtractionParameters_MaximumMarkDiametersResetButton;
        private System.Windows.Forms.Button Calibration_PlateExtractionParameters_MinimumContourLengthResetButton;
        private System.Windows.Forms.Button Calibration_PlateExtractionParameters_SmoothingAlphaResetButton;
        private System.Windows.Forms.TrackBar Calibration_PlateExtractionParameters_MaximumMarkDiametersTrackBar;
        private System.Windows.Forms.TrackBar Calibration_PlateExtractionParameters_MinimumContourLengthTrackBar;
        private System.Windows.Forms.TrackBar Calibration_PlateExtractionParameters_SmoothingAlphaTrackBar;
        private System.Windows.Forms.NumericUpDown Calibration_PlateExtractionParameters_MinimumContourLengthNumericUpDown;
        private System.Windows.Forms.NumericUpDown Calibration_PlateExtractionParameters_SmoothingAlphaNumericUpDown;
        private System.Windows.Forms.NumericUpDown Calibration_PlateExtractionParameters_MaximumMarkDiametersNumericUpDown;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button Calibration_PlateExtractionParameters_MinimumThresholdResetButton;
        private System.Windows.Forms.Button Calibration_PlateExtractionParameters_ThresholdDecremetResetButton;
        private System.Windows.Forms.Button Calibration_PlateExtractionParameters_InitialThresholdResetButton;
        private System.Windows.Forms.TrackBar Calibration_PlateExtractionParameters_MinimumThresholdTrackBar;
        private System.Windows.Forms.TrackBar Calibration_PlateExtractionParameters_ThresholdDecremetTrackBar;
        private System.Windows.Forms.TrackBar Calibration_PlateExtractionParameters_InitialThresholdTrackBar;
        private System.Windows.Forms.NumericUpDown Calibration_PlateExtractionParameters_ThresholdDecremetNumericUpDown;
        private System.Windows.Forms.NumericUpDown Calibration_PlateExtractionParameters_InitialThresholdNumericUpDown;
        private System.Windows.Forms.NumericUpDown Calibration_PlateExtractionParameters_MinimumThresholdNumericUpDown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Result_CalibrationMeanError;
        private System.Windows.Forms.TextBox Result_CalibrationStatus;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox Result_CameraParameter_CellWidthSx;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox Result_CameraParameter_ImageHeight;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox Result_CameraParameter_ImageWidth;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox Result_CameraParameter_CenterRowCy;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox Result_CameraParameter_CenterColumnCx;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox Result_CameraParameter_Kappa;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox Result_CameraParameter_FocalLength;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox Result_CameraParameter_CellHeightSy;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button Result_CameraParameter_ExportButton;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox Result_CameraPose_X;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button Reult_CameraPose_ExportBatton;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox Result_CameraPose_RotationX;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Result_CameraPose_RotationZ;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Result_CameraPose_Z;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Result_CameraPose_RotationY;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Result_CameraPose_Y;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
		private System.Windows.Forms.DataGridView Calibration_QualityIssue_GridView;
        private System.Windows.Forms.ComboBox Calibration_QualityIssue_ImageTests;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox Calibration_QualityIssue_SequenceTests;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown Calibration_QualityIssue_WarningLevel;
        private System.Windows.Forms.CheckBox Calibration_QualityIssue_LiveTests;
        private System.Windows.Forms.DataGridView Calibration_Calibration_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button Calibration_Calibration_LoadButton;
        private System.Windows.Forms.Button Calibration_Calibration_CalibrateButton;
        private System.Windows.Forms.Button Calibration_Calibration_SetReferenceButton;
        private System.Windows.Forms.Button Calibration_Calibration_UpdateButton;
        private System.Windows.Forms.Button Calibration_Calibration_SaveAllButton;
        private System.Windows.Forms.Button Calibration_Calibration_SaveButton;
        private System.Windows.Forms.Button Calibration_Calibration_RemoveAllButton;
        private System.Windows.Forms.Button Calibration_Calibration_RemoveButton;
        private System.Windows.Forms.CheckBox Calibration_Calibration_LiveTests;
        private System.Windows.Forms.CheckBox Calibration_Calibration_AutoUpdate;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Button Settings_CalibrationPlate_DescriptionFileButton;
        private System.Windows.Forms.TextBox Settings_CalibrationPlate_DescriptionFile;
        private System.Windows.Forms.CheckBox Result_CameraPose_OriginalAtImageCorner;
        private System.Windows.Forms.CheckBox Settings_CameraParameters_Telecentric;
        private System.Windows.Forms.RadioButton Calibration_ImageSource_ImageAcquisitionAssistantRadioButton;
        private System.Windows.Forms.Button Calibration_ImageSource_ImageAcquisitionAssistantOpenButton;
        private System.Windows.Forms.ComboBox Calibration_ImageSource_ImageAcquisitionAssistantComboBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn Scope;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quality;
		private System.Windows.Forms.DataGridViewTextBoxColumn Details;
		private System.Windows.Forms.StatusStrip CalibrateStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel CalibrateStripStatusLabel;
    }
}

