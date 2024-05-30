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
    }
}
