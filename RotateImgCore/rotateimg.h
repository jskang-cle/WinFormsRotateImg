#pragma once

#ifdef _WINDLL
#define DLLAPI extern "C" __declspec(dllexport)
#else
#define DLLAPI	
#endif

#include "stdint.h"

typedef struct Size2D
{
    int width;
    int height;
} Size2D;

typedef struct BitmapImageData
{
    uint8_t* data;
    int cols;
    int rows;
    int channels;
    int step;
} BitmapImageData;

DLLAPI void GetRotatedImageSize(Size2D* input, Size2D* output, double rotationDegree);

DLLAPI void RotateImage(BitmapImageData src, BitmapImageData dst, double rotationDegree);
