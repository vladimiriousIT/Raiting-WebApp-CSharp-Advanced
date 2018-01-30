using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToRead = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;
            for (int i = 0; i < numbersToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                if(readNumber > biggestNumber)
                {
                    biggestNumber = readNumber;
                }
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
