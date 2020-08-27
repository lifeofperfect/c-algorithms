using System;
using System.Runtime.InteropServices;

namespace Remove_Palindromic_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "loml";

            char[] arr = text.ToCharArray();

            Array.Reverse(arr);

            string rev = new string(arr);

            if (text == "")
            {
                Console.WriteLine(0);
            }

            if(text.Equals(rev))
                Console.WriteLine(1);

            else
                Console.WriteLine(2);
            

           
        }
    }
}
