// Se https://aka.ms/new-console-template för mer information

using ovning2;

bool programrunning = true; // Variabel för att hålla programmet igång

while (programrunning) // Programmet körs tills användaren väljer att avsluta
{
    // Huvudmeny
    Console.WriteLine("HuvudMeny");
    Console.WriteLine("1, Ungdom eller pensionar (enskild person)");
    Console.WriteLine("2, Grupp - beräkna totalpris för sällskap");
    Console.WriteLine("3, Upprepa en text 10 gånger");
    Console.WriteLine("4, Det tredje ordet");
    Console.WriteLine("5, Avsluta programmet");
    Console.WriteLine("Ange val:");

    string choice = Console.ReadLine() ?? string.Empty; // Användarens menyval

    switch (choice)
    {
        case "1":
            TicketCalculator.YouthOrSenior(); // Kör metod för enskild person
            continue;

        case "2":
            TicketCalculator.GroupPrice(); // Kör metod för gruppberäkning
            continue;

        case "3":
            RepeatTenTimes(); // Kör metod för att upprepa text tio gånger
            continue;

        case "4":
            ThirdWord();
            continue;

        case "5":
            programrunning = false; // Avslutar loopen
            Console.WriteLine("Programmet avslutas...");
            break;

        default:
            Console.WriteLine("Felaktig input. Försök igen");
            break;
    }



    static void RepeatTenTimes()
    {
        Console.Write("Ange en text: ");
        string input = Console.ReadLine() ?? string.Empty;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i}. {input}");
        }
        Console.WriteLine();
    }

    // metod för att hitta och visa det tredje ordet i en mening
    static void ThirdWord()
    {
        Console.Write("Ange en mening med minst tre ord: ");
        string input = Console.ReadLine() ?? string.Empty;

        // splita meningen i ord och ta bort tomma poster
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words.Length >= 3)
        {
            // visa det tredje ordet (index 2)
            Console.WriteLine($"Det tredje ordet är: {words[2]}");
        }
        else
        {
            Console.WriteLine("Meningen innehåller färre än tre ord.");
        }
    }
}

