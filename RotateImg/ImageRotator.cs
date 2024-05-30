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
        public static bool IsIndexedPixelFormat(this PixelFormat pixelFormat)
            => (pixelFormat & PixelFormat.Indexed) == PixelFormat.Indexed;

        public static int GetChannels(this PixelFormat pixelFormat)
        {
            switch (pixelFormat)
            {
                case PixelFormat.Format8bppIndexed:
                    return 1;
                case PixelFormat.Format24bppRgb:
                    return 3;
                case PixelFormat.Format32bppArgb:
                    return 4;
                default:
                    throw new ArgumentException("Unsupported pixel format.");
            }
        }

        public static Bitmap RotateImage(Bitmap src, double rotationDegree)
        {
            int channels = src.PixelFormat.GetChannels();

            Size2D inputSize = new Size2D(src.Width, src.Height);

            Size2D outputSize = new Size2D();
            GetRotatedImageSize(ref inputSize, ref outputSize, rotationDegree);

            Bitmap dst = new Bitmap(outputSize.width, outputSize.height, src.PixelFormat);

            if (src.PixelFormat.IsIndexedPixelFormat())
            {
                dst.Palette = src.Palette;
            }

            BitmapData srcData = src.LockBits(
                new Rectangle(0, 0, src.Width, src.Height),
                ImageLockMode.ReadOnly,
                src.PixelFormat);

            BitmapData dstData = dst.LockBits(
                new Rectangle(0, 0, dst.Width, dst.Height),
                ImageLockMode.ReadWrite,
                src.PixelFormat);

            RotateImage(new BitmapImageData(srcData, channels), new BitmapImageData(dstData, channels), rotationDegree);

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

            public Size2D(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BitmapImageData
        {
            public IntPtr data;
            public int cols;
            public int rows;
            public int channels;
            public int step;

            public BitmapImageData(BitmapData bmpData, int channels)
            {
                data = bmpData.Scan0;
                cols = bmpData.Width;
                rows = bmpData.Height;
                this.channels = channels;
                step = bmpData.Stride;
            }
        }
    }
}
