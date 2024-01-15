using GeometricConsoleApp;
Point p = new Point(5, 8);
p.Display();
Console.WriteLine("Odleglosc odp unktu (0, 0) wynosi " + p.DistanceFromCenter);

Point p2 = new Point();
p2.Display();
p2.SetX(3);
p2.Y = 4;
Console.WriteLine("Odleglosc od punktu (0, 0) wynosi " + p2.DistanceFromCenter);
/*
Point p = new Point();
p.x = 5;
p.y = 8;
p.Display();

Point p2 = new Point();
p2.x = 68;
p2.y = 78;
p2.Display();

Point p3 = new Point
{
    x = 90,
    y = 63
};
p3.Display();
*/