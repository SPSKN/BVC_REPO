// Sandbox.cpp : This file contains the 'main' function. Program execution begins and ends there.
//JUST A NOTEPAD FOR SCOTT PATTERSON
#include <iostream>
#include <string>
using namespace std;

struct Employee
{
	int ID;
	string Name;
}


void UpdateEmployee(const Employee& e)
{
	cout << e.ID << " " << e.Name << endl;
	//e.Name = "foooo";

}









void swap(int x, int y)
{
	int temp = x;
	x = y;
	y = temp;

}

void increment(int data[], int count)
{
	for (int i = 0; i < count; ++i)
		data[i] += 1; // same as int* data = array of stuff
}

int main()
{
/*

// Stack and heap
	int x = 5;
	int* y;



	y = new int;
	*y = 3;
	cout << *y << endl;
	cout << y << endl;
	delete y;

	*/







	int dataCount;
	cout << "How many numbers do you want to enter?" << endl;
	cin >> dataCount;

	// because dataCount is not set we can not just do int data[dataCount];
	int* data = new int[dataCount];

	for (int i = 0; i < dataCount; ++i)
	{
		cin >> data[i];
	}

	delete[] data;

	return 0;

}

/*SANDBOX*/