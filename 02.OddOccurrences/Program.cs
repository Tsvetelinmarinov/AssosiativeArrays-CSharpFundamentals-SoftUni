/*
 * 02.OddOccurrences
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences;

class Program
{
    static void Main()
    {
        List<string> words = Console.ReadLine()!
            .Split()
            .ToList();

        Dictionary<string, int> wordOccurences = new();
        foreach (string word in words)
        {
            if (wordOccurences.ContainsKey(word.ToLower()))
            {
                wordOccurences[word.ToLower()]++;
            }
            else
            {
                wordOccurences.Add(word.ToLower(), 1);
            }
        }

        foreach ((string word, int occurence) in wordOccurences)
        {
            if (occurence % 2 != 0)
            {
                Console.Write($"{word} ");
            }
        }
    }
}