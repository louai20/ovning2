// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

bool programrunning = true;
while (programrunning)
{
    Console.Clear();
    Console.WriteLine("HuvudMeny");
    Console.WriteLine("1, Ungdom eller pensionar (enskild person)");
    Console.WriteLine("2, Grupp - beräkna totalpris för sällskap");
    Console.WriteLine("3, Avsluta programmet");
    Console.WriteLine("Ange val:");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            YouthOrSenior();
            break;

        case "2":
            GroupPrice();
            break;

        case "3":
            programrunning = false;
            Console.WriteLine("Programmet avslutas...");
            break;


        default:
            Console.WriteLine("Felaktig input. Försök igen");
            break;
    }
    static void YouthOrSenior()
    {
        Console.Write("Ange ålder: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int age))
        {
            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }
        }
        else
        {
            Console.WriteLine("oglitig inmatning. Ange en siffra.");
        }
    }
    static void GroupPrice()
    {
        Console.WriteLine("Hur många personer är ni i sällskapet?");
        string countInput = Console.ReadLine();
        if (int.TryParse(countInput, out int numberOfPeople) && numberOfPeople > 0)
        {
            int totalPrice = 0;
            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.WriteLine("Enter age for person", i);
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
                    Console.WriteLine("invalid age, counted as standard price.");
                    totalPrice += 120;
                }
            }
            Console.WriteLine("Number of people:", numberOfPeople);
            Console.WriteLine("Total cost: ", totalPrice, "SEK");
        }
        else
            Console.WriteLine("Invalid number of people.");

    }
}