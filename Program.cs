void GetNewAccount()
{
    Console.WriteLine("podaj login");
    string login = Console.ReadLine();
    Console.WriteLine("podaj haslo");
    string password = Console.ReadLine();

    string GetEncryptedPassowrd(string password)
    {
        string encryptedPassword = "";
        string[] characters = { "a", "b", "c", "d", "4", "1", "#" };
        int i = 0;
        foreach (char letter in password)
        {
            if (i == 6)
            {
                i = 0;
                encryptedPassword += letter + characters[i] + characters[i + 1];
            }
            else
            {
                encryptedPassword += letter + characters[i] + characters[i + 1];
            }
            i++;
        }
        return encryptedPassword;
    }

    File.AppendAllText("C:/Users/Uczen/Desktop/dane.txt", $"{login} {password} {GetEncryptedPassowrd(password)}\n");
}

void CheckDataOfUser()
{
    string[] users = File.ReadAllLines("C:/Users/Uczen/Desktop/dane.txt");
    foreach (string user in users)
    {
        Console.WriteLine(user);
    }
    Console.ReadLine();
}

void SignIn()
{
    string[] users = File.ReadAllLines("C:/Users/Uczen/Desktop/dane.txt");

    Console.WriteLine("login: ");
    string login = Console.ReadLine();
    foreach (string user in users)
    {
        if (login == user.Split(' ')[0])
        {
            Console.WriteLine("haslo: ");
            string password = Console.ReadLine();
            if (password == DecodeEncryptedPassword(user.Split(' ')[2]))
            {
                Console.WriteLine("zalogowano");
                break;
            }
            else
            {
                Console.WriteLine("zle haslo");
                break;
            }

        }
    }
    Console.ReadLine();

    string DecodeEncryptedPassword(string EncryptedPassword)
    {
        string decodedPassword = "";
        int i = 0;
        do
        {
            decodedPassword += EncryptedPassword[i];
            i += 3;
        } while (i < EncryptedPassword.Length);
        return decodedPassword;
    }
}

void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("1. stworz nowe konto");
    Console.WriteLine("2. sprawdz uzytkownikow");
    Console.WriteLine("3. zaloguj");
    Console.WriteLine("0. zamknij");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            GetNewAccount();
            ShowMenu();
            break;
        case 2:
            CheckDataOfUser();
            ShowMenu();
            break;
        case 3:
            SignIn();
            ShowMenu();
            break;
    }
}

ShowMenu();