// Se https://aka.ms/new-console-template för mer information
bool programrunning = true; // Variabel för att hålla programmet igång

while (programrunning) // Programmet körs tills användaren väljer att avsluta
{
    // Huvudmeny
    Console.WriteLine("HuvudMeny");
    Console.WriteLine("1, Ungdom eller pensionar (enskild person)");
    Console.WriteLine("2, Grupp - beräkna totalpris för sällskap");
    Console.WriteLine("3, Avsluta programmet");
    Console.WriteLine("Ange val:");

    string choice = Console.ReadLine(); // Användarens menyval

    switch (choice)
    {
        case "1":
            YouthOrSenior(); // Kör metod för enskild person
            continue;

        case "2":
            GroupPrice(); // Kör metod för gruppberäkning
            continue;

        case "3":
            programrunning = false; // Avslutar loopen
            Console.WriteLine("Programmet avslutas...");
            break;

        default:
            Console.WriteLine("Felaktig input. Försök igen");
            break;
    }

    // Metod för att beräkna pris för en person
    static void YouthOrSenior()
    {
        Console.Write("Ange ålder: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age)) // Kontrollerar att inmatning är en siffra
        {
            if (age < 20)
                Console.WriteLine("Ungdomspris: 80kr");
            else if (age > 64)
                Console.WriteLine("Pensionärspris: 90kr");
            else
                Console.WriteLine("Standardpris: 120kr");
        }
        else
        {
            Console.WriteLine("Ogiltig inmatning. Ange en siffra.");
        }
    }

    // Metod för att beräkna totalpris för en grupp
    static void GroupPrice()
    {
        Console.WriteLine("Hur många personer är ni i sällskapet?");
        string countInput = Console.ReadLine();

        if (int.TryParse(countInput, out int numberOfPeople) && numberOfPeople > 0)
        {
            int totalPrice = 0;

            // Loopar genom alla personer i gruppen
            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.Write($"Ange ålder för person {i}: ");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out int age))
                {
                    if (age < 20)
                        totalPrice += 80;
                    else if (age > 64)
                        totalPrice += 90;
                    else
                        totalPrice += 120;
                }
                else
                {
                    Console.WriteLine("Ogiltig ålder, räknas som standardpris.");
                    totalPrice += 120;
                }
            }

            // Skriver ut resultat
            Console.WriteLine($"Antal personer: {numberOfPeople}");
            Console.WriteLine($"Total kostnad: {totalPrice} SEK");
        }
        else
        {
            Console.WriteLine("Ogiltigt antal personer.");
        }
    }
}
