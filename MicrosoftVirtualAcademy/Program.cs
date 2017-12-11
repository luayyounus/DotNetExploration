using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftVirtualAcademy
{
    internal class Variables
    {
        private static void Main(string[] args)
        {
            const int x = 7;
            const int y = x + 3;

            Console.WriteLine(y);

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            var myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            var myLastName = Console.ReadLine();

            Console.WriteLine($"Hello {myFirstName} {myLastName}");
            Console.ReadLine();
        }
    }

    internal class Decision
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Christmas presents!");
            Console.Write("Choose a door to open: 1, 2: ");

            var userValue = Console.ReadLine();

            switch (userValue)
            {
                case "1":
                {
                    const string message = "You won an Apple! :)";
                    Console.WriteLine(message);
                    break;
                }
                case "2":
                {
                    const string message = "You won a TV!";
                    Console.WriteLine(message);
                    break;
                }
                default:
                    Console.WriteLine("You Lost! hehehe");
                    break;
            }

            Console.WriteLine("Hit enter if you want to play again!");

            var finalRound = Console.ReadLine();
            var msg = (finalRound == "") ? "Oopsy, you fell in the trap, Bye!" : "Thanks for typing in something but no more games!";
            //{0} is a replacement code/character
            Console.Write("GAME RESPONSE: {0}", msg);
            Console.ReadLine();
        }
    }
}
