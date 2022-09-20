#include <iostream>
#include <string>

using namespace std;

void showMenu()
{
	system("cls");
	cout << "Menu:\n";
	cout << "1. Pole kwadratu\n";
	cout << "2. Pole trojkatu\n";
	cout << "3. Liczby nieparzyste od podanej liczby\n";
	cout << "4. Ciag Fibonnaciego\n";
	cout << "5. Dzielniki podanej liczby\n";
	cout << "6. Liczba zapisana slownie\n";
	cout << "7. Przeksztalcanie z systemu dziesiętnego na binarny\n";
	cout << "8. Przeksztalcanie na system binarny lub szestnastkowy\n";

	cout << "0. Zamknij program\n";
}

int chooseOptionsFromUser()
{
	int selectedOption;

	cout << "Wybierz opcje: ";
	cin >> selectedOption;
	return selectedOption;
}

void squareArea()
{
	system("cls");
	float area, side;

	cout << "Podaj bok kwadratu: ";
	cin >> side;
	area = side * side;
	cout << "Pole wynosi: " << area << endl;
}

void triangleArea()
{
	system("cls");
	float side, height, area;

	cout << "Podaj bok trojkata: ";
	cin >> side;
	cout << "Podaj wysokosc trojkata: ";
	cin >> height;
	area = side * height / 2;
	cout << "Pole trojkata wynosi: " << area << endl;
}

void oddNumbers()
{
	system("cls");
	int number;

	cout << "Podaj liczbe, od ktorej wyswietla sie liczby nieparzystye: ";
	cin >> number;
	/*for (int i = number; i >= 0; i--)
	{
		if (i % 2 != 0)
			cout << i << ", ";
	}*/
	if (number > 0)
		number--;

	while (number > 0)
	{
		cout << number << ", ";
		number = number - 2;
	}
	cout << endl;
}

void stringOfFibonnaci()
{
	system("cls");
	int howmany;
	cout << "Ile wyswielic liczb ciagu Fibonnaciego: ";
	cin >> howmany;
	long long n1 = 0;
	long long n2 = 1;
	for (int i = 0; i < howmany; i++)
	{
		cout << n1 << ", ";
		n1 += n2;
		n2 = n1 - n2;
		if (n1 < 0)
		{
			cout << "Za duza liczba do wyswietlenia\n";
			break;
		}
	}
	cout << endl;
}

void divisorOfNumber()
{
	system("cls");
	int number;
	cout << "Podaj liczbe, ktorej wyswietla sie dzielniki: ";
	cin >> number;

	/*for (int i = 1; i <= number / 2; i++)
	{
		if (number % i == 0)
			cout << i << ", ";
	}
	cout << number;
	cout << endl;

	wersja 2
	for (int i = 1; i <= sqrt(number); i++)
	{
		if (number % i == 0)
		{
			cout << i << ", ";
			int divider = number / i;
			if (divider != i)
				cout << (number / i) << ", ";
		}
	}
	cout << endl;
	*/
	int changeNumber;
	if (number % 2 == 0)
		changeNumber = 1;
	else
		changeNumber = 2;
	for (int i = 1; i <= sqrt(number); i = i + changeNumber)
	{
		if (number % i == 0)
		{
			cout << i << ", ";
			int divider = number / i;
			if (divider != i)
				cout << divider << ", ";
		}
	}
	cout << endl;
}

void numberWords()
{
	system("cls");
	string words[10] = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
	int numberFromUser;
	cout << "Podaj liczbe, do zapisania jej slownie: ";
	cin >> numberFromUser;

	int number = numberFromUser;
	do
	{
		int digit = number % 10;
		number = number / 10;
		cout << words[digit] << ' ';

	} while (number != 0);
	cout << endl;

	number = numberFromUser;
	string stringNumber = "";
	do
	{
		int digit = number % 10;
		number = number / 10;

		stringNumber = words[digit] + " " + stringNumber;

	} while (number != 0);
	cout << stringNumber;
	cout << endl;
}

void decimalToBinary()
{
	system("cls");
	int decimalNumber;
	string result;
	cout << "Podaj liczbe w systemie dziesietnym do zamiany na binarny: ";
	cin >> decimalNumber;

	while (decimalNumber != 0)
	{
		result = (decimalNumber % 2 ? "1" : "0") + result;
		decimalNumber = decimalNumber / 2;
	}
	cout << result;
	cout << endl;
}

void hexOrBinary()
{
	system("cls");
	int option;
	cout << "Wybierz system do przemiany (2 - 16): ";
	cin >> option;
	switch (option)
	{
	case 2:
		decimalToBinary();
		break;
	}
}

void doSelctedTask(int selectedOption)
{
	switch (selectedOption)
	{
	case 1:
		squareArea();
		break;
	case 2:
		triangleArea();
		break;
	case 3:
		oddNumbers();
		break;
	case 4:
		stringOfFibonnaci();
		break;
	case 5:
		divisorOfNumber();
		break;
	case 6:
		numberWords();
		break;
	case 7:
		decimalToBinary();
		break;
	case 8:
		hexOrBinary();
		break;
	case 0:
		return;
	default:
		cout << "Brak opcji w menu";
		break;
	}

	system("pause");

	/* if (selectedOption == 1)
	{
		squareArea();
	}

	if (selectedOption == 2)
	{
		triangleArea();
	} */
}

void mainProgram()
{
	int selected;
	do
	{
		//1. wyświetlenie menu
		showMenu();
		//2. wybranie opcji przez użytkownika
		selected = chooseOptionsFromUser();
		//3. wykonanie wybranego zadania
		doSelctedTask(selected);
	} while (selected != 0);
}

void main()
{
	mainProgram();
}