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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.expandCollapsePanel1 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.expandCollapsePanel2 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expandCollapsePanel3 = new MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.CalibrationTabPage = new System.Windows.Forms.TabPage();
            this.ResultTabPage = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.CalibrationTab.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.expandCollapsePanel1.SuspendLayout();
            this.expandCollapsePanel2.SuspendLayout();
            this.expandCollapsePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // CalibrationTab
            // 
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
            this.SettingsTabPage.Controls.Add(this.flowLayoutPanel1);
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(1009, 580);
            this.SettingsTabPage.TabIndex = 0;
            this.SettingsTabPage.Text = "設定";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.expandCollapsePanel1);
            this.flowLayoutPanel1.Controls.Add(this.expandCollapsePanel2);
            this.flowLayoutPanel1.Controls.Add(this.expandCollapsePanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(990, 510);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // expandCollapsePanel1
            // 
            this.expandCollapsePanel1.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel1.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel1.Controls.Add(this.radioButton1);
            this.expandCollapsePanel1.ExpandedHeight = 0;
            this.expandCollapsePanel1.IsExpanded = true;
            this.expandCollapsePanel1.Location = new System.Drawing.Point(3, 3);
            this.expandCollapsePanel1.Name = "expandCollapsePanel1";
            this.expandCollapsePanel1.Size = new System.Drawing.Size(987, 84);
            this.expandCollapsePanel1.TabIndex = 0;
            this.expandCollapsePanel1.Text = "Calibration Task";
            this.expandCollapsePanel1.UseAnimation = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(292, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Full Calibration:Pose and all Camera Parameters";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // expandCollapsePanel2
            // 
            this.expandCollapsePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.expandCollapsePanel2.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel2.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel2.Controls.Add(this.label4);
            this.expandCollapsePanel2.Controls.Add(this.numericUpDown1);
            this.expandCollapsePanel2.Controls.Add(this.label2);
            this.expandCollapsePanel2.Controls.Add(this.label1);
            this.expandCollapsePanel2.ExpandedHeight = 0;
            this.expandCollapsePanel2.IsExpanded = true;
            this.expandCollapsePanel2.Location = new System.Drawing.Point(3, 93);
            this.expandCollapsePanel2.Name = "expandCollapsePanel2";
            this.expandCollapsePanel2.Size = new System.Drawing.Size(987, 119);
            this.expandCollapsePanel2.TabIndex = 2;
            this.expandCollapsePanel2.Text = "Calibration Plate";
            this.expandCollapsePanel2.UseAnimation = false;
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
            // expandCollapsePanel3
            // 
            this.expandCollapsePanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.expandCollapsePanel3.ButtonSize = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonSize.Normal;
            this.expandCollapsePanel3.ButtonStyle = MakarovDev.ExpandCollapsePanel.ExpandCollapseButton.ExpandButtonStyle.Circle;
            this.expandCollapsePanel3.Controls.Add(this.label9);
            this.expandCollapsePanel3.Controls.Add(this.numericUpDown4);
            this.expandCollapsePanel3.Controls.Add(this.label10);
            this.expandCollapsePanel3.Controls.Add(this.label7);
            this.expandCollapsePanel3.Controls.Add(this.numericUpDown3);
            this.expandCollapsePanel3.Controls.Add(this.label8);
            this.expandCollapsePanel3.Controls.Add(this.label5);
            this.expandCollapsePanel3.Controls.Add(this.numericUpDown2);
            this.expandCollapsePanel3.Controls.Add(this.label6);
            this.expandCollapsePanel3.Controls.Add(this.comboBox1);
            this.expandCollapsePanel3.Controls.Add(this.label3);
            this.expandCollapsePanel3.ExpandedHeight = 0;
            this.expandCollapsePanel3.IsExpanded = true;
            this.expandCollapsePanel3.Location = new System.Drawing.Point(3, 218);
            this.expandCollapsePanel3.Name = "expandCollapsePanel3";
            this.expandCollapsePanel3.Size = new System.Drawing.Size(987, 196);
            this.expandCollapsePanel3.TabIndex = 3;
            this.expandCollapsePanel3.Text = "Camera Parameters";
            this.expandCollapsePanel3.UseAnimation = false;
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
            this.CalibrationTabPage.Location = new System.Drawing.Point(4, 22);
            this.CalibrationTabPage.Name = "CalibrationTabPage";
            this.CalibrationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CalibrationTabPage.Size = new System.Drawing.Size(1009, 580);
            this.CalibrationTabPage.TabIndex = 1;
            this.CalibrationTabPage.Text = "校正";
            this.CalibrationTabPage.UseVisualStyleBackColor = true;
            // 
            // ResultTabPage
            // 
            this.ResultTabPage.Location = new System.Drawing.Point(4, 22);
            this.ResultTabPage.Name = "ResultTabPage";
            this.ResultTabPage.Size = new System.Drawing.Size(1009, 580);
            this.ResultTabPage.TabIndex = 2;
            this.ResultTabPage.Text = "結果";
            this.ResultTabPage.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(196, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(231, 20);
            this.numericUpDown1.TabIndex = 3;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Area Scan ( Division )",
            "Area Scan ( Polynomial )",
            "Line Scan"});
            this.comboBox1.Location = new System.Drawing.Point(196, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 4;
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
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(196, 88);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(231, 20);
            this.numericUpDown2.TabIndex = 6;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "mm";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(196, 119);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(231, 20);
            this.numericUpDown3.TabIndex = 9;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "mm";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(196, 147);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(231, 20);
            this.numericUpDown4.TabIndex = 12;
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.expandCollapsePanel1.ResumeLayout(false);
            this.expandCollapsePanel1.PerformLayout();
            this.expandCollapsePanel2.ResumeLayout(false);
            this.expandCollapsePanel2.PerformLayout();
            this.expandCollapsePanel3.ResumeLayout(false);
            this.expandCollapsePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CalibrationTab;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.TabPage CalibrationTabPage;
        private System.Windows.Forms.TabPage ResultTabPage;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel1;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel2;
        private MakarovDev.ExpandCollapsePanel.ExpandCollapsePanel expandCollapsePanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label10;
    }
}

