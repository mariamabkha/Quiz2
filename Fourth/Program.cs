using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];

        //შევავსოთ მასივი რიცხვებით
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] counts = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    counts[i]++;
                }
            }
        }

        int maxCount = 0;
        int mostFrequent = array[0];

        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                mostFrequent = array[i];
            }
        }

        Console.WriteLine($"The most repeated element is {mostFrequent} , {maxCount} times ");
    }
}
