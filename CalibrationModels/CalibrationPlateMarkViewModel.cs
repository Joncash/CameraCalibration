using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalibrationModels
{
	public class CalibrationPlateMarkViewModel
	{
		public string ErrorMessage { get; set; }

		public bool Valid { get; set; }

		public HalconDotNet.HTuple MarkCenterRows { get; set; }

		public HalconDotNet.HTuple MarkCenterCols { get; set; }

		public HalconDotNet.HTuple EstimatedMarkPose { get; set; }
	}
}
