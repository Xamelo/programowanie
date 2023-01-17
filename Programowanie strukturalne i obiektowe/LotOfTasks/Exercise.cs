using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class Exercise
    {
        //Podstawy programowania:

        public void Exercise1(float number1, float number2)
        {
            Console.WriteLine((number1 + number2) / 2);
        }

        public void Exercise2(float number1, float number2)
        {
            Console.WriteLine(number1 * number2);
        }

        public void Exercise3(double radius, double height)
        {
            double radiusX2 = radius * radius;
            Console.WriteLine(0.33 * Math.PI * radiusX2 * height);
        }

        public void Exercise4(double circleRadius)
        {
            Console.WriteLine(Math.PI * (circleRadius * circleRadius));
        }

        public void Exercise5(int number1, int number2)
        {
            Console.WriteLine(number1 * number1 + number2 * number2);
        }

        public void Exercise6(float sideB, float height)
        {
            Console.WriteLine((sideB / 2) * height);
        }

        public void Exercise7(double careRadius)
        {
            double radiusX3 = careRadius * careRadius * careRadius;
            Console.WriteLine(1.25 * Math.PI * radiusX3);
        }

        public void Exercise8(double sideA, double sideB, double height)
        {
            Console.WriteLine(((sideA + sideB) * height) / 2);
        }

        public void Exercise9(double number1, double number2, double number3)
        {
            number2 = number2 * 2;
            number3 = number3 * 3;
            Console.WriteLine((number1 + number2 + number3) / 6);
        }

        //if:

        public void Exercise10()
        {
            Console.WriteLine("Enter the number: ");
            string podanaLiczba = Console.ReadLine();
            int number = int.Parse(podanaLiczba);

            if (number % 2 == 0)
                Console.WriteLine($"{number} is even");
            else
                Console.WriteLine($"{number} is not even");
        }

        public void Exercise11()
        {
            Console.WriteLine("Enter the number: ");
            string podanaLiczba = Console.ReadLine();
            int number = int.Parse(podanaLiczba);

            if (number > 0)
                Console.WriteLine($"{number} is positive");
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative");
            }
            else if (number == 0)
            {
                Console.WriteLine($"{number} is zero");
            }
        }

        public void Exercise12()
        {
            Console.WriteLine("Podaj rok: ");
            string podanyRok = Console.ReadLine();
            int rok = int.Parse(podanyRok);

            if (rok % 4 == 0)
                Console.WriteLine($"Rok {rok} jest przestepny");
            else
                Console.WriteLine($"Rok {rok} nie jest przestepny");
        }

        public void Exercise13()
        {
            Console.Write("Podaj ocene: ");
            string dana = Console.ReadLine();
            int mark = int.Parse(dana);

            if (mark == 1)
                Console.WriteLine("niedostateczny");
            if (mark == 2)
                Console.WriteLine("dopuszczajacy");
            if (mark == 3)
                Console.WriteLine("dostateczny");
            if (mark == 4)
                Console.WriteLine("dobry");
            if (mark == 5)
                Console.WriteLine("bardzo dobry");
        }

        public void Exercise14()
        {
            string password = "abc123";
            Console.Write("Podaj haslo: ");
            string writedPassword = Console.ReadLine();

            if (password == writedPassword)
                Console.WriteLine("haslo poprawne");
            else
                Console.WriteLine("haslo niepoprawne");
        }

        public void Exercise15()
        {
            Console.WriteLine("Enter day: ");
            string getDay = Console.ReadLine();
            int day = int.Parse(getDay);

            Console.WriteLine("Enter month: ");
            string getMonth = Console.ReadLine();
            int month = int.Parse(getMonth);

            if (day > 31)
                Console.WriteLine("Wrong day");
            else
            {
                if (month > 12)
                    Console.WriteLine("Wrong month");

                switch (month)
                {
                    case 1:
                        Console.WriteLine(day <= 31 ? "poprawna data" : "nieporpawna data");
                        break;

                    case 2:
                        Console.WriteLine(day <= 28 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 3:
                        Console.WriteLine(day <= 31 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 4:
                        Console.WriteLine(day <= 30 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 5:
                        Console.WriteLine(day <= 31 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 6:
                        Console.WriteLine(day <= 30 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 7:
                        Console.WriteLine(day <= 31 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 8:
                        Console.WriteLine(day <= 31 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 9:
                        Console.WriteLine(day <= 30 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 10:
                        Console.WriteLine(day <= 31 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 11:
                        Console.WriteLine(day <= 30 ? "poprawna data" : "nieporpawna data");
                        break;
                    case 12:
                        Console.WriteLine(day <= 31 ? "poprawna data" : "nieporpawna data");
                        break;
                }
            }
        }

        public void Exercise16()
        {
            Console.Write("Podaj temperature: ");
            string podanaTemperatura = Console.ReadLine();
            int temperatura = int.Parse(podanaTemperatura);

            if (temperatura >= 30)
                Console.WriteLine("goraco");
            if (temperatura < 30 && temperatura >= 15)
                Console.WriteLine("cieplo");
            if (temperatura < 15 && temperatura >= 5)
                Console.WriteLine("umiarkowanie");
            if (temperatura < 5 && temperatura >= -5)
                Console.WriteLine("chlodno");
            if (temperatura < -5)
                Console.WriteLine("zimno");
        }

        //petle: 

        public void Exercise17()
        {
            Console.WriteLine("Podaj liczbe: ");
            string podanaLiczba = Console.ReadLine();
            int number = int.Parse(podanaLiczba);
            czyPierwsza(number);

            bool czyPierwsza(int a)
            {
                if (a < 2)
                    return false;

                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                        return false;
                }
                return true;
            }
            if (czyPierwsza(number) == true)
                Console.WriteLine("Jest pierwsza");
            else
                Console.WriteLine("Nie jest pierwsza");
        }

        public void Exercise18()
        {
            Console.WriteLine("Wpisz wyraz: ");
            string wyrazDoSprawdzenia = Console.ReadLine();
            int dlugosc = wyrazDoSprawdzenia.Length;

            for (int i = 0; i < dlugosc / 2; i++)
            {
                if (wyrazDoSprawdzenia[i] != wyrazDoSprawdzenia[dlugosc - i - 1])
                {
                    Console.WriteLine("nie jest to palindrom");
                    break;
                }
                else
                {
                    Console.WriteLine("jest palindrom");
                    break;
                }
            }
        }

        /*public void Exercise19()
        {

        }*/

         public void Exercise20()
        {
            Console.WriteLine("Podaj liczbe: ");
            int number = int.Parse(Console.ReadLine());
            int numberLength = number.ToString().Length;

            int amountOfDivider = 1;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    amountOfDivider += i + number / i;
            }

            if (number == numberLength)
                amountOfDivider -= numberLength;
            if (number == amountOfDivider)
                Console.WriteLine("Jest to liczba doskonala");
            else
                Console.WriteLine("Nie jest to liczba doskonala");
        }

        //petla for:

        public void Exercise21()
        {
            for (int i = 1; i < 101; i++)
                Console.WriteLine(i);
        }

        public void Exercise22()
        {
            int suma = 0;
            for (int i = 1; i < 101; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
        }

        public void Exercise23()
        {
            for (int i = 1; i < 11; i++)
                Console.WriteLine(i * i);
        }

        public void Exercise24()
        {
            int number = 1;
            int silnia = 1;

            for (int i = 1; i <= number; i++)
            {
                silnia = silnia * i;
                Console.WriteLine(silnia);

                if (number < 10)
                    number++;
            }
        }

        public void Exercise25()
        {
            for (int mnozna = 1; mnozna < 10; mnozna++)
            {
                for (int mnoznik = 1; mnoznik < 10; mnoznik++)
                {
                    Console.WriteLine($"{mnozna} * {mnoznik} = {mnozna * mnoznik}");
                }

                if (mnozna <= 9)
                {
                    Console.WriteLine();
                }
            }
        }

        public void Exercise26()
        {
            float wynik;
            for (float i = 1; i < 101; i++)
            {
                wynik = i / 3;
                Console.WriteLine(wynik);
            }
        }

        public void Exercise27()
        {
            double suma = 0;
            for (int i = 1; i <= 10; i++)
            {
                suma = suma + Math.Pow(i, 2);
            }
            Console.WriteLine(suma);
        }

        public void Exercise28()
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(b);
                b = b + a;
                a = b - a;
            }
        }

        public void Exercise29()
        {
            int number = 2;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number}^{i} = " + Math.Pow(number, i));
            }
        }

        /*public void Exercise30()
        {
        }*/

        public void Exercise31()
        {
            string password = "abc123";
            string userPassword = "";
            do
            {
                Console.WriteLine("Podaj haslo: ");
                userPassword = Console.ReadLine();
                if (userPassword != password)
                    Console.WriteLine("haslo niepoprawne");
            } while (userPassword != password);
            Console.WriteLine("haslo poprawne");
        }

        public void Exercise32()
        {
            double number = 1;
            double suma = 0;
            do
            {
                Console.WriteLine(Math.Pow(number, 2));
                number++;
                suma = Math.Pow(number, 2) + suma;
            } while (suma < 1000);
            Console.WriteLine("suma: " + suma);
        }
    }
}
