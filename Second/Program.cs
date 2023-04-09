using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Size of the first array: ");
        int size1 = int.Parse(Console.ReadLine());

        Console.Write("Size of the second array: ");
        int size2 = int.Parse(Console.ReadLine());

        int[] array1 = new int[size1];
        int[] array2 = new int[size2];

        Console.WriteLine("Elements of the first array:");
        for (int i = 0; i < size1; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Elements of the second array:");
        for (int i = 0; i < size2; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        if (size1 != size2)
        {
            areEqual = false;
        }
        else
        {
            for (int i = 0; i < size1; i++)
            {
                if (array1[i] != array2[i])
                {
                    areEqual = false;
                    break;
                }
            }
        }

        if (areEqual)
        {
            Console.WriteLine("Arrays are equal");
        }
        else
        {
            Console.WriteLine("Arrays are not equal");
        }
    }
}