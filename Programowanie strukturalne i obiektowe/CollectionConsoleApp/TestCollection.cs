using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestCollection
    {
        public void TestArrayAcollection()
        {
            //c++ - typ nazwa[rozmiar], np int tab1[5], tab1[2] = 2157;  int tab2[15];  const int rozmiar = 19; int tab2[rozmiar];

            int[] arrayOfNumbers = new int[10];
            arrayOfNumbers[5] = 2137;

            Random random = new Random();
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next() % 100;
            }

            foreach (int item in arrayOfNumbers)
            {
                Console.WriteLine($"{item}, ");
            }

            int max = arrayOfNumbers[0];
            foreach (int number in arrayOfNumbers)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine($"Najwieksza liczba to: {max}");
        }

        public void TestObjectArrayAcollection()
        {
            Number[] arrayWidthObjectNumbers = new Number[5];
            //arrayWidthObjectNumbers[2].ourNumber = 7;
            Random random = new Random();
            for (int i = 0; i < arrayWidthObjectNumbers.Length; i++)
            {
                arrayWidthObjectNumbers[i] = new Number();
                arrayWidthObjectNumbers[i].ourNumber = random.Next() % 100;
            }

            foreach (Number number in arrayWidthObjectNumbers)
            {
                Console.WriteLine($"{number.ourNumber}, ");
            }

            int max = arrayWidthObjectNumbers[0].ourNumber;
            foreach (Number number in arrayWidthObjectNumbers)
            {
                if (number.ourNumber > max)
                    max = number.ourNumber;
            }
            Console.WriteLine($"Najwieksza liczba to: {max}");
        }
    }
    
    class Number
    {
        public int ourNumber;
    }
}