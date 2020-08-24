using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for word
            //convert to array
            //reverse array
            //convert back to string
            //check if paplindrome

            //Declare variables
            string word, reverseWord;

            //ask for word
            Console.WriteLine("<------Enter the word------>");
            word = Console.ReadLine();

            //convert to array
            char[] temp = word.ToCharArray();

            //reverse the temp array
            Array.Reverse(temp);

            //convert back to string
            reverseWord = new string(temp);

            //check if reverseWord is palindrome
            if (word.Equals(reverseWord))
                Console.WriteLine(word + " is a palindrome");
            else
                Console.WriteLine(word + " not a palindrome");

        }
    }
}
