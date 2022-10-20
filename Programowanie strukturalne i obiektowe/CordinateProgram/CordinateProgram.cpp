#include <iostream>
#include <cmath>

using namespace std;

struct Point
{
    float x;
    float y;
};

double calculateDistance(float a, float b)
{
    double distance = sqrt(a * a + b * b);
    return distance;
}

double calculateDistance(Point p)
{
    double distance = sqrt(p.x * p.x + p.y * p.y);
    return distance;
}

void CoordinateTestVersion1()
{
    float x, y;

    //Point point;
    cout << "Podaj x:\n";
    cin >> x;

    cout << "Podaj y:\n";
    cin >> y;

    double distance = calculateDistance(x, y);
    //distance = sqrt(x * x + y * y);

    cout << "Odleglosc od zera wynosi: " << distance << '\n';
}

void CoordinateTestVersion2()
{
    Point userPoint;
    cout << "Podaj anime:\n";
    cin >> userPoint.x;

    cout << "Podaj hentai:\n";
    cin >> userPoint.y;

    double distance = calculateDistance(userPoint.x, userPoint.y);
    //distance = sqrt(x * x + y * y);

    cout << "Odleglosc od zera wynosi: " << distance << '\n';
}
 
string name;
string surname;
int age;
int hight;

struct Person
{
    string name;
    string surname;
    int age;
    int hight;
    Point cordinate;
};

Person p1;
//p1.name
//p1.cordinate.x = 5;

string nameTab[5];
string surnameTab[5];
int ageTab[5];
int hightTab[5];

Person pTab[5];
//pTab[1].name = "Ala";

int main()
{
    //CoordinateTestVersion1();
    //CoordinateTestVersion2();
}