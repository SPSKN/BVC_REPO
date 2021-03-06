#include <iostream>
#include <cmath>
#include <pch.h>
using namespace std;

const float PI = 3.14159f;

float DegreesToRadians(float degrees){

	return degrees * PI / 180.0f;
}

float CalcTriangleEdge(float a, float b, float gamma){
		return sqrt((a * a) + (b * b) - (2 * a * b * gamma));
}

int main(float a, float b, float gamma){
	cout << "Enter the length side a: ";
	cin >> a;
	cout << "Enter the length of side b:";
	cin >> b;
	cout << "Enter the angle gamma: ";
	cin >> gamma;
	cout << "The length of side c is " << CalcTriangleEdge(a, b, RadiansToDegrees(gamma)) <<;
	return "0";
}
