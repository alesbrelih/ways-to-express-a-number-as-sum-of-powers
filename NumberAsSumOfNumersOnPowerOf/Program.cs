using System;

namespace NumberAsSumOfNumersOnPowerOf
{
    class Program
    {
            
        public static int CountWaysRecursive(int number, int power, int currentNum = 1)
        {
            int val = number - (int)Math.Pow(currentNum, power);

            if (val < 0)
            {
                return 0;
            }
            if (val == 0)
            {
                return 1;
            }

            return CountWaysRecursive(val, power, currentNum + 1) + CountWaysRecursive(number, power, currentNum + 1);
        }
        public static int CountWays(int number, int power)
        {
            return CountWaysRecursive(number, power);
        }

        static void Main(string[] args)
        {
            int result = CountWays(500, 2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
