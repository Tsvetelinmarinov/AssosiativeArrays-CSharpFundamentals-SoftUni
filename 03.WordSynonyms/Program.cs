/*
 * 03.WordSynonyms
 */

using System;
using System.Collections.Generic;

namespace _03.WordSynonyms;

class Program
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine()!);
        Dictionary<string, List<string>> wordSynonyms = new();

        for (; counter > 0; --counter)
        {
            string word = Console.ReadLine()!;
            string synonym = Console.ReadLine()!;

            if (wordSynonyms.ContainsKey(word))
            {
                wordSynonyms[word].Add(synonym);
            }
            else
            {
                wordSynonyms.Add(word, new List<string>()
                {
                    synonym
                });
            }
        }

        foreach (KeyValuePair<string, List<string>> pair in wordSynonyms)
        {
            Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
        }
    }
}