#define _USE_MATH_DEFINES
#include <math.h>
#include <string.h>

#include "rotateimg.h"

DLLAPI void GetRotatedImageSize(Size2D* input, Size2D* output, double rotationDegree)
{
    double radian = rotationDegree * M_PI / 180.0;

    double sinVal = fabs(sin(radian));
    double cosVal = fabs(cos(radian));

    output->width = (int)(input->width * cosVal + input->height * sinVal);
    output->height = (int)(input->width * sinVal + input->height * cosVal);
}

void copyPixelBilinear(BitmapImageData& src, BitmapImageData& dst, double srcX, double srcY, int dstX, int dstY)
{
    int x1 = (int)floor(srcX);
    int y1 = (int)floor(srcY);
    int x2 = x1 + 1;
    int y2 = y1 + 1;

    double xWeight = x2 - srcX;
    double yWeight = y2 - srcY;

    size_t elemSize = sizeof(uint8_t) * src.channels;

    for (int i = 0; i < src.channels; ++i)
    {
        double value = 0;

        if (x1 >= 0 && y1 >= 0)
            value += src.data[y1 * src.step + x1 * elemSize + i] * xWeight * yWeight;
        if (x2 < src.cols && y1 >= 0)
            value += src.data[y1 * src.step + x2 * elemSize + i] * (1 - xWeight) * yWeight;
        if (x1 >= 0 && y2 < src.rows)
            value += src.data[y2 * src.step + x1 * elemSize + i] * xWeight * (1 - yWeight);
        if (x2 < src.cols && y2 < src.rows)
            value += src.data[y2 * src.step + x2 * elemSize + i] * (1 - xWeight) * (1 - yWeight);

        dst.data[dstY * dst.step + dstX * elemSize + i] = (uint8_t)value;
    }
}

DLLAPI void RotateImage(BitmapImageData src, BitmapImageData dst, double rotationDegree)
{
    double srcCenterX = (src.cols - 1) * 0.5;
    double srcCenterY = (src.rows - 1) * 0.5;

    double rad = -rotationDegree * M_PI / 180;
    double sinVal = sin(rad);
    double cosVal = cos(rad);

    double dstCenterX = (dst.cols - 1) * 0.5;
    double dstCenterY = (dst.rows - 1) * 0.5;

    for (int dstY = 0; dstY < dst.rows; ++dstY)
    {
        for (int dstX = 0; dstX < dst.cols; ++dstX)
        {
            double srcX = (dstX - dstCenterX) * cosVal - (dstY - dstCenterY) * sinVal + srcCenterX;
            double srcY = (dstX - dstCenterX) * sinVal + (dstY - dstCenterY) * cosVal + srcCenterY;

            if (srcX > -1 && srcX < src.cols && srcY > -1 && srcY < src.rows)
            {
                copyPixelBilinear(src, dst, srcX, srcY, dstX, dstY);
            }
        }
    }
}