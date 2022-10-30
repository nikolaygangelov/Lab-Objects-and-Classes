using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace _1._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .ToList();

            Random random = new Random();
            for (int i = 0; i < words.Count; i++)
            {
                
                string firstWord = words[i];
                int randomIndex = random.Next(0, words.Count);
                string nextWord = words[randomIndex];

                words[i] = nextWord;
                words[randomIndex] = firstWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }

    
}
