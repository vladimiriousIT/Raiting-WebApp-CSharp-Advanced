using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            //var children
            string[] children = Console.ReadLine().Split(' ');
            var potatoLimit = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(children);
            while (queue.Count != 1)
            {
                for (int counter = 1; counter < potatoLimit; counter++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed:{queue.Dequeue()}");
            }
            Console.WriteLine($"Last is : {queue.Dequeue()}  ");


        }
    }
}
