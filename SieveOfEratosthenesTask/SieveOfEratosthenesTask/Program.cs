using System;

namespace SieveOfEratosthenesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Реализация алгоритма \"Решето Эратосфена\" -");
            Console.WriteLine("алгоритм нахождения всех простых чисел до\n"
                + "некоторого целого числа n, который приписывают\n"
                + "древнегреческому математику Эратосфену Киренскому");

            Console.WriteLine("Введите целое число N");

            int n = int.Parse(Console.ReadLine());

            bool[] targetArray = new bool[n];

            targetArray = TrueValuesInintializer(targetArray);

            targetArray = ToSieveOfEratosthenesSorting(targetArray);

            Console.WriteLine("Список простых чисел: ");

            ShowSortingArray(targetArray);

            Console.ReadKey();
        }

        static bool[] TrueValuesInintializer(bool[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = true;

            return array;
        }

        static bool [] ToSieveOfEratosthenesSorting(bool [] array)
        {
            var t = 0;

            for (int i = 2; i * i < array.Length; i++)
            {
                if (array[i] == true)
                    for (int j = i * i; j < array.Length; j = ++t * i + i * i)
                        array[j] = false;

                t = 0;
            }

            return array;
        }

        static void ShowSortingArray (bool [] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == true)
                    Console.WriteLine(i);
        }
    }
}
