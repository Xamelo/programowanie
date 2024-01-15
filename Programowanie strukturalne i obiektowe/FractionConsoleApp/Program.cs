using FractionConsoleApp;

#region pierwszy ulamek
Fraction firstFraction = new Fraction();
firstFraction.Numerator = 5;
firstFraction.Denominator = 8;

Console.WriteLine("Wartosc pierwszego ulamka: " + firstFraction);
#endregion

#region drugi ulamek
Fraction secondFraction = new Fraction(4, 7);
Console.WriteLine("Wartosc pierwszego ulamka: " + secondFraction);
#endregion

#region trzeci ulamek
Fraction thirdFraction; //= new Fraction();
/*thirdFraction.Numerator = firstFraction.Numerator * secondFraction.Numerator;
thirdFraction.Denominator = firstFraction.Denominator * secondFraction.Denominator;
thirdFraction.Mul(firstFraction, secondFraction);
thirdFraction = firstFraction.Mul(secondFraction);*/

thirdFraction = firstFraction * secondFraction;

Console.WriteLine("Wartosc trzeciego ulamka: " + thirdFraction);
#endregion