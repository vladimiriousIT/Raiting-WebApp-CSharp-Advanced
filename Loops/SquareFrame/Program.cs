using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int calcSize = input - 2;
            string topAndBotom = "+";

            for (int flrow = 0; flrow < calcSize; flrow++)
            {
                topAndBotom = topAndBotom + " -";
            }
            topAndBotom = topAndBotom + " +";
            Console.WriteLine(topAndBotom);
            string middleRows = "|";

            for (int flrow = 0; flrow < calcSize; flrow++)
            {
                middleRows = middleRows + " -";
            }
            middleRows = middleRows + " |";
            for (int row = 1; row <= calcSize; row++)
            {
                Console.WriteLine(middleRows);
            }
            Console.WriteLine(topAndBotom);

        }
    }
}
