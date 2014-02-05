using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CalibrationModels;
using HalconDotNet;

namespace CalibrationModule
{
	/// <summary>
	/// 校正計算
	/// </summary>
	public class CalibImageCalculator
	{
		/// <summary>
		/// 取得校正片校正資訊
		/// </summary>
		/// <param name="calibrationPlateDescriptionFile">校正片描述檔案</param>
		/// <param name="image">校正片影像</param>
		/// <param name="plateParam">校正片擷取參數</param>
		/// <param name="startCamerParam">鏡頭參數</param>
		/// <returns>校正片校正資訊模型</returns>
		public CalibrationPlateMarkViewModel GetCalibrationPlateMarkViewModel(string calibrationPlateDescriptionFile
										, HImage image
										, CalibrationPlateParam plateParam
										, HTuple startCamerParam)
		{
			var model = new CalibrationPlateMarkViewModel();
			try
			{
				//找到校正板的區域
				var calibRegion = image.FindCaltab(calibrationPlateDescriptionFile
								, plateParam.GaussianFilterSize
								, plateParam.MarkThreshold
								, plateParam.MinMarkDiam);

				//取得校正片 Mark 的位置和角度
				HTuple markCenterCols;
				HPose estimatedStartPose;
				HTuple markCenterRows = image.FindMarksAndPose(calibRegion
														, calibrationPlateDescriptionFile
														, startCamerParam
														, plateParam.StartThresh
														, plateParam.DeltaThresh
														, plateParam.MinThresh
														, plateParam.Alpha
														, plateParam.MinContourLength
														, plateParam.MaxDiameterMarks
														, out markCenterCols
														, out estimatedStartPose);

				model.MarkCenterRows = new HTuple(markCenterRows);
				model.MarkCenterCols = new HTuple(markCenterCols);
				model.EstimatedMarkPose = new HTuple(estimatedStartPose);
				model.Valid = true;
				model.ErrorMessage = String.Empty;
			}
			catch (HOperatorException ex)
			{
				model.ErrorMessage = ex.Message;
				model.Valid = false;
			}
			return model;
		}

		public List<QualityIssue> GetQualityIssues()
		{
			var qualityIssues = new List<QualityIssue>();
			return qualityIssues;
		}

		/// <summary>
		/// 取得校正影像品質報告
		/// </summary>
		/// <param name="descFile"></param>
		/// <param name="calibImage"></param>
		/// <param name="plateParam"></param>
		/// <param name="startCameraParam"></param>
		/// <returns></returns>
		public CalibImageViewModel GetCalibtionImageReport(string descFile, CalibImage calibImage, CalibrationPlateParam plateParam, HTuple startCameraParam)
		{
			//ToDo
			return new CalibImageViewModel();
		}
	}
}
