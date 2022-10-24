#include <iostream>
#include <ctime>
using namespace std;

struct InformationsOfPerson
{
	string name, surname, height, weight;
	int dateOfBirth;
};

class Person
{
public:

#pragma region Constructors

	int currentTime()
	{
		time_t now = time(0);
		tm* ltm = new tm;
		localtime_s(ltm, &now);
		return 1900 + ltm->tm_year;
	}

	Person(string name, string surname, string height, string weight, int dateOfBirth)
	{
		this->informations.name = name;
		this->informations.surname = surname;
		this->informations.height = height;
		this->informations.weight = weight;
		this->informations.dateOfBirth = dateOfBirth;
	}

#pragma endregion

	void showInfo()
	{
		system("cls");
		cout << "*********************\n";
		cout << "Name: " << informations.name << '\n';
		cout << "Surname: " << informations.surname << '\n';
		cout << "Year of birth: " << informations.dateOfBirth << '\n';
		cout << "Age: " << (currentTime() - informations.dateOfBirth) << '\n';
		cout << "Height: " << informations.height << '\n';
		cout << "Weight: " << informations.weight << '\n';
	}

	void adult()
	{
		cout << "============\n";
		if ((currentTime() - informations.dateOfBirth) >= 18)
			cout << "Adult: yes\n";
		else
			cout << "Adult: no\n";
		cout << "============\n";
		cout << "*********************\n";
	}

protected:

private:
	InformationsOfPerson informations;
};

int main()
{
	Person person("Jackob", "Black", "180cm", "78kg", 2010);
	person.showInfo();
	person.adult();
}
/*
Zadanie
Napisaæ klasê (oraz kod testuj¹cy) opisuj¹cy osobê. 
Dodaæ 5 pól opisuj¹cych osobê (ma byæ rok urodzenia)
dodanie konstruktorów umo¿liwiaj¹cych utworzenie
obiektu na parê sposobów
*/