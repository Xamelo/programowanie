using Microsoft.EntityFrameworkCore;
using SchoolApp.Database;
using SchoolApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    class School
    {
        private SchoolDatabase schoolDatabase = new SchoolDatabase();

        public void Run()
        {
            while (true)
            {
                ShowMenu();

                Console.WriteLine("Wybierz: ");
                if (!int.TryParse(Console.ReadLine(), out int option))
                    continue;

                switch (option)
                {
                    case 1:
                        AddNewSchoolClass();
                        break;
                    case 2:
                        DeleteSchoolClass();
                        break;
                    case 3:
                        ModifySchoolClass();
                        break;
                    case 4:
                        ShowAllSchoolClasses();
                        break;
                    case 5:
                        AddNewStudent();
                        break;
                    case 6:
                        DeleteStudent();
                        break;
                    case 7:
                        ModifyStudent();
                        break;
                    case 8:
                        ShowAllStudents();
                        break;
                    case 9:
                        ShowAllStudentsWithClass();
                        break;
                    case 10:
                        ShowAllStudentsOrderBySurname();
                        break;
                    case 11:
                        ShowStudents();
                        break;
                    case 12:

                        break;
                    case 0:
                        return;
                }
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Lista dostepnych opccji: ");
            //CRUD
            Console.WriteLine("1. Dodanie nowej klasy"); //C - create
            Console.WriteLine("2. Usuniecie klasy"); //D - delete
            Console.WriteLine("3. Modyfikacja klasy"); //U - update
            Console.WriteLine("4. Wyswietlanie wszystkich klas"); //R - read
            Console.WriteLine("5. Dodanie nowego ucznia");
            Console.WriteLine("6. Usuniecie ucznia");
            Console.WriteLine("7. Modyfikacja ucznia");
            Console.WriteLine("8. Wyswietlanie wszystkich uczniow");
            Console.WriteLine("9. Wyświetlanie wszystkich uczniów z klasami");
            Console.WriteLine("10. Wyświetlenie wszystkich uczniów posortowanych po nazwisku");
            Console.WriteLine("11. Wyświetlanie uczniów z warunkami");
            Console.WriteLine("12. ");

            Console.WriteLine("0. Koniec programu \n");
        }

        #region Metody do pracy na tabeli SchoolClasses

        private void AddNewSchoolClass()
        {
            Console.WriteLine("Podaj nazwę klasy");
            string className = Console.ReadLine();

            SchoolClass schoolClass = new SchoolClass()
            {
                Name = className
            };
            schoolDatabase.SchoolClasses.Add(schoolClass);
            schoolDatabase.SaveChanges();
        }

        private void ShowAllSchoolClasses()
        {
            Console.WriteLine("Wszystkie klasy:");
            foreach (SchoolClass schoolClass in schoolDatabase.SchoolClasses)
            {
                Console.WriteLine(schoolClass.Id + " " + schoolClass.Name);
            }
            Console.ReadKey();
        }

        private void DeleteSchoolClass()
        {
            Console.WriteLine("Podaj id do usuniecia");
            if (int.TryParse(Console.ReadLine(), out int idToDelete))
            {
                SchoolClass schoolClassToDelete = schoolDatabase.SchoolClasses
                    .FirstOrDefault(sc => sc.Id == idToDelete);
                if (schoolClassToDelete != null)
                {
                    schoolDatabase.SchoolClasses.Remove(schoolClassToDelete);
                    schoolDatabase.SaveChanges();
                    Console.WriteLine("Kasowanie zakończone sukcesem.");
                }
                else
                {
                    Console.WriteLine("Brak klasy w bazie o takim id.");
                }
            }
            else
            {
                Console.WriteLine("Błąd parsowania. Nieprawidłowe dnae.");
            }
            Console.ReadKey();
        }

        private void ModifySchoolClass()
        {
            Console.WriteLine("Podaj id klasy do modyfikacji");
            if (int.TryParse(Console.ReadLine(), out int idToModify))
            {
                SchoolClass schoolClassToModify = schoolDatabase.SchoolClasses
                    .FirstOrDefault(sc => sc.Id == idToModify);
                if (schoolClassToModify != null)
                {
                    Console.WriteLine("Podaj nową nazwe klasy");
                    string newName = Console.ReadLine();

                    schoolClassToModify.Name = newName;
                    schoolDatabase.SaveChanges();
                    Console.WriteLine("Modyfikacja zakończona sukcesem.");
                }
                else
                {
                    Console.WriteLine("Brak klasy w bazie o takim id.");
                }
            }
            else
            {
                Console.WriteLine("Błąd parsowania. Nieprawidłowe dnae.");
            }
            Console.ReadKey();
        }

        #endregion

        #region Metody do pracy na tabeli Students

        private void AddNewStudent()
        {
            Console.WriteLine("Podaj imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj id klasy: ");
            int schoolClassId = int.Parse(Console.ReadLine());

            Student student = new Student()
            {
                Name = name,
                Surname = surname,
                SchoolClassId = schoolClassId
            };
            schoolDatabase.Students.Add(student);
            schoolDatabase.SaveChanges();
            Console.WriteLine("Dodano studenta");
            Console.ReadKey();
        }

        private void ShowAllStudents()
        {
            Console.WriteLine("Lista wszystkich uczniow: ");
            foreach (Student student in schoolDatabase.Students)
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
            }
            Console.ReadKey();
        }

        private void ShowAllStudentsWithClass()
        {
            Console.WriteLine("Lista wszystkich uczniow: ");
            foreach (Student student in schoolDatabase.Students.Include(s => s.SchoolClass))
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
                Console.WriteLine("Nazwa klasy: " + student.SchoolClass.Name);
            }
            Console.ReadKey();
        }

        private void DeleteStudent()
        {
            Console.WriteLine("Podaj id ucznia do usuniecia");
            int studentId = int.Parse(Console.ReadLine());

            Student studentToDelete = schoolDatabase.Students
                .FirstOrDefault(s => s.Id == studentId);
            if (studentToDelete != null)
            {
                schoolDatabase.Students.Remove(studentToDelete);
                Console.WriteLine("Usuniecie powiodlo sie");
                schoolDatabase.SaveChanges();
            }
            else
            {
                Console.WriteLine("Brak ucznia w bazie");
            }
            Console.ReadKey();
        }

        private void ModifyStudent()
        {
            Console.WriteLine("Podaj id ucznia do modyfikacji: ");
            int studentId = int.Parse(Console.ReadLine());

            Student studentToModify = schoolDatabase.Students
                .FirstOrDefault(s => s.Id == studentId);
            if (studentToModify != null)
            {
                Console.WriteLine("Podaj nowe imie: ");
                studentToModify.Name = Console.ReadLine();
                Console.WriteLine("Podaj nowe nazwisko: ");
                studentToModify.Surname = Console.ReadLine();
                Console.WriteLine("Modyfikacja powiodla sie");

                schoolDatabase.SaveChanges();
            }
            else
            {
                Console.WriteLine("Brak ucznie w bazie");
            }
            Console.ReadKey();
        }

        private void ShowAllStudentsOrderBySurname()
        {
            Console.WriteLine("Lista uczniow: ");
            foreach (Student student in schoolDatabase.Students.OrderBy(s => s.Surname).ThenByDescending(s => s.Name))
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
            }
            Console.ReadKey();
        }

        private void ShowStudents()
        {
            {
                Console.WriteLine("Podaj imię uczniów:");
                string userName = Console.ReadLine();
                Console.WriteLine($"Lista uczniow z imieniem {userName}, nazwiskiem na literę 'B' i zawierającym 'now': ");
                foreach (Student student in schoolDatabase.Students.Where(s => s.Name == userName
                                                                        && s.Surname.StartsWith("B")
                                                                        && s.Surname.Contains("now")))
                {
                    Console.WriteLine("Id: " + student.Id);
                    Console.WriteLine("Imię: " + student.Name);
                    Console.WriteLine("Nazwisko: " + student.Surname);
                }
                Console.ReadKey();
            }
        }

        private void S()
        {
            Console.WriteLine("Lista uczniow: ");
            foreach (Student student in schoolDatabase.Students)
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
            }
            Console.ReadKey();
        }

        #endregion
    }
}