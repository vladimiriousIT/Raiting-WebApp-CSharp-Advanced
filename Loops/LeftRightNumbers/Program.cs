using System;

namespace LeftRightNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToRead = int.Parse(Console.ReadLine());
            //numbers from the left side
            int leftSum=0;
            int rightSum=0;

            for (int i = 0; i < numberToRead * 2; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                if (i < numberToRead)
                {
                    leftSum += readNumber;
                }
                else
                {
                    rightSum += readNumber;
                }
            }

            if(leftSum == rightSum)
            {
                Console.WriteLine("Yes it is: {0}",leftSum);
            }
            else
            {
                int difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No + {0}",difference);
            }
        }
    }
}
