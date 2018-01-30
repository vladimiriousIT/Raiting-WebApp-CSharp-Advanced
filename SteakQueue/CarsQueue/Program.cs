using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandToRead = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var maxStack = new Stack<int>();

            maxStack.Push(int.MinValue);

            for (int i = 0; i < commandToRead; i++)
            {
                var comandReadline = Console.ReadLine().Split().Select(int.Parse).ToArray();


                switch (comandReadline[0])
                {
                    case 1:
                        var element = comandReadline[1];
                        stack.Push(element);
                        if (element >= maxStack.Peek() )
                        {
                            maxStack.Push(element);
                        }
                        break;
                    case 2:
                        var popedElement = stack.Pop();
                        if(maxStack.Peek() == popedElement)
                        {
                            maxStack.Pop();
                        }
                        break;
                    case 3:
                        int maxElement = maxStack.Peek();
                        Console.WriteLine(maxElement);
                        break;
                }
            }

        }
    }
}