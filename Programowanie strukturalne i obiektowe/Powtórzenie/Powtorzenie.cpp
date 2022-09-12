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
	system("cls");
	float area, side;

	cout << "Podaj bok kwadratu: ";
	cin >> side;
	area = side * side;
	cout << "Pole wynosi: " << area;
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
	cout << "Pole trojkata wynosi: " << area;
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
	default:
		cout << "Brak opcji w menu";
		break;
	}


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