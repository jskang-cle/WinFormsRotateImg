using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotateImg
{
    public partial class ImgRotationForm : Form
    {
        private Bitmap _originalImage;
        private Bitmap _rotatedImage;

        public ImgRotationForm()
        {
            InitializeComponent();
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP, *.JPG, *.JPEG, *.GIF, *.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Bitmap newImage;
            try
            {
                newImage = new Bitmap(openFileDialog.FileName);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _originalImage?.Dispose();
            _originalImage = newImage;

            pictureBoxOriginal.Image = newImage;

            textBoxImagePath.Text = openFileDialog.FileName;
            buttonRotate.Enabled = true;

            toolStripStatusLabelImageInfo.Text = $"Image loaded: {newImage.Width}x{newImage.Height}, PixelFormat: {newImage.PixelFormat}";
        }

        private void RotateImage()
        {
            string rotationDegreeText = textBoxRotationDegree.Text;
            if (string.IsNullOrEmpty(rotationDegreeText))
            {
                MessageBox.Show("Please enter rotation degree.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!double.TryParse(rotationDegreeText, out double rotationDegree))
            {
                MessageBox.Show("Invalid rotation degree.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _rotatedImage?.Dispose();
            _rotatedImage = ImageRotator.RotateImage(_originalImage, rotationDegree);
            pictureBoxRotated.Image = _rotatedImage;
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            RotateImage();
        }

        private void textBoxRotationDegree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RotateImage();
            }
        }
    }
}
