using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteckIzrazi
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var elements = input.Split(' ');
            var stack = new Stack<string>();

            for (int counter = input.Length - 1; counter >= 0; counter--)
            {
                stack.Push(elements[counter]);
            }
            while (stack.Count > 0)
            {
                var leftOperand = int.Parse(stack.Pop());
                var operation = int.Parse(stack.Pop());
                var rightOperand = int.Parse(stack.Pop());

                switch (operation)
                {
                    case '+':
                        stack.Push((leftOperand + rightOperand).ToString());
                        break;
                    case '-':
                        stack.Push((leftOperand - rightOperand).ToString());
                        break;

                    default:
                        break;
                }
            }

            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop().ToString());
            };

        }
    }
}
