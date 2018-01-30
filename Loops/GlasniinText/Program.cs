using System;

namespace GlasniinText
{
    class Program
    {
        static void Main(string[] args)
        {
           string text =  Console.ReadLine();
            int sum = 0;

            for (int currentIndex = 0; currentIndex < text.Length - 1; currentIndex++)
            {
                char characters = text[currentIndex];
                
                switch(characters)
                {
                    case 'a':
                        sum += 1;
                       break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
