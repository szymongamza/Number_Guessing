using System;

namespace Number_Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            string z;
            int a = 0; // First number of between
            int b = 100; // Last number of between
            int i = 0; // Iteration counter
            Random random = new();
            x = random.Next(a, b+1); // +1 because <maxValue
            bool win = false;
            bool parse = false;
            Console.WriteLine($"Try guess number from {a} to {b}");
            do
            {
                do
                {
                    z = Console.ReadLine();
                    parse = Int32.TryParse(z, out y);
                    if (parse == false)
                    {
                        Console.WriteLine("USE NUMBER!");
                    }
                    else
                    {
                        y = Int32.Parse(z);
                    }
                } while (parse == false);



                if (y < a || y > b)
                {
                    Console.WriteLine($"Number should be between {a} and {b}");
                }
                else
                {
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
