using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDec = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            while (inputDec > 0)
            {
                stack.Push(inputDec % 2);
                inputDec = inputDec / 2;
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
