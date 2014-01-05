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
		#region private variables
		private int _imageWidth;
		private int _imageHeight;
		private HImage _image;
		#endregion

		#region pulic variables
		/// <summary>
		/// Calibration 影像ID
		/// </summary>
		public readonly string ID;

		/// <summary>
		/// ImageWidth
		/// </summary>
		public int ImageWidth { get { return _imageWidth; } }

		/// <summary>
		/// ImageHeight
		/// </summary>
		public int ImageHeight { get { return _imageHeight; } }
		#endregion

		#region 建構子
		public CalibImage()
		{
			ID = Guid.NewGuid().ToString();
		}
		public CalibImage(string filename)
		{
			SetImage(filename);
			ID = Guid.NewGuid().ToString();
		}
		#endregion

		#region public Method

		/// <summary>
		/// 設定校正影像
		/// </summary>
		/// <param name="filename">校正影像檔案位置</param>
		public void SetImage(string filename)
		{
			_image = new HImage(filename);
			setImageInfo();
		}

		/// <summary>
		/// 設定校正影像
		/// </summary>
		/// <param name="image">校正影像</param>
		public void SetImage(HImage image)
		{
			_image = new HImage(image);
			setImageInfo();
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

		#region private Methods
		/// <summary>
		/// 設定影像 Width, Height
		/// </summary>
		private void setImageInfo()
		{
			string typeOfImage;
			_image.GetImagePointer1(out typeOfImage, out _imageWidth, out _imageHeight);
		}
		#endregion

	}
}
