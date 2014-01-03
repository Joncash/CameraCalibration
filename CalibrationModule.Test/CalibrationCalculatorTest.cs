using CalibrationModels;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Xunit;
using Xunit.Extensions;

namespace CalibrationModule.Test
{
	public class CalibrationCalculatorTest
	{
		[Theory]
		[InlineData(@"Data\pia2400-17gm")]
		public void GetCalibrationPlateMarkViewModelTest(string testCaseDir)
		{
			//assign
			var calc = new CalibImageCalculator();
			var caseDirInfo = new DirectoryInfo(testCaseDir);
			var descFile = caseDirInfo.GetFiles("caltab.descr").SingleOrDefault().FullName;

			var plateParamPath = caseDirInfo.GetFiles("calibParam.xml").SingleOrDefault().FullName;
			var startCamParamPath = caseDirInfo.GetFiles("startCamParam.dat").SingleOrDefault().FullName;
			CalibrationPlateParam plateParam;
			using (FileStream fs = new FileStream(plateParamPath, FileMode.Open))
			{
				XmlSerializer sr = new XmlSerializer(typeof(CalibrationPlateParam));
				plateParam = (CalibrationPlateParam)sr.Deserialize(fs);
			}

			HTuple startCamParam;
			HOperatorSet.ReadCamPar(startCamParamPath, out startCamParam);

			//act
			foreach (FileInfo imgInfo in caseDirInfo.EnumerateFiles(@"calibImages\*.tiff"))
			{
				var img = new HImage(imgInfo.FullName);
				var model = calc.GetCalibrationPlateMarkViewModel(descFile, img, plateParam, startCamParam);

				//assert
				Assert.True(model.Valid);
			}

		}
	}
}
