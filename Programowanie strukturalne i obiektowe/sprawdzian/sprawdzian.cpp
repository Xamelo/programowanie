#include <iostream>
using namespace std;

void triangleArea()
{
	float triangleBase;
	float triangleHeight;
	cout << "Enter base of triangle: ";
	cin >> triangleBase;
	cout << "Enter height of triange: ";
	cin >> triangleHeight;

	if (triangleBase > 0 && triangleHeight > 0)
	{
		float triangleArea = (triangleBase / 2) * triangleHeight;
		cout << triangleArea;
	}
	else
		cout << "Wrong numbers";
}

void checkLegalAge()
{
	int age;
	cout << "Enter age: ";
	cin >> age;
	if (age > 0 && age < 18)
	{
		cout << "Person is child";
	}
	else if (age >= 18 && age < 200)
	{
		cout << "Person is adult";
	}
	else
	{
		cout << "Wrong age";
	}
}

void checkTheNumberRange()
{
	int number;
	cout << "Enter number: ";
	cin >> number;
	if (number > 15 && number <= 56)
		cout << "The number falls into this range";
	else
		cout << "The number don't fall into this range";
}

void sumOfPositiveNumbers()
{
	const int SIZE = 10;
	int arrayOfNumbers[SIZE];
	int sum = 0;
	for (int i = 0; i < SIZE; i++)
	{
		cout << "Enter number to array: ";
		cin >> arrayOfNumbers[i];
	}
	for (int i = 0; i < SIZE; i++)
	{
		if (arrayOfNumbers[i] > 0)
		{
			sum = sum + arrayOfNumbers[i];
		}
	}
	cout << "Sum: " << sum;
}

void changeFromDecimalToBinary()
{
	int number, rest = 0, binary = 0, position = 1;
	cout << "Enter number in decimal: ";
	cin >> number;
	do
	{
		rest = number % 2;
		binary += rest * position;
		position *= 10;
		number /= 2;
	} while (number != 0);
	cout << "Number in binary: " << binary;
}

int main()
{
	triangleArea();
	//checkLegalAge();
	//checkCompartment();
	//sumOfPositiveNumbers();
	//changeFromDecimalToBinary();
}