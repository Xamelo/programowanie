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
}



void doSelctedTask()
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
	chooseOptionsFromUser();
	//3. wykonanie wybranego zadania
	doSelctedTask();
}

void main()
{
	mainProgram();

}