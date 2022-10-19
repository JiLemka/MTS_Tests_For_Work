using System;
using System.Collections;

namespace Task3
{
    static class Program
    {
        public static void Main(string[] args)
        {
            var result = new[] { 1, 2, 3, 4 }.EnumerateFromTail(2);
            foreach (var item in result)
                Console.WriteLine($"{item} ");
        }
        
        public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable,
            int? tailLength)
        {
            var array = enumerable.ToArray();
            List<(T item, int? tail)> result = new List<(T item, int? tail)>();
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < tailLength)
                    result.Add((array[array.Length - i - 1], count++));
                else
                    result.Add((array[array.Length - i - 1], null));
            }
            
            return result;
        }
    }
}