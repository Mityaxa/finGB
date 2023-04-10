using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter items count: ");
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];
        string temp;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Row {i + 1}: ");
            temp = Console.ReadLine();
            if (temp.Length <= 3)
            {
                arr[count] = temp;
                count++;
            }
        }

        Console.WriteLine("Array with strings less then 3:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}