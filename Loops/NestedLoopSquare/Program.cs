using System;

namespace NestedLoopSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }
    }
}
