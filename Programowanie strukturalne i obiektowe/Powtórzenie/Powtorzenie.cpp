#include <iostream>
using namespace std;

void showMenu()
{
	system("cls");
	cout << "Menu:\n";
	cout << "1. Pole kwadratu\n";
	cout << "2. Pole trojkatu\n";

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