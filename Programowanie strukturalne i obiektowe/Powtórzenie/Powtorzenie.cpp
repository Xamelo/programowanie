#include <iostream>
using namespace std;

void showMenu()
{
	system("cls");
	cout << "Menu:\n";
	cout << "1. Pole kwadratu\n";
	cout << "2. Pole trojkatu\n";
}

int chooseOptionsFromUser()
{
	int selectedOption;

	cout << "Wybierz opcje\n";
	cin >> selectedOption;
	return selectedOption;
}

void squareArea()
{
	float area, side;

	cout << "Podaj bok kwadratu: ";
	cin >> side;
	area = side * side;
	cout << "Pole wynosi: " << area;
}

void triangleArea()
{
	float side, height, area;

	cout << "Podaj bok trojkata: ";
	cin >> side;
	cout << "Podaj wysokosc trojkata: ";
	cin >> height;
	area = side * height / 2;
	cout << "Pole trojkata wynosi: " << area;
}

void doSelctedTask(int selectedOption)
{
	if (selectedOption == 1)
	{
		squareArea();
	}

	if (selectedOption == 2)
	{
		triangleArea();
	}
}

void mainProgram()
{
	//1. wyświetlenie menu
	showMenu();
	//2. wybranie opcji przez użytkownika
	int selected = chooseOptionsFromUser();
	//3. wykonanie wybranego zadania
	doSelctedTask(selected);
}

void main()
{
	mainProgram();
}