using System;

namespace Number_Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            string z;
            int a = 0;
            int b = 100;
            int i = 0;
            Random random = new();
            x = random.Next(a, b+1); // +1 because <maxValue
            bool win = false;
            Console.WriteLine($"Try guess number from {a} to {b}");
            do
            {
                do
                {
                    z = Console.ReadLine();
                    if (!Int32.TryParse(z, out y))
                    {
                        Console.WriteLine("USE NUMBER!");
                        y = -1;
                    }
                    else
                    {
                        y = Int32.Parse(z);
                    }
                } while (y == -1);

                i++;

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
                    Console.WriteLine($"Right number! You Won on {i} attempt");
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
