using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] numbers = new int[arraySize];

        //შევავსოთ მასივი რიცხვებით
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int productOfEven = 1;
        int sumOfOdd = 0;

        //მასივზე იტერაციით დავითვალოთ ლუწი რიცხვების ნამრავლი და კენტი რიცხვების ჯამი
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                productOfEven *= numbers[i];
            }
            else
            {
                sumOfOdd += numbers[i];
            }
        }

        Console.WriteLine($"\nProduct of even numbers: {productOfEven}");
        Console.WriteLine($"Sum of odd numbers: {sumOfOdd}\n");






        // თითოეული ელემენტი რამდენჯერ გვხვდება 

        Dictionary<int, int> count = new Dictionary<int, int>();

        // Iterate over the array to count occurrences
        for (int i = 0; i < arraySize; i++)
        {
            int current = numbers[i];

            if (count.ContainsKey(current))
            {
                count[current]++;
            }
            else
            {
                count[current] = 1;
            }
        }

        // Print the count of each element 
        Console.WriteLine("Element counts:");
        foreach (KeyValuePair<int, int> entry in count)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        Console.WriteLine("\n");



        /*      // გზა იმისთვის რომ ვიპოვოთ კონკრეტული რიცხვი მასივში რამდენჯერ მეორდება:
              Console.WriteLine("\n");
              Console.Write("Enter number to check occurrence: ");
              int number = int.Parse(Console.ReadLine());

              int occurrences = numbers.Count(x => x == number);
              Console.WriteLine("Occurrence of {0} in given array is {1}", number, occurrences);*/

    }

}