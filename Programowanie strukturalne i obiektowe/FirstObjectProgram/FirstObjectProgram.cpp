#include <iostream>

using namespace std;

class Point {
public:
    int x;
    int y;

    double calculateDistance()
    {
        double distance = sqrt(x * x + y * y);
        return distance;
    }

};

int main()
{
    Point point;
    point.x = 10;
    point.y = 15;
    double distance = point.calculateDistance();
    cout << "Dystans od punktu (0;0) = " << distance << "\n";
}