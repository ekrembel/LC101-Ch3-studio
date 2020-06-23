using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace studio38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your text here: ");
            //string text = Console.ReadLine().ToLower();

            // Read text from a file
            string text = File.ReadAllText(@"/Users/ekrem/Projects/LC101/text.txt");

            // Convert text into an array of chars
            char[] charactersInString = text.ToCharArray();

            // Ensure to count and print only alphabetic characters
            string alpha = "qwertyuiopasdfghjklzxcvbnm";
            char[] alphaArr = alpha.ToCharArray();
            List<char> alphaList = alphaArr.ToList();

            List<char> characters = new List<char>();
            Dictionary<char, int> charNum = new Dictionary<char, int>();


            // Loop through text
            foreach (char c in charactersInString)
            {
                // Add each unique character to array
                if (!characters.Contains(c) && alphaList.Contains(c))
                {
                    characters.Add(c);
                }
            }


            // Count how many times each character repeats in the text
            foreach (char item in characters)
            {
                int counter = 0;
                foreach (char c in charactersInString)
                {
                    
                    if (item == c)
                    {
                        counter++;
                    }
                }

                // Add each character todictionary with its frequency
                charNum.Add(item, counter);               
            }

            // Print each character with their frequencies
            foreach (KeyValuePair<char, int> item in charNum)
            {
                Console.WriteLine("The letter " + item.Key + " is used " + item.Value + " times in the text.");
            }               
        }
    }
}
