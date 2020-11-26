using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.Write("How many numbers do you want to input? ");
            int total = int.Parse(Console.ReadLine());
            int start = 0;
            Console.WriteLine("Type here the numbers");

            while (start < total)
            {
                int input = int.Parse(Console.ReadLine());
                numbers.Add(input);
                start++;
            }

            for (int i = numbers.Count; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = j-1; k < i-1 ; k++)
                    {
                        if (numbers[j]<numbers[k])
                        {
                            int swap = numbers[j];
                            numbers[j] = numbers[k];
                            numbers[k] = swap;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Format("Here is the sorted numbers: {0}",string.Join(",", numbers)));
            Console.ReadKey();
        }
    }
}
