using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            arr[i] = Console.ReadLine();
        }

        string[] newArr = new string[n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i].Length <= 3)
            {
                newArr[count] = arr[i];
                count++;
            }
        }

        Console.WriteLine("Массив строк длиной меньше или равной 3 символам:");
        Console.WriteLine(string.Join(Environment.NewLine, newArr));
    }
}