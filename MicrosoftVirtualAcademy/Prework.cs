﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace MicrosoftVirtualAcademy
{
    public static class Prework
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

                DisplayResult(ReverseString(firstName), ReverseString(lastName));
            }

            private static string ReverseString(string message)
            {
                char[] messageArray = message.ToCharArray();
                Array.Reverse(messageArray);
                return String.Concat(messageArray);
            }

            private static void DisplayResult(string name1, string name2)
            {
                Console.WriteLine("The name reversed: {1} {0}", name1, name2);
                Console.ReadLine();
            }
        }

        internal class WhileIteration
        {
            private static void Main(string[] args)
            {
                bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = MainMenu();
                }
            }

            private static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Print Numberz Game");
                Console.WriteLine("2) Guessing Game");
                Console.WriteLine("3) Exit");

                string result = Console.ReadLine();
                if (result == "1")
                {
                    PrintNumbers();
                    return true;
                }
                if (result == "2")
                {
                    GuessingGame();
                    return true;
                }
                if (result == "3")
                {
                    return false;
                }
                return true;
            }

            private static void PrintNumbers()
            {
                Console.Clear();
                Console.WriteLine("Print Numberz Game!");
                Console.Write("Type a number: ");
                int result = int.Parse(Console.ReadLine());
                int counter = 1;
                while (counter <= result)
                {
                    Console.Write(counter);
                    Console.Write("-");
                    counter++;
                }
                Console.ReadLine();
            }

            private static void GuessingGame()
            {
                Console.Clear();
                Console.WriteLine("Guessing Game!");

                Random myRandom = new Random();
                int randomNumber = myRandom.Next(1, 11);

                int guesses = 0;
                bool incorrect = true;

                do
                {
                    Console.WriteLine("Guess a number between 1 and 10: ");
                    string result = Console.ReadLine();
                    guesses++;
                    if (result == randomNumber.ToString())
                        incorrect = false;
                    else
                        Console.WriteLine("Wrong!");
                    
                } while (incorrect);

                Console.WriteLine("Correct! It took you {0} guesses.", guesses);
                Console.ReadLine();
            }
        }

        internal class Strings
        {
            private static void Main(string[] args)
            {
                string doubleQuotes = "My \"so-called\" Life";
                string newLine = "new line \n";
                string tab = "this is a tab \t hmmm";
                string backSlash = "Go to c:\\ drive";
                string anotherWayForBackSlash = @"Go to c:\ drive";

                string stringFormat = String.Format("{0} {0} {1} {1} {1} {0}", "Lol", "Meh");
                string currency = String.Format("{0:C}", 2938.43);
                string longNumber = String.Format("{0:G}", 23784981);
                string percentage = String.Format("Percentage: {0:P}", .123);

                string phoneNumber = String.Format("Phone Number: {0:(###)-###-####}", 6076076070);
                string lyrics = "  Whenever wherever, hell yeah we are meant to be together ... la la la   ";
                string subString = lyrics.Substring(23); //Starts at the position 23 to the end of string
                string subString2 = lyrics.Substring(0, 4);
                string toUpperCase = lyrics.ToUpper();
                string replace = lyrics.Replace(" ", "--");
                string remove = lyrics.Remove(0, 40); //from index to index

                string trim = lyrics.Trim(); //remove leading and trailing spaces
                string trimStart = lyrics.TrimStart(); //Just the leading spaces

                string demoLengthWithTrim =
                    String.Format("Length before: {0} - Length After: {1}", 
                    lyrics.Length, trim.Length);

                StringBuilder myStringBuilder = new StringBuilder();

                for (int i = 0; i < 100; i++)
                {
                    myStringBuilder.Append("--");
                    myStringBuilder.Append(i);
                }

                Console.WriteLine(longNumber);
                Console.ReadLine();
            }
        }

        internal class OutVariables
        {
            public void GetValue(out int x)
            {
                x = 3;
            }
            public int GetValue()
            {
                var input = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
                return input;
            }
            
        }

        internal class AutoImplementedProps
        {
            public int PlayerNumber { get; set; }
            public string FieldName { get; private set; }

            public AutoImplementedProps()
            {
            }

            public AutoImplementedProps(int playerNum, string fieldName)
            {
                PlayerNumber = playerNum;
                FieldName = fieldName;
            }
        }

        internal class MainForAutoImpProps
        {
            //initializing props through the constructor
            private static void Main()
            {
                AutoImplementedProps autoImplementedProps = new AutoImplementedProps(3, "Hello"); // No problem setting the FieldName
            }
            //initializing the class directly
            private static void Main2()
            {
                AutoImplementedProps autoImplementedProps = new AutoImplementedProps();
                autoImplementedProps.PlayerNumber = 3;
                //autoImplementedProps.FieldName = "ksdfjg"; // Problem setting the FieldNAme - Must use a constructor or factory method
            }
        }

        internal class Dynamic
        {
            private static void Main()
            {
                dynamic dyn = 1;
                object obj = 1;

                //GetType here is getting the runtime type of both dyn and obj
                Console.WriteLine(dyn.GetType());
                Console.WriteLine(obj.GetType());

                dynamic strTest = 's';
                object objTest = "Hello";

                Console.WriteLine(strTest.GetType());
                Console.WriteLine(objTest.GetType());
                Console.ReadLine();
            }
        }

        internal class Tuples
        {
            private static void Main()
            {
                var tuple = new Tuple<string, string[], int, int[]>
                    ("perl", new string[] {"java", "C#"}, 1, new int[] {2, 3});
                testTuple(tuple);
            }

            public static void testTuple(Tuple<string, string[], int, int[]> tuple)
            {
                Console.WriteLine(tuple.Item1);
                foreach (string name in tuple.Item2)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine(tuple.Item3);
                foreach (int num in tuple.Item4)
                {
                    Console.WriteLine(num);
                }
            }
        }

        internal class TryCatchStatements
        {
            public static void Main()
            {
                TryCatchStatement();
            }
            static void TryCatchStatement()
            {
                int num = 13, denom = 0, result;

                int[] myArray = {22, 33, 55};

                try
                {
                    result = num / denom; // this is the first thing to break the app and will throw (DivideByZero)
                    result = myArray[num]; //since the first one is broken this won't be reached nor its exception

                }
                catch (DivideByZeroException error)
                {
                    //you can set a break point on this line to see the error description after being initialized
                    Console.WriteLine("We are in the first catch block");
                    Console.WriteLine(error.Message);
                }
                catch (IndexOutOfRangeException error)
                {
                    Console.WriteLine("We are in the second catch block");
                    Console.WriteLine(error.Message);
                }
                finally
                {
                    Console.WriteLine("Last thing to do once the app is broken"); //avoid memory leak - close connections and others
                }
                Console.Read();
            }
        }
    }
}
