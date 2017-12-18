using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftVirtualAcademy
{
    public static class ExtensionMethods
    {
        //------------------------ Extension Method in C# ----------------------------
        //Extension methods are NOT allowed in nested classes
        public static int WordCount(this string str) //Extension method using 'this'
        {
            string[] userString = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = userString.Length;
            return wordCount;
        }

        public static int TotalCharWithoutSpace(this string str)
        {
            int totalCharWithoutSpace = 0;
            string[] userString = str.Split(' ');
            foreach (string stringValue in userString)
            {
                totalCharWithoutSpace += stringValue.Length;
            }
            return totalCharWithoutSpace;
        }
    }

    public class ExtensionMethodsProgram
    {
        public static void Main(string[] args)
        {
            string userSentence = string.Empty;
            int totalWords = 0;
            int totalCharWithoutSpace = 0;
            Console.WriteLine("Enter your sentence");
            userSentence = Console.ReadLine();
            
            //Calling Extension Method WordCound
            totalWords = userSentence.WordCount();
            Console.WriteLine("Total number of words is: " + totalWords);

            //Calling Extension Method to count character
            totalCharWithoutSpace = userSentence.TotalCharWithoutSpace();
            Console.WriteLine("Total number of character is : " + totalCharWithoutSpace);
            Console.ReadKey();
        }
    }
}
