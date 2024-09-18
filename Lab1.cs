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

            sortedList.Add("bool", 1);
            sortedList.Add("char", 1);
            sortedList.Add("short", 2);
            sortedList.Add("int", 2);
            sortedList.Add("long", 4);
            sortedList.Add("float", 4);
            sortedList.Add("double", 8);

            Console.WriteLine($"\nКількість елементів у колекції: {sortedList.Count}");

            Console.WriteLine("\nЕлементи у прямому порядку:");
            foreach (KeyValuePair<string, int> item in sortedList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var reverseList = new List<KeyValuePair<string, int>>(sortedList);
            reverseList.Reverse();

            Console.WriteLine("\nЕлементи у зворотному порядку:");
            foreach (var item in reverseList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            sortedList.Clear();
            Console.WriteLine("\nКолекцію очищено.");
            Console.WriteLine($"\nКількість елементів після очищення: {sortedList.Count}");



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