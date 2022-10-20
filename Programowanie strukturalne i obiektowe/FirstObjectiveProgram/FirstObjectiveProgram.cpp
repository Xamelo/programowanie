#include <iostream>
using namespace std;

class Point
{
public:

	//metoda konstruktora obiektu
	Point()
	{
		x = 0;
		y = 0;
	}

	Point(int x, int y)
	{
		this->x = x;
		this->y = y;
	}

	double CalculateDistance()
	{
		double distance = sqrt(x * x + y * y);
		return distance;
	}

	void SetX(int a)
	{
		if (a >= 0)
			this->x = x;
	}

	void SetY(int a)
	{
		if (a >= 0)
			this->y = y;
	}
protected:

private:
	int x;
	int y;
};

int main()
{
	Point point(10, 15);
	//point.SetX(10);
	//point.SetY(15);
	double distance = point.CalculateDistance();
	cout << "Dystans od punku (0;0) = " << distance << endl;
}