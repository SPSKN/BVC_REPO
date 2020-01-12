// Sandbox.cpp : This file contains the 'main' function. Program execution begins and ends there.

#include <iostream>
#include <iomanip>
using namespace std;

int main(){

	/*Variables*/

	double taxPercent, billTotal, tipPercent, peoplePaying;

	/*The Function*/

	 cout << "How Much is the bill($)?  ";
	 cin >> billTotal;
	 cout << "How much is the Tax(%)?  ";
	 cin >> taxPercent;
	 cout << "How much is the Tip(%)?  ";
	 cin >> tipPercent;
	 cout << "How many people are paying?  ";
	 cin >> peoplePaying;

	double billAfterTax = billTotal * (taxPercent/100) + billTotal;
	double billAfterTip = billAfterTax * (tipPercent/100) + billAfterTax;
	double billPerPerson = billAfterTip / peoplePaying;

	/*The Display part*/

	 cout << setprecision(2) << fixed <<  "Bill Before Tax: " << billTotal << endl;
	 cout << setprecision(2) << fixed <<  "Bill After Tax: " << billAfterTax << endl;
	 cout << setprecision(2) << fixed << "Bill After Tip: " << billAfterTip << endl;
	 cout << setprecision(2) << fixed <<  "Bill Per Person: " << billPerPerson << endl;

	return 0;

}
/*
    I left it to round up. At te end of the day if the resturant is losing half a penny per bill. After 1000 customers
    thats $10, in a month that $300. $3600 a year is a HUGE loss.
    
*/

/*SANDBOX*/