using System;

namespace PaperRockScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Paper, Rock, Scissors!");
            Console.WriteLine("Enter your choice (P/R/S):");

            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            string userChoice = Console.ReadLine().ToUpper();

            switch (userChoice)
            {
                case "P":
                    Console.WriteLine("You chose paper.");
                    if (computerChoice == 1)
                    {
                        Console.WriteLine("The computer chose paper too. It's a tie!");
                    }
                    else if (computerChoice == 2)
                    {
                        Console.WriteLine("The computer chose rock. You win!");
                    }
                    else
                    {
                        Console.WriteLine("The computer chose scissors. You lose!");
                    }
                    break;
                case "R":
                    Console.WriteLine("You chose rock.");
                    if (computerChoice == 1)
                    {
                        Console.WriteLine("The computer chose paper. You lose!");
                    }
                    else if (computerChoice == 2)
                    {
                        Console.WriteLine("The computer chose rock too. It's a tie!");
                    }
                    else
                    {
                        Console.WriteLine("The computer chose scissors. You win!");
                    }
                    break;
                case "S":
                    Console.WriteLine("You chose scissors.");
                    if (computerChoice == 1)
                    {
                        Console.WriteLine("The computer chose paper. You win!");
                    }
                    else if (computerChoice == 2)
                    {
                        Console.WriteLine("The computer chose rock. You lose!");
                    }
                    else
                    {
                        Console.WriteLine("The computer chose scissors too. It's a tie!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
