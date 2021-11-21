using System;

namespace ConsoleApp3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (double x = -Math.PI / 4; x <= 7 * Math.PI / 4; x += 0.2)
                {
                    double y = 0;
                    if (x < 0) y = x * x;
                    else if (x > 2.5) y = Math.Cos(2.3 * x - 1);
                    else y = 1 + 3 * Math.Log(Math.Abs(1 - x * x * x));
                    Console.WriteLine("|{0,13:F1}|{1,14:F2}|", x, y);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
