///
/// 04.WordFilter
/// 

namespace _04.WordFilter;

class Program
{
    static void Main()
    {
        Console.ReadLine()!
            .Split()
            .Where(fruit => fruit.Length % 2 == 0)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}