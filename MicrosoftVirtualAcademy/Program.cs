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
}
