using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteakQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackIn = Console.ReadLine();
            var steak = new Stack<char>();

            foreach(var character in stackIn)
            {
                steak.Push(character);
            }
            while(steak.Count() > 0)
            {
                Console.WriteLine(steak.Pop().ToString());
            };
        }
    }
}
