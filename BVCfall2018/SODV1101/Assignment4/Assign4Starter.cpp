#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <string>
#include <stdio.h>

using namespace std;

struct Color
{
	unsigned char r;
	unsigned char g;
	unsigned char b;
};

struct Image
{
	int width;
	int height;
	Color* pixels;
};

void CreateImage(Image& img, int width, int height)
{
	img.width = width;
	img.height = height;
	img.pixels = new Color[img.width * img.height];
}

void DeleteImage(Image& img)
{
	delete[] img.pixels;
}

bool LoadPPM6(FILE* file, Image& img)
{
	const int BUFFER_LENGTH = 256;
	char buffer[BUFFER_LENGTH];
	// Description
	fgets(buffer, BUFFER_LENGTH, file);
	// Dimensions
	fgets(buffer, BUFFER_LENGTH, file);
	sscanf(buffer, "%u %u", &img.width, &img.height);
	// Max Value
	int maxValue;
	fgets(buffer, BUFFER_LENGTH, file);
	sscanf(buffer, "%u", &maxValue);
	if (maxValue != 255)
		return false;
	// Image Data
	CreateImage(img, img.width, img.height);
	fread(img.pixels, sizeof(Color), img.width * img.height, file);
	return true;
}

bool LoadPPM(const string& filename, Image& img)
{
	FILE* file = fopen(filename.c_str(), "rb");
	const int BUFFER_LENGTH = 256;
	char buffer[BUFFER_LENGTH];
	fgets(buffer, BUFFER_LENGTH, file);
	if (strncmp(buffer, "P6\n", 3) == 0)
		return LoadPPM6(file, img);
	fclose(file);
	return false;
}

bool SavePPM6(const string& filename, const Image& img)
{
	FILE* file = fopen(filename.c_str(), "wb");
	fprintf(file, "P6\n# Assignment 4\n%d %d\n255\n", img.width, img.height);
	fwrite(img.pixels, sizeof(Color), img.width * img.height, file);
	fclose(file);
	return true;
}

int min(int arg1, int arg2)
{
	return arg1 < arg2 ? arg1 : arg2;
}

int max(int arg1, int arg2)
{
	return arg1 > arg2 ? arg1 : arg2;
}

void FlipHorizontal(const Image& input, Image& output)
{
	// TODO
}

void Shrink(const Image& input, Image& output)
{
	// TODO
}

void Greyscale(const Image& input, Image& output)
{
	// TODO
}

void RotateClockwise(const Image& input, Image& output)
{
	// TODO
}

void Watermark(const Image& input, const Image& watermark, Image& output)
{
	// TODO
}

int main()
{
	string filename = "test2.ppm";
	Image img;
	LoadPPM(filename, img);
	Image watermark;
	LoadPPM("watermark.ppm", watermark);

	// TODO FlipHorizontal(img, flip);
	// TODO Shrink(img, shrink);
	// TODO Greyscale(img, greyscale);
	// TODO RotateClockwise(img, rotate);
	// TODO Watermark(img, watermark, water);
	// TODO SavePPM6("outFlip.ppm", flip);
	// TODO SavePPM6("outShrink.ppm", shrink);
	// TODO SavePPM6("outGreyscale.ppm", greyscale);
	// TODO SavePPM6("outRotate.ppm", rotate);
	// TODO SavePPM6("outWatermark.ppm", water);

	DeleteImage(img);
	return 0;
}
