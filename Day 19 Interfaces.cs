using System;

namespace hackerRank
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    class Calculator : AdvancedArithmetic
    {
        int sum = 0;
        public int divisorSum(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}