using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] rnd = new int[200];
            IEnumerable<int> result = new int[200];
            Random rand = new Random();

            for (int x = 0; x < 200; x++)
            {
                rnd[x] = rand.Next(100, 2001);
                Console.Write($"{rnd[x]} ");
            }

            result = Sort(rnd, 600, 2000);
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }

        /// <summary>
        /// Возвращает отсортированный по возрастанию поток чисел
        /// </summary>
        /// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает миллиарда чисел.</param>
        /// <param name="sortFactor">Фактор упорядоченности потока. Неотрицательное число. Если в потоке встретилось число x, то в нём больше не встретятся числа меньше, чем (x - sortFactor).</param>
        /// <param name="maxValue">Максимально возможное значение чисел в потоке. Неотрицательное число, не превышающее 2000.</param>
        /// <returns>Отсортированный по возрастанию поток чисел.</returns>
        static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
        {
            int[] values = new int[maxValue + 1];
            int currentValue = 0;

            foreach (int x in inputStream)
            {
                ++values[x];

                int minPossible = x - sortFactor;
                while (currentValue < minPossible)
                {
                    while (--values[currentValue] >= 0)
                        yield return currentValue;
                    currentValue++;
                }
            }

            while (currentValue < values.Length)
            {
                while (--values[currentValue] >= 0)
                    yield return currentValue;
                currentValue++;
            }
        }
    }
}