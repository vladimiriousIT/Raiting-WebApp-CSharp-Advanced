using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //1+ (2 - (2 + 3) * 4 / (3 +1))*5

            var input = Console.ReadLine();
            var stackOpenBrackets = new Stack<int>();

            for (int counter = 0; counter < input.Length; counter++)
            {
                if (input[counter] == '(')
                {
                    stackOpenBrackets.Push(counter);
                }
                if (input[counter] == ')')
                {
                    var openBracketIndex = stackOpenBrackets.Pop();
                    var lenght = counter - openBracketIndex + 1;
                    Console.WriteLine(input.Substring(openBracketIndex, lenght));
                }


            }


        }
    }
}
