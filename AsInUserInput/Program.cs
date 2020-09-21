using System;

namespace AsInUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name;
            int counter = 0;
            char searchcriteria = 'a';
            name = Console.ReadLine();
            foreach(char letter in name)
            {
                if(letter == searchcriteria)
                {
                    counter = counter + 1;
                }

               


            }

            if (counter > 0)
            {
                Console.WriteLine($"There are {counter} As in your name.");
            }
            else
            {
                Console.WriteLine("There are no As in your name");
            }


        }
    }
}
