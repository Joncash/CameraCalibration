using CalibrationModels;
using CalibrationModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Calibration.Demo
{
	public partial class CalibrationDemoFrom : Form
	{
		private CalibrationAssistant _calibAssistant;
		public CalibrationDemoFrom()
		{
			InitializeComponent();

			//init
			initCalibAssistant();
		}

		private void initCalibAssistant()
		{
			//ToDo
			var cameraParam = new CameraParam();
			var plateDescFile = @"";
			_calibAssistant = new CalibrationAssistant(cameraParam, plateDescFile);
		}

		private void LoadImageButton_Click(object sender, EventArgs e)
		{

		}


	}
}
