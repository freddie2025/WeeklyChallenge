using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace DesktopUI
{
	public partial class Dashboard : Form
	{
		List<string> imageTypes = new List<string>();
		List<ImageSizeModel> imagesSizes = new List<ImageSizeModel>();

		public Dashboard()
		{
			InitializeComponent();

			imageTypes.Add("JPG");
			imageTypes.Add("PNG");
			imageTypes.Add("BMP");

			newFileTypeDropDown.DataSource = imageTypes;

			imagesSizes.Add(new ImageSizeModel
			{ 
				ImageSizeText = "640 x 480",
				Width = 640,
				Height = 480
			});

			imagesSizes.Add(new ImageSizeModel
			{
				ImageSizeText = "800 x 600",
				Width = 800,
				Height = 600
			});

			newImageSizeDropDown.DataSource = imagesSizes;
			newImageSizeDropDown.DisplayMember = nameof(ImageSizeModel.ImageSizeText);
		}

		private void processChange_Click(object sender, EventArgs e)
		{
			string filePath = Path.GetDirectoryName(selectedFileName.Text);
			string newFile = $@"{ filePath }\{ newFileName.Text }";
			ImageFormat format = ImageFormat.Jpeg;

			switch (newFileTypeDropDown.SelectedItem)
			{
				case "JPG":
					newFile += ".jpg";
					format = ImageFormat.Jpeg;
					break;
				case "PNG":
					newFile += ".png";
					format = ImageFormat.Png;
					break;
				case "BMP":
					newFile += ".bmp";
					format = ImageFormat.Bmp;
					break;
				default:
					break;
			}

			using (Image img = Image.FromFile(selectedFileName.Text))
			{
				if (resizeImageCheckBox.Checked)
				{
					var resizedImage = ResizeImage(img, int.Parse(widthText.Text), int.Parse(heightText.Text));
					resizedImage.Save(newFile, format);
				}
				else
				{
					img.Save(newFile, format); ;
				}
			}
			
		}

		private void selectFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				selectedFileName.Text = dialog.FileName;
			}
		}

		// From: https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
		/// <summary>
		/// Resize the image to the specified width and height.
		/// </summary>
		/// <param name="image">The image to resize.</param>
		/// <param name="width">The width to resize to.</param>
		/// <param name="height">The height to resize to.</param>
		/// <returns>The resized image.</returns>
		public static Bitmap ResizeImage(Image image, int width, int height)
		{
			var destRect = new Rectangle(0, 0, width, height);
			var destImage = new Bitmap(width, height);

			destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

			using (var graphics = Graphics.FromImage(destImage))
			{
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

				using (var wrapMode = new ImageAttributes())
				{
					wrapMode.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
				}
			}

			return destImage;
		}

		private void newImageSizeDropDown_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (newImageSizeDropDown.SelectedItem == null)
			{
				return;
			}

			ImageSizeModel size = (ImageSizeModel)newImageSizeDropDown.SelectedItem;

			widthText.Text = size.Width.ToString();
			heightText.Text = size.Height.ToString();
		}
	}
}
