using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationModule
{
	/// <summary>
	/// Camera Calibration Image Object (校正影像)
	/// </summary>
	public class CalibImage
	{
		/// <summary>
		/// Calibration 影像ID
		/// </summary>
		public readonly string ID;

		private HImage _image;
		public CalibImage()
		{
			ID = Guid.NewGuid().ToString();
		}
		public CalibImage(string filename)
		{
			SetImage(filename);
		}

		#region public Method

		/// <summary>
		/// 設定校正影像
		/// </summary>
		/// <param name="filename">校正影像檔案位置</param>
		public void SetImage(string filename)
		{
			_image = new HImage(filename);
		}

		/// <summary>
		/// 設定校正影像
		/// </summary>
		/// <param name="image">校正影像</param>
		public void SetImage(HImage image)
		{
			_image = new HImage(image);
		}

		/// <summary>
		/// 取得影像
		/// </summary>
		/// <returns></returns>
		public HImage GetImage()
		{
			return _image;
		}
		#endregion

	}
}
