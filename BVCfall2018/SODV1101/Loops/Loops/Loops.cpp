// Loops.cpp : This file contains the 'main' function. Program execution begins and ends there.
// Vending machine
/*
	Lewis is a loser
*/

#include <iostream>
#include <Windows.h>
using namespace std;

int main()
{
	int userInput;
	do {
		cout << " What do you want to buy? \n";
		cout << "1 For Chips - $1.50 \n";
		cout << "2 For Drinks - $3.00 \n";
		cout << "3 For Bar - $2.25 \n";
		
		
		cin >> userInput;

	} while (userInput < 4);
	{
		if (userInput == 1);
		cout << "Chips \n";
		
		
	}
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu
