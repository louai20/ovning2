using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning2
{
    internal class TicketCalculator
    {
        // Metod för att beräkna pris för en person
        public static void YouthOrSenior()
        {
            Console.Write("Ange ålder: ");
            string input = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(input, out int age)) // control if input is a number
            {
                int price = GetPriceForAge(age); // get price based on age
                Console.WriteLine($"Biljettpriset är: {price} SEK");
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Ange en siffra.");
            }
        }

        // Metod för att beräkna totalpris för en grupp
        public static void GroupPrice()
        {
            Console.WriteLine("Hur många personer är ni i sällskapet?");
            string countInput = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(countInput, out int numberOfPeople) && numberOfPeople > 0)
            {
                int totalPrice = 0;

                // Loopar genom alla personer i gruppen
                for (int i = 1; i <= numberOfPeople; i++)
                {
                    Console.Write($"Ange ålder för person {i}: ");
                    string ageInput = Console.ReadLine() ?? string.Empty;

                    if (int.TryParse(ageInput, out int age))
                    {
                        totalPrice += GetPriceForAge(age);
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

        private static int GetPriceForAge(int age)
        {
            if (age < 20)
                return 80;
            else if (age > 64)
                return 90;
            else
                return 120;
        }
    }
}
