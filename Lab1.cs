using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        public static void Main()
        {
            //Завдання 1
            Console.WriteLine("Завдання 1");

            SortedList<string, int> sortedList = new SortedList<string, int>();

            sortedList.Add("long", 4);
            sortedList.Add("double", 8);
            sortedList.Add("bool", 1);
            sortedList.Add("short", 2);
            sortedList.Add("char", 1);
            sortedList.Add("int", 2);
            sortedList.Add("float", 4);

            Console.WriteLine($"\nКількість елементів у колекції: {sortedList.Count}");

            var sortedByValue = sortedList.OrderBy(item => item.Value).ToList();

            Console.WriteLine("\nЕлементи, відсортовані за значеннями:");
            foreach (var item in sortedByValue)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var reverseList = sortedByValue;
            reverseList.Reverse();

            Console.WriteLine("\nЕлементи у зворотному порядку:");
            foreach (var item in reverseList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            sortedByValue.Clear();
            Console.WriteLine("\nКолекцію очищено.");
            Console.WriteLine($"\nКількість елементів після очищення: {sortedByValue.Count}");



            //Завдання 2

            Console.WriteLine("\n-------------------------");
            Console.WriteLine("Завдання 2");


            List<int> numbers = new List<int> { 3, 5, 7, 2, 9, 11, 6 };

            int min = numbers.Min();
            int max = numbers.Max();
            double average = (min + max) / 2.0;

            Console.WriteLine($"\nМінімальне значення: {min}");
            Console.WriteLine($"\nМаксимальне значення: {max}");
            Console.WriteLine($"\nСереднє арифметичне: {average}");




        }
    }
}
