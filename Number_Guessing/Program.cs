using System;

namespace Number_Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            int a = 1;
            int b = 10;
            Random random = new();
            x = random.Next(a, b+1); // +1 because <maxValue
            bool win = false;
            Console.WriteLine($"Try guess number from {a} to {b}");
            do
            {
                y = Int32.Parse(Console.ReadLine());
                if (y > x)
                {
                    Console.WriteLine("Wrong number! Try lower");
                }
                else if (y < x)
                {
                    Console.WriteLine("Wrong number! Try higher");
                }
                else if (y == x)
                {
                    Console.WriteLine("Right number! You Won");
                    win = true;
                }
            } while (win == false);
            Console.WriteLine();
            Console.WriteLine("Thank you for playing my game!");
            Console.WriteLine("Feel free to share your experience on PM :)");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
