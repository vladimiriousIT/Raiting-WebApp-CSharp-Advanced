using System;

namespace ElementEqualToTheRest
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;
            int sumOfAllNumbers = 0;
            for (int i = 0; i < inputNumbers; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                sumOfAllNumbers += readNumber;

                if (readNumber > biggestNumber)
                {
                    biggestNumber = readNumber;
                }

            }
            int sumOfOthers = sumOfAllNumbers - biggestNumber;
            if(sumOfOthers == biggestNumber)
            {
                Console.WriteLine("YES");
                Console.WriteLine($"Sum = {biggestNumber}");
            }
            else
            {
                int difference = Math.Abs(biggestNumber - sumOfOthers);
                Console.WriteLine("NO");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
