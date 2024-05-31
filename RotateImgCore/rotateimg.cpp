#define _USE_MATH_DEFINES
#include <math.h>
#include <string.h>

#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>

#include "rotateimg.h"

DLLAPI void GetRotatedImageSize(Size2D* input, Size2D* output, double rotationDegree)
{
    double radian = rotationDegree * M_PI / 180.0;

    double sinVal = fabs(sin(radian));
    double cosVal = fabs(cos(radian));

    output->width = (int)(input->width * cosVal + input->height * sinVal);
    output->height = (int)(input->width * sinVal + input->height * cosVal);
}

DLLAPI void RotateImage(BitmapImageData src, BitmapImageData dst, double rotationDegree)
{
    int matType = CV_MAKETYPE(cv::DataType<uint8_t>::type, src.channels);

    cv::Mat srcMat(src.rows, src.cols, matType, src.data);
    srcMat.step = src.step;

    cv::Mat dstMat(dst.rows, dst.cols, matType, dst.data);
    dstMat.step = dst.step;

    cv::Point2f center(src.cols * 0.5, src.rows * 0.5);
    cv::Mat rotMat = cv::getRotationMatrix2D(center, rotationDegree, 1.0);

    rotMat.at<double>(0, 2) += (dst.cols - src.cols) * 0.5;
    rotMat.at<double>(1, 2) += (dst.rows - src.rows) * 0.5;

    cv::warpAffine(
        srcMat, dstMat, rotMat, 
        cv::Size(dst.cols, dst.rows),
        cv::INTER_LINEAR,
        cv::BORDER_TRANSPARENT,
        cv::Scalar(0, 0, 0));

    return;
}