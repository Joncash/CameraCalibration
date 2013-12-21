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
            this.CalibrationTabPage = new System.Windows.Forms.TabPage();
            this.ResultTabPage = new System.Windows.Forms.TabPage();
            this.CalibrationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalibrationTab
            // 
            this.CalibrationTab.Controls.Add(this.SettingsTabPage);
            this.CalibrationTab.Controls.Add(this.CalibrationTabPage);
            this.CalibrationTab.Controls.Add(this.ResultTabPage);
            this.CalibrationTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalibrationTab.Location = new System.Drawing.Point(0, 0);
            this.CalibrationTab.Name = "CalibrationTab";
            this.CalibrationTab.SelectedIndex = 0;
            this.CalibrationTab.Size = new System.Drawing.Size(1017, 606);
            this.CalibrationTab.TabIndex = 0;
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(1009, 580);
            this.SettingsTabPage.TabIndex = 0;
            this.SettingsTabPage.Text = "設定";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
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
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 606);
            this.Controls.Add(this.CalibrationTab);
            this.Name = "CalibrationForm";
            this.Text = "Camera Calibration";
            this.CalibrationTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CalibrationTab;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.TabPage CalibrationTabPage;
        private System.Windows.Forms.TabPage ResultTabPage;
    }
}

