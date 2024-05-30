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
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBoxImagePath.Text = openFileDialog.FileName;

            _originalImage = new Bitmap(openFileDialog.FileName);
            pictureBoxOriginal.Image = _originalImage;

            buttonRotate.Enabled = true;
        }

        private void RotateImage()
        {
            string rotationDegreeText = textBoxRotationDegree.Text;
            if (string.IsNullOrEmpty(rotationDegreeText))
            {
                MessageBox.Show("Please enter rotation degree.");
                return;
            }

            if (!double.TryParse(rotationDegreeText, out double rotationDegree))
            {
                MessageBox.Show("Invalid rotation degree.");
                return;
            }

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
