using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    ////завдання 1
    //static void Main()
    //{
    //    int[] array = { 3, 7, 14, 21, 28, 35, 42, 49, 56 };

    //    int count = CountNumber(array);

    //    Console.WriteLine($"Number of elements in the array divisible by seven: {count}");
    //}

    //static int CountNumber(int[] array)
    //{
    //    int count = array.Count(number => number % 7 == 0);
    //    return count;
    //}


    ////завдання 2
    //static void Main()
    //{
    //    int[] array = { -52, -13, 0, 16, 28, 31, 44, 59 };

    //    int count = Count_Positives(array);

    //    Console.WriteLine("Number of positive numbers in the array: " + count);
    //}

    //static int Count_Positives(int[] array)
    //{
    //    int count = array.Count(x => x > 0);
    //    return count;
    //}


    //завдання 3
    //static void Main()
    //{
    //    int[] array = { 1, -2, 3, -4, 5, -2, 0 };

    //    List<int> unique = array.Where(x => x < 0).Distinct().ToList();

    //    Console.WriteLine("Unique negative numbers: ");
    //    foreach (int num in unique)
    //    {
    //        Console.Write(num + " ");
    //    }




    //завдання 4
    //static void Main()
    //{
    //    Func<string, bool> checkWord = text => text.Contains("given_word");

    //    string text1 = "This is a text with several words.";
    //    string text2 = "Here is given_word among others.";
    //    Console.WriteLine("Text 1 contains the given word? " + checkWord(text1));
    //    Console.WriteLine("Text 2 contains the given word? " + checkWord(text2));
    //}
}