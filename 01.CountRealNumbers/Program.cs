/*
 * 01.CountRealNumbers
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers;

class Program
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine()!
            .Split()
            .Select(double.Parse)
            .ToList();

        SortedDictionary<double, int> numberOccurences = new();
        foreach (double number in numbers)
        {
            if (numberOccurences.ContainsKey(number))
            {
                numberOccurences[number]++;
            }
            else
            {
                numberOccurences.Add(number, 1);
            }
        }

        foreach ((double number, int occurences) in numberOccurences)
        {
            Console.WriteLine($"{number} -> {occurences}");
        }
    }
}