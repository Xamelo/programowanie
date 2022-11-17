using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1stObjectConsoleApp
{
    class Person
    {
        private string name, surname;
        private int age;

        public Person()
        {
            name = "Gregory";
            surname = "Kruszczak";
            age = 69;
        }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Informacja o osobie: ");
            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"Nazwisko: {surname}");
            Console.WriteLine($"Wiek: {age}");
        }
    }
}
