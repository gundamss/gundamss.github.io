using System;

namespace solo_prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int rannum = randomGenerator.Next(1,9);
            int start_num = -1;
            foreach (string word in words)
            while (start_num != rannum)
            {
                Console.Write("What is your guess? ");
                guess_num = int.Parse(Console.ReadLine());

                if (rannum > guess_num)
                {
                    Console.WriteLine("Higher");
                }
                else if (rannum < guess_num)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
        }
    }
}
