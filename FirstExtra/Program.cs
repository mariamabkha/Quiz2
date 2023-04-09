using System;

public class Program
{
    static void Main(string[] args)
    {
        {
            int[] freq = new int[100];
            int i, j, counter;

            Console.Write("Enter the size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];

            //შევავსოთ მასივი რიცხვებით
            for (i = 0; i < arraySize; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                freq[i] = 0;
            }

            for (i = 0; i < arraySize; i++)
            {
                counter = 1;
                for (j = i + 1; j < arraySize; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        freq[j] = 1;
                    }
                }

                if (freq[i] != 1)
                {
                    freq[i] = counter;
                }
            }

            Console.Write("The frequency of all elements of the array : \n");
            for (i = 0; i < arraySize; i++)
            {
                if (freq[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", numbers[i], freq[i]);
                }
            }
        }
    }
}
