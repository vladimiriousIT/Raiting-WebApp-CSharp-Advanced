using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length % 2 != 0)
            {
                notAllowed();
            }

            char[] opening = new [] { '(', '[', '{'};
            char[] closing = new [] { ')', ']', '}' };

            var stack = new Stack<char>();
            foreach (var element in input)
            {
                if(opening.Contains(element) )
                {
                    stack.Push(element);
                }
                else if(closing.Contains(element))
                {
                    var lastElement = stack.Pop();
                    int openingIndex = Array.IndexOf(opening, lastElement);
                    int closingIndex = Array.IndexOf(closing, element);

                    if (openingIndex != closingIndex)
                    {
                        notAllowed();
                    }
                }
            }
            if (stack.Any())
            {
                notAllowed();
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
        private static void notAllowed()
        {
            Console.WriteLine("NO");
            Environment.Exit(0);
        }

    }
}
