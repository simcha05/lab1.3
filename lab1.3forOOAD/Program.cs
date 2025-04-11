using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 3, 8, 1, 2, 7, 4, 6 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Array.Sort(array);

        Console.WriteLine("\nОтсортированный массив:");
        PrintArray(array);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}

