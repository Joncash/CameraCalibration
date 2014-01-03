namespace App.Calibration.Demo
{
	partial class CalibrationDemoFrom
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
			this.LoadImageButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LoadImageButton
			// 
			this.LoadImageButton.Location = new System.Drawing.Point(26, 21);
			this.LoadImageButton.Name = "LoadImageButton";
			this.LoadImageButton.Size = new System.Drawing.Size(132, 45);
			this.LoadImageButton.TabIndex = 0;
			this.LoadImageButton.Text = "LoadImage";
			this.LoadImageButton.UseVisualStyleBackColor = true;
			this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
			// 
			// CalibrationDemoFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 461);
			this.Controls.Add(this.LoadImageButton);
			this.Name = "CalibrationDemoFrom";
			this.Text = "DemoForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button LoadImageButton;
	}
}

