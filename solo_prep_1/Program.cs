using System;

namespace solo_prep_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do{
                Console.Write("Do you want to continue?");
                input = Console.ReadLine();

            }while (input =="yes");
            string i = input;
            for (int i = 2; i<=20; i=i+2)
                {
                    Console.WriteLine(i);
                }
            Console.Write("What is your last name?");
            string last = Console.ReadLine();           
            Console.WriteLine($"Your name is ,{last}");
        }
    }
}
