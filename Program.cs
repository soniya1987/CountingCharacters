using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string sampleText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            string lowerSampleText = sampleText.ToLower();
            Console.WriteLine("Enter a string to count: ");

            string userString = Console.ReadLine();
            string lowerUserString = userString.ToLower();

            Dictionary<char, int> charCount = new Dictionary<char, int>();
             
            foreach (char letter in lowerUserString)
            {
                if (!char.IsLetterOrDigit(letter))
                {
                    continue;
                }

                if (!charCount.ContainsKey(letter))
                {
                    charCount.Add(letter, 1);
                }
                else
                {
                    charCount[letter]++;
                }
            }

            //testing results
            foreach (KeyValuePair<char, int> pair in charCount)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            Console.Read();
        }
    }
}
