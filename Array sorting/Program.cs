using System;

public class Program
{
    public static void Main()
    {
        int[] arr1 = { 1, 2, 0, 5, 9, 4, 3 };
        int[]? arr2 = null;
        int[] arr3 = { 5348, -742, 435, 345, 23, 0, 0, -5, -25, 89, 96, 42859, 13 };
        int[] arr4 = { 1 };
        int[] arr5 = Array.Empty<int>();

        PrintArrays(arr1);
        PrintArrays(arr2);
        PrintArrays(arr3);
        PrintArrays(arr4);
        PrintArrays(arr5);

        Console.Read();
    }

    public static int[]? BubbleSort(int[]? array)
    {
        if (array == null)
            return null;

        // Создаем копию, чтобы не мутировать исходный массив
        int[] arr = new int[array.Length];
        array.CopyTo(arr, 0);

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                    (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        return arr;
    }

    public static string ArrayToString(int[]? arr)
    {
        if (arr == null)
            return "null";

        return string.Join(" ", arr);
    }

    public static void PrintArrays(int[]? arr)
    {
        Console.WriteLine($"Начальный массив: {ArrayToString(arr)}");
        Console.WriteLine($"Отсортированный массив: {ArrayToString(BubbleSort(arr))}");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
    }
}