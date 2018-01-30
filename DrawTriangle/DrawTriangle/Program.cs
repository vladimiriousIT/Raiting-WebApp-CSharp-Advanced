using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = (4 * size) + 1;

            char dot = '.';
            char hashtag = '#';
            char space = ' ';

            string firstRow = new string(hashtag, width);
            Console.WriteLine(firstRow);
            int countOfDots = 1;
            int countOfHashtags = (width - 3) / 2;
            int countOfWhiteSpace = 1;

            string toFormat = "{0}{1}{2}{1}{0}";

            string eYe = "(@)";
            int countOfEyeSpaces = (countOfWhiteSpace - eYe.Length) / 2;
            string eyeRow = "{0}{1}{2}{3}{2}{1}{0}";
            Console.WriteLine(eyeRow, new string(dot, countOfDots),
                                      new string(hashtag, countOfHashtags),
                                      new string(space, countOfWhiteSpace),
                                      eYe);

            int rows = (size - 1)/ 2;
            for (int i = 0; i < rows; i++)
            {
                countOfDots++;
                countOfWhiteSpace += 2;
                countOfHashtags -= 2;

                string dots = new string(dot, countOfDots);
                string hashtags = new string(hashtag, countOfHashtags);
                string spaces = new string(space, countOfWhiteSpace);

                Console.WriteLine(toFormat,dots,hashtags,spaces);
            }

            countOfHashtags = countOfDots;
            for (int i = 0; i < size; i++)
            {
                countOfDots++;

                string dots = new string(dot, countOfDots);
                string hashtags = new string(hashtag, countOfHashtags);

                Console.WriteLine("{0}{1}{0}",dots, hashtags);

                countOfHashtags -= 2;
            }
        }
    }
}
