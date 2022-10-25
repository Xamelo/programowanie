#include <iostream>
<<<<<<< HEAD
using namespace std;

#pragma region Structs

struct CordinateGPS
{
	int x, y;
=======

struct CoordinateGPS
{
    int x, y;
>>>>>>> 0b26e0378eba21941ce9c891f3171dbaab82b6a9
};

struct Direction
{
<<<<<<< HEAD
	int x, y;
};

#pragma endregion

=======
    int x, y;
};

>>>>>>> 0b26e0378eba21941ce9c891f3171dbaab82b6a9
class Car
{
public:

<<<<<<< HEAD
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
=======
#pragma region Konstruktory

    Car(std::string name)
    {
        this->name = name;
        coordinateGPS.x = 0;
        coordinateGPS.y = 0;
        direction.x = 1;
        direction.y = 0;
    }

    Car(std::string name, int x, int y)
    {
        this->name = name;
        coordinateGPS.x = x;
        coordinateGPS.y = y;
        direction.x = 1;
        direction.y = 0;
    }

#pragma endregion

    void ShowInfo()
    {
        std::cout << "***********************************\n";
        std::cout << "Samochod o nazwie " << name << "\n";
        std::cout << "Pozycja (" << coordinateGPS.x << " ; " << coordinateGPS.y << ")\n";
        std::cout << "***********************************\n";
    }

    void MoveForward()
    {
        coordinateGPS.x += direction.x;
        coordinateGPS.y += direction.y;
    }

#pragma region Turn method

    void TurnLeft()
    {
        /*if (direction.x == 1 && direction.y == 0)
        {
            direction.x = 0;
            direction.y = 1;
        }
        else if (direction.x == 0 && direction.y == 1)
        {
            direction.x = -1;
            direction.y = 0;
        }
        else if (direction.x == -1 && direction.y == 0)
        {
            direction.x = 0;
            direction.y = -1;
        }
        else if (direction.x == 0 && direction.y == -1)
        {
            direction.x = 1;
            direction.y = 0;
        }*/

        int tmpX = direction.x;
        direction.x = -direction.y;
        direction.y = tmpX;

    }

    void TurnRight()
    {
        /*if (direction.x == 1 && direction.y == 0)
        {
            direction.x = 0;
            direction.y = -1;
        }
        else if (direction.x == 0 && direction.y == 1)
        {
            direction.x = 1;
            direction.y = 0;
        }
        else if (direction.x == -1 && direction.y == 0)
        {
            direction.x = 0;
            direction.y = 1;
        }
        else if (direction.x == 0 && direction.y == -1)
        {
            direction.x = -1;
            direction.y = 0;
        }*/

        int tmpX = direction.x;
        direction.x = direction.y;
        direction.y = -tmpX;
    }

    void TurnBack()
    {
        TurnRight();
        TurnRight();
    }
>>>>>>> 0b26e0378eba21941ce9c891f3171dbaab82b6a9

#pragma endregion

protected:

private:
<<<<<<< HEAD
#pragma region Definitions

	string name;
	CordinateGPS cordinateGPS;
	Direction direction;

#pragma endregion
=======
    std::string name;
    CoordinateGPS coordinateGPS;
    Direction direction;

>>>>>>> 0b26e0378eba21941ce9c891f3171dbaab82b6a9
};

int main()
{
<<<<<<< HEAD
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
=======
    setlocale(LC_CTYPE, "polish");

    Car carFirst("Super bryka");
    Car carSecond("Kr¹¿ownik szos", 10, 10);

    carFirst.ShowInfo();
    carSecond.ShowInfo();

    carFirst.MoveForward();
    carFirst.TurnLeft();
    carFirst.MoveForward();

    carFirst.ShowInfo();
}
>>>>>>> 0b26e0378eba21941ce9c891f3171dbaab82b6a9
