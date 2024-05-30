using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RotateImg
{
    internal static class ImageRotator
    {
        public static Bitmap RotateImage(Bitmap src, double rotationDegree)
        {
            Size2D inputSize = new Size2D();
            inputSize.width = src.Width;
            inputSize.height = src.Height;

            Size2D outputSize = new Size2D();
            GetRotatedImageSize(ref inputSize, ref outputSize, rotationDegree);

            Bitmap dst = new Bitmap(outputSize.width, outputSize.height, PixelFormat.Format24bppRgb);

            BitmapData srcData = src.LockBits(
                new Rectangle(0, 0, src.Width, src.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            BitmapData dstData = dst.LockBits(
                new Rectangle(0, 0, dst.Width, dst.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            RotateImage(new BitmapImageData(srcData, 3), new BitmapImageData(dstData, 3), rotationDegree);

            src.UnlockBits(srcData);
            dst.UnlockBits(dstData);

            return dst;
        }

        [DllImport("RotateImgCore.dll")]
        public static extern void GetRotatedImageSize(ref Size2D input, ref Size2D output, double rotationDegree);

        [DllImport("RotateImgCore.dll")]
        public static extern void RotateImage(BitmapImageData src, BitmapImageData dst, double rotationDegree);

        [StructLayout(LayoutKind.Sequential)]
        public struct Size2D
        {
            public int width;
            public int height;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BitmapImageData
        {
            public IntPtr data;
            public int cols;
            public int rows;
            public int channels;

            public BitmapImageData(BitmapData bmpData, int channels)
            {
                data = bmpData.Scan0;
                cols = bmpData.Width;
                rows = bmpData.Height;
                this.channels = channels;
            }
        }
    }
}
