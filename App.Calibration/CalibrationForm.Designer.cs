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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CalibrationPlateExpandPanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.ThicknessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CameraParametersExpandPanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CameraForcalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CameraCellWithSyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CameraCellWithSxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CameraModelComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalibrationTabPage = new System.Windows.Forms.TabPage();
            this.CalibrationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ImageSourceExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.ImageSource_ImageAcquisitionAssistantRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageSource_ImageFileRadioButton = new System.Windows.Forms.RadioButton();
            this.CalibrationExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.QualityIssuesExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.CalibrationPlateExtractionParametersExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.ResultTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.CameraParameterExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.CameraPoseExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.DisplayResultsExpandCollapsePanel = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.CalibrationTab.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.SettingsFlowLayoutPanel.SuspendLayout();
            this.CalibrationTaskExpandPanel.SuspendLayout();
            this.CalibrationPlateExpandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessNumericUpDown)).BeginInit();
            this.CameraParametersExpandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraForcalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraCellWithSyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraCellWithSxNumericUpDown)).BeginInit();
            this.CalibrationTabPage.SuspendLayout();
            this.CalibrationFlowLayoutPanel.SuspendLayout();
            this.ImageSourceExpandCollapsePanel.SuspendLayout();
            this.ResultTabPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalibrationTab
            // 
            this.CalibrationTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.SettingsFlowLayoutPanel.Resize += new System.EventHandler(this.flowLayoutPanel_Resize);
            // 
            // CalibrationTaskExpandPanel
            // 
            this.CalibrationTaskExpandPanel.BackColor = System.Drawing.Color.Transparent;
            this.CalibrationTaskExpandPanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.CalibrationTaskExpandPanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.CalibrationTaskExpandPanel.Controls.Add(this.radioButton1);
            this.CalibrationTaskExpandPanel.ExpandedHeight = 0;
            this.CalibrationTaskExpandPanel.IsExpanded = true;
            this.CalibrationTaskExpandPanel.Location = new System.Drawing.Point(3, 3);
            this.CalibrationTaskExpandPanel.Name = "CalibrationTaskExpandPanel";
            this.CalibrationTaskExpandPanel.Size = new System.Drawing.Size(987, 74);
            this.CalibrationTaskExpandPanel.TabIndex = 0;
            this.CalibrationTaskExpandPanel.Text = "Calibration Task";
            this.CalibrationTaskExpandPanel.UseAnimation = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(292, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Full Calibration:Pose and all Camera Parameters";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CalibrationPlateExpandPanel
            // 
            this.CalibrationPlateExpandPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CalibrationPlateExpandPanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.CalibrationPlateExpandPanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.CalibrationPlateExpandPanel.Controls.Add(this.label4);
            this.CalibrationPlateExpandPanel.Controls.Add(this.ThicknessNumericUpDown);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "mm";
            // 
            // ThicknessNumericUpDown
            // 
            this.ThicknessNumericUpDown.DecimalPlaces = 3;
            this.ThicknessNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ThicknessNumericUpDown.Location = new System.Drawing.Point(196, 81);
            this.ThicknessNumericUpDown.Name = "ThicknessNumericUpDown";
            this.ThicknessNumericUpDown.Size = new System.Drawing.Size(231, 21);
            this.ThicknessNumericUpDown.TabIndex = 3;
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
            this.CameraParametersExpandPanel.Controls.Add(this.label11);
            this.CameraParametersExpandPanel.Controls.Add(this.label9);
            this.CameraParametersExpandPanel.Controls.Add(this.CameraForcalNumericUpDown);
            this.CameraParametersExpandPanel.Controls.Add(this.label10);
            this.CameraParametersExpandPanel.Controls.Add(this.label7);
            this.CameraParametersExpandPanel.Controls.Add(this.CameraCellWithSyNumericUpDown);
            this.CameraParametersExpandPanel.Controls.Add(this.label8);
            this.CameraParametersExpandPanel.Controls.Add(this.label5);
            this.CameraParametersExpandPanel.Controls.Add(this.CameraCellWithSxNumericUpDown);
            this.CameraParametersExpandPanel.Controls.Add(this.label6);
            this.CameraParametersExpandPanel.Controls.Add(this.CameraModelComboBox);
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
            // CameraForcalNumericUpDown
            // 
            this.CameraForcalNumericUpDown.DecimalPlaces = 3;
            this.CameraForcalNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CameraForcalNumericUpDown.Location = new System.Drawing.Point(196, 147);
            this.CameraForcalNumericUpDown.Name = "CameraForcalNumericUpDown";
            this.CameraForcalNumericUpDown.Size = new System.Drawing.Size(231, 21);
            this.CameraForcalNumericUpDown.TabIndex = 12;
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
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "mm";
            // 
            // CameraCellWithSyNumericUpDown
            // 
            this.CameraCellWithSyNumericUpDown.DecimalPlaces = 3;
            this.CameraCellWithSyNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CameraCellWithSyNumericUpDown.Location = new System.Drawing.Point(196, 119);
            this.CameraCellWithSyNumericUpDown.Name = "CameraCellWithSyNumericUpDown";
            this.CameraCellWithSyNumericUpDown.Size = new System.Drawing.Size(231, 21);
            this.CameraCellWithSyNumericUpDown.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cell With ( Sy )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "mm";
            // 
            // CameraCellWithSxNumericUpDown
            // 
            this.CameraCellWithSxNumericUpDown.DecimalPlaces = 3;
            this.CameraCellWithSxNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CameraCellWithSxNumericUpDown.Location = new System.Drawing.Point(196, 88);
            this.CameraCellWithSxNumericUpDown.Name = "CameraCellWithSxNumericUpDown";
            this.CameraCellWithSxNumericUpDown.Size = new System.Drawing.Size(231, 21);
            this.CameraCellWithSxNumericUpDown.TabIndex = 6;
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
            // CameraModelComboBox
            // 
            this.CameraModelComboBox.FormattingEnabled = true;
            this.CameraModelComboBox.Items.AddRange(new object[] {
            "Area Scan ( Division )",
            "Area Scan ( Polynomial )",
            "Line Scan"});
            this.CameraModelComboBox.Location = new System.Drawing.Point(196, 47);
            this.CameraModelComboBox.Name = "CameraModelComboBox";
            this.CameraModelComboBox.Size = new System.Drawing.Size(231, 21);
            this.CameraModelComboBox.TabIndex = 4;
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
            this.CalibrationFlowLayoutPanel.AutoScroll = true;
            this.CalibrationFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.CalibrationFlowLayoutPanel.Controls.Add(this.ImageSourceExpandCollapsePanel);
            this.CalibrationFlowLayoutPanel.Controls.Add(this.CalibrationExpandCollapsePanel);
            this.CalibrationFlowLayoutPanel.Controls.Add(this.QualityIssuesExpandCollapsePanel);
            this.CalibrationFlowLayoutPanel.Controls.Add(this.CalibrationPlateExtractionParametersExpandCollapsePanel);
            this.CalibrationFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalibrationFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CalibrationFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.CalibrationFlowLayoutPanel.Name = "CalibrationFlowLayoutPanel";
            this.CalibrationFlowLayoutPanel.Size = new System.Drawing.Size(1003, 574);
            this.CalibrationFlowLayoutPanel.TabIndex = 5;
            this.CalibrationFlowLayoutPanel.Resize += new System.EventHandler(this.flowLayoutPanel_Resize);
            // 
            // ImageSourceExpandCollapsePanel
            // 
            this.ImageSourceExpandCollapsePanel.BackColor = System.Drawing.Color.Transparent;
            this.ImageSourceExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.ImageSourceExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.ImageSourceExpandCollapsePanel.Controls.Add(this.ImageSource_ImageAcquisitionAssistantRadioButton);
            this.ImageSourceExpandCollapsePanel.Controls.Add(this.ImageSource_ImageFileRadioButton);
            this.ImageSourceExpandCollapsePanel.ExpandedHeight = 0;
            this.ImageSourceExpandCollapsePanel.IsExpanded = true;
            this.ImageSourceExpandCollapsePanel.Location = new System.Drawing.Point(3, 3);
            this.ImageSourceExpandCollapsePanel.Name = "ImageSourceExpandCollapsePanel";
            this.ImageSourceExpandCollapsePanel.Size = new System.Drawing.Size(987, 92);
            this.ImageSourceExpandCollapsePanel.TabIndex = 0;
            this.ImageSourceExpandCollapsePanel.Text = "Image Source";
            this.ImageSourceExpandCollapsePanel.UseAnimation = false;
            // 
            // ImageSource_ImageAcquisitionAssistantRadioButton
            // 
            this.ImageSource_ImageAcquisitionAssistantRadioButton.AutoSize = true;
            this.ImageSource_ImageAcquisitionAssistantRadioButton.Location = new System.Drawing.Point(35, 69);
            this.ImageSource_ImageAcquisitionAssistantRadioButton.Name = "ImageSource_ImageAcquisitionAssistantRadioButton";
            this.ImageSource_ImageAcquisitionAssistantRadioButton.Size = new System.Drawing.Size(173, 19);
            this.ImageSource_ImageAcquisitionAssistantRadioButton.TabIndex = 3;
            this.ImageSource_ImageAcquisitionAssistantRadioButton.TabStop = true;
            this.ImageSource_ImageAcquisitionAssistantRadioButton.Text = "Image Acquisition Assistant";
            this.ImageSource_ImageAcquisitionAssistantRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImageSource_ImageFileRadioButton
            // 
            this.ImageSource_ImageFileRadioButton.AutoSize = true;
            this.ImageSource_ImageFileRadioButton.Location = new System.Drawing.Point(35, 44);
            this.ImageSource_ImageFileRadioButton.Name = "ImageSource_ImageFileRadioButton";
            this.ImageSource_ImageFileRadioButton.Size = new System.Drawing.Size(89, 19);
            this.ImageSource_ImageFileRadioButton.TabIndex = 2;
            this.ImageSource_ImageFileRadioButton.TabStop = true;
            this.ImageSource_ImageFileRadioButton.Text = "Image Files";
            this.ImageSource_ImageFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // CalibrationExpandCollapsePanel
            // 
            this.CalibrationExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CalibrationExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.CalibrationExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.CalibrationExpandCollapsePanel.ExpandedHeight = 0;
            this.CalibrationExpandCollapsePanel.IsExpanded = true;
            this.CalibrationExpandCollapsePanel.Location = new System.Drawing.Point(3, 101);
            this.CalibrationExpandCollapsePanel.Name = "CalibrationExpandCollapsePanel";
            this.CalibrationExpandCollapsePanel.Size = new System.Drawing.Size(987, 98);
            this.CalibrationExpandCollapsePanel.TabIndex = 2;
            this.CalibrationExpandCollapsePanel.Text = "Calibration";
            this.CalibrationExpandCollapsePanel.UseAnimation = false;
            // 
            // QualityIssuesExpandCollapsePanel
            // 
            this.QualityIssuesExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QualityIssuesExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.QualityIssuesExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.QualityIssuesExpandCollapsePanel.ExpandedHeight = 0;
            this.QualityIssuesExpandCollapsePanel.IsExpanded = true;
            this.QualityIssuesExpandCollapsePanel.Location = new System.Drawing.Point(3, 205);
            this.QualityIssuesExpandCollapsePanel.Name = "QualityIssuesExpandCollapsePanel";
            this.QualityIssuesExpandCollapsePanel.Size = new System.Drawing.Size(987, 164);
            this.QualityIssuesExpandCollapsePanel.TabIndex = 3;
            this.QualityIssuesExpandCollapsePanel.Text = "Quality Issues";
            this.QualityIssuesExpandCollapsePanel.UseAnimation = false;
            // 
            // CalibrationPlateExtractionParametersExpandCollapsePanel
            // 
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.ExpandedHeight = 0;
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.IsExpanded = true;
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.Location = new System.Drawing.Point(3, 375);
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.Name = "CalibrationPlateExtractionParametersExpandCollapsePanel";
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.Size = new System.Drawing.Size(987, 196);
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.TabIndex = 4;
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.Text = "Calibration Plate Extraction Parameters";
            this.CalibrationPlateExtractionParametersExpandCollapsePanel.UseAnimation = false;
            // 
            // ResultTabPage
            // 
            this.ResultTabPage.Controls.Add(this.flowLayoutPanel1);
            this.ResultTabPage.Location = new System.Drawing.Point(4, 22);
            this.ResultTabPage.Name = "ResultTabPage";
            this.ResultTabPage.Size = new System.Drawing.Size(1009, 580);
            this.ResultTabPage.TabIndex = 2;
            this.ResultTabPage.Text = "結果";
            this.ResultTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.expandCollapsePanel1);
            this.flowLayoutPanel1.Controls.Add(this.CameraParameterExpandCollapsePanel);
            this.flowLayoutPanel1.Controls.Add(this.CameraPoseExpandCollapsePanel);
            this.flowLayoutPanel1.Controls.Add(this.DisplayResultsExpandCollapsePanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1009, 580);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel_Resize);
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.ExpandedHeight = 0;
            this.expandCollapsePanel1.IsExpanded = true;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(3, 3);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(987, 92);
            this.expandCollapsePanel1.TabIndex = 0;
            this.expandCollapsePanel1.Text = "Calibration Status";
            this.expandCollapsePanel1.UseAnimation = false;
            // 
            // CameraParameterExpandCollapsePanel
            // 
            this.CameraParameterExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraParameterExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.CameraParameterExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.CameraParameterExpandCollapsePanel.ExpandedHeight = 0;
            this.CameraParameterExpandCollapsePanel.IsExpanded = true;
            this.CameraParameterExpandCollapsePanel.Location = new System.Drawing.Point(3, 101);
            this.CameraParameterExpandCollapsePanel.Name = "CameraParameterExpandCollapsePanel";
            this.CameraParameterExpandCollapsePanel.Size = new System.Drawing.Size(987, 98);
            this.CameraParameterExpandCollapsePanel.TabIndex = 2;
            this.CameraParameterExpandCollapsePanel.Text = "Camera Parameters";
            this.CameraParameterExpandCollapsePanel.UseAnimation = false;
            // 
            // CameraPoseExpandCollapsePanel
            // 
            this.CameraPoseExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraPoseExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.CameraPoseExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.CameraPoseExpandCollapsePanel.ExpandedHeight = 0;
            this.CameraPoseExpandCollapsePanel.IsExpanded = true;
            this.CameraPoseExpandCollapsePanel.Location = new System.Drawing.Point(3, 205);
            this.CameraPoseExpandCollapsePanel.Name = "CameraPoseExpandCollapsePanel";
            this.CameraPoseExpandCollapsePanel.Size = new System.Drawing.Size(987, 164);
            this.CameraPoseExpandCollapsePanel.TabIndex = 3;
            this.CameraPoseExpandCollapsePanel.Text = "Camera Pose";
            this.CameraPoseExpandCollapsePanel.UseAnimation = false;
            // 
            // DisplayResultsExpandCollapsePanel
            // 
            this.DisplayResultsExpandCollapsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayResultsExpandCollapsePanel.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Small;
            this.DisplayResultsExpandCollapsePanel.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.DisplayResultsExpandCollapsePanel.ExpandedHeight = 0;
            this.DisplayResultsExpandCollapsePanel.IsExpanded = true;
            this.DisplayResultsExpandCollapsePanel.Location = new System.Drawing.Point(3, 375);
            this.DisplayResultsExpandCollapsePanel.Name = "DisplayResultsExpandCollapsePanel";
            this.DisplayResultsExpandCollapsePanel.Size = new System.Drawing.Size(987, 196);
            this.DisplayResultsExpandCollapsePanel.TabIndex = 4;
            this.DisplayResultsExpandCollapsePanel.Text = "Display Results";
            this.DisplayResultsExpandCollapsePanel.UseAnimation = false;
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 606);
            this.Controls.Add(this.CalibrationTab);
            this.Name = "CalibrationForm";
            this.Text = "Camera Calibration";
            this.CalibrationTab.ResumeLayout(false);
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsFlowLayoutPanel.ResumeLayout(false);
            this.CalibrationTaskExpandPanel.ResumeLayout(false);
            this.CalibrationTaskExpandPanel.PerformLayout();
            this.CalibrationPlateExpandPanel.ResumeLayout(false);
            this.CalibrationPlateExpandPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessNumericUpDown)).EndInit();
            this.CameraParametersExpandPanel.ResumeLayout(false);
            this.CameraParametersExpandPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraForcalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraCellWithSyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraCellWithSxNumericUpDown)).EndInit();
            this.CalibrationTabPage.ResumeLayout(false);
            this.CalibrationFlowLayoutPanel.ResumeLayout(false);
            this.ImageSourceExpandCollapsePanel.ResumeLayout(false);
            this.ImageSourceExpandCollapsePanel.PerformLayout();
            this.ResultTabPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ThicknessNumericUpDown;
        private System.Windows.Forms.ComboBox CameraModelComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown CameraCellWithSyNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CameraCellWithSxNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CameraForcalNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel CalibrationFlowLayoutPanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel ImageSourceExpandCollapsePanel;
        private System.Windows.Forms.RadioButton ImageSource_ImageFileRadioButton;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CalibrationExpandCollapsePanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel QualityIssuesExpandCollapsePanel;
        private System.Windows.Forms.RadioButton ImageSource_ImageAcquisitionAssistantRadioButton;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CalibrationPlateExtractionParametersExpandCollapsePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CameraParameterExpandCollapsePanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel CameraPoseExpandCollapsePanel;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel DisplayResultsExpandCollapsePanel;
    }
}

