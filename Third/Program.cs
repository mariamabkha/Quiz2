using System;

class Program
{
    static void Main(string[] args)
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

        int maxLength = 1;
        int maxElement = array[0];
        int currentLength = 1;
        int currentElement = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == currentElement)
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxElement = currentElement;
                }

                currentLength = 1;
                currentElement = array[i];
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxElement = currentElement;
        }

        Console.WriteLine($"{maxLength} times, element: {maxElement}");
    }
}
