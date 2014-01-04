namespace App.Calibration
{
	partial class StatusForm
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
			this.StatusRichTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// StatusRichTextBox
			// 
			this.StatusRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StatusRichTextBox.Location = new System.Drawing.Point(-1, -2);
			this.StatusRichTextBox.Name = "StatusRichTextBox";
			this.StatusRichTextBox.Size = new System.Drawing.Size(558, 446);
			this.StatusRichTextBox.TabIndex = 0;
			this.StatusRichTextBox.Text = "";
			// 
			// StatusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 445);
			this.Controls.Add(this.StatusRichTextBox);
			this.Name = "StatusForm";
			this.Text = "StatusForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox StatusRichTextBox;
	}
}