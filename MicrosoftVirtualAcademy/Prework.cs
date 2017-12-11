﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftVirtualAcademy
{
    internal class Prework
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

        internal class ForIteration
        {
            private static void Main(string[] args)
            {
                ForLoop();
            }

            private static void ForLoop()
            {
                for (var i = 0; i < 10; i++)
                {
                    if (i != 7) continue;
                    Console.WriteLine("Found Seven!");
                    break;
                }
                Console.ReadLine();
            }
        }

        internal class Arrays
        {
            private static void Main(string[] args)
            {
                MakeArrays();
                Console.ReadLine();
            }

            private static void MakeArrays()
            {
                int[] numbers = new int[] { 2, 532, 3, 22, 451, 43, 593, 29 };
                string[] names = new string[] { "Luay", "Tam", "Shayne" };

                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
                Console.ReadLine();

                string phrase = "Welcome to my app, I am just killing time by watching this series. I skipped 99% of it since I am an advanced programmer. meh";
                char[] charPhrase = phrase.ToCharArray();
                Array.Reverse(charPhrase);

                Console.WriteLine(charPhrase);
            }
        }

        internal class DefiningCallingMethods
        {
            private static void Main(string[] args)
            {
                Console.WriteLine("The Name Game");
                Console.Write("What's your First Name? ");
                string firstName = Console.ReadLine();

                Console.Write("What's your last name? ");
                string lastName = Console.ReadLine();

                string firstNameReversed = ReverseString(firstName);
                string lastNameReversed = ReverseString(lastName);
                Console.WriteLine("The name reversed: {1}{0}", firstNameReversed, lastNameReversed);
                Console.ReadLine();
            }

            private static string ReverseString(string message)
            {
                char[] messageArray = message.ToCharArray();
                Array.Reverse(messageArray);
                return String.Concat(messageArray);
            }
        }
    }
}