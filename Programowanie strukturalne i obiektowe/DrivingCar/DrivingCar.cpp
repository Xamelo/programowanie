#include <iostream>
using namespace std;

#pragma region Structs

struct CordinateGPS
{
	int x, y;
};

struct Direction
{
	int x, y;
};

#pragma endregion

class Car
{
public:

#pragma region Constructors

	Car(string name)
	{
		this->name = name;
		cordinateGPS.x = 0;
		cordinateGPS.y = 0;
		direction.x = 1;
		direction.y = 0;
	}
	Car(string name, int x, int y)
	{
		this->name = name;
		cordinateGPS.x = x;
		cordinateGPS.y = y;
		direction.x = 1;
		direction.y = 0;
	}

#pragma endregion

	void ShowInfo()
	{
		cout << "***************************\n";
		cout << "Samochod o nazwie " << name << '\n';
		cout << "Pozycja (" << cordinateGPS.x << ';' << cordinateGPS.y << ")\n";
		cout << "***************************\n";
	}

	void moveForward()
	{
		cordinateGPS.x += direction.x;
		cordinateGPS.y += direction.y;
	}

#pragma region Turn method

	void TurnLeft()
	{
		int tmpX = direction.x;
		direction.x = -direction.y;
		direction.y = tmpX;
	}

	void TurnRight()
	{
		int tmpX = direction.x;
		direction.x = direction.y;
		direction.y = tmpX;
	}
	
	void TurnBack()
	{
		TurnRight();
		TurnRight();
	}

#pragma endregion

protected:

private:
#pragma region Definitions

	string name;
	CordinateGPS cordinateGPS;
	Direction direction;

#pragma endregion
};

int main()
{
	setlocale(LC_CTYPE, "polish");

	Car car1st("Super bryka");
	Car car2nd("Kr¹zownik szos", 10, 10);
	car1st.ShowInfo();
	car2nd.ShowInfo();

	car1st.moveForward();
	car1st.TurnLeft();
	car1st.moveForward();
	car1st.ShowInfo();
}