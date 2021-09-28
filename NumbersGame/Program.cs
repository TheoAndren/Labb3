using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int number = random.Next(1, 20);
            int guesses = 1;
            
            while (guesses <= 5)
            {
               int userGuess = Convert.ToInt32(Console.ReadLine());
                CheckGuess(number, userGuess);
                guesses++;
            }
            Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            Environment.Exit(0);


        }
        static void CheckGuess(int number, int userGuess)
        {
            
            if (userGuess > number)
            {
                Console.WriteLine("Tyvärr du gissade för högt");
            }

            else if (userGuess < number)
            {
                Console.WriteLine("Tyvärr du gissade för lågt");
            }

            else if ((userGuess == number))
            {
                Console.WriteLine("Du gissade rätt! Wohooo!");
                Environment.Exit(0);
            }
    
        }
    } 

}
