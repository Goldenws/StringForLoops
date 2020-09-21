using System;
using System.Diagnostics.Tracing;

namespace StringForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string helloWorld = "Hello World";
            Console.WriteLine(helloWorld[0]);
            Console.WriteLine(helloWorld[6]);
            int stringLength = helloWorld.Length;
            Console.WriteLine($"Your text is {stringLength} symbols long");
            /*write a program that counts "0" letters in a string*/
            char searchCriteria = 'o';
            int counter = 0;
            foreach(char letter in helloWorld)
            {
                if(letter == searchCriteria)
                {
                    counter = counter + 1;
                }

                Console.WriteLine($"There are {counter} 0s in  your text");
            }
        
        }
    }
}
