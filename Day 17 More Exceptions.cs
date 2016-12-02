using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hackerRank
{
    class Solution
    {
        static void Main(String[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }

        class Calculator{

            public int power(int numero, int potencia)
            {
                int res;
                    if (numero < 0 || potencia < 0)
                        throw new Exception("n and p should be non-negative");
                    else
                    {
                        res=Convert.ToInt32( Math.Pow(numero, potencia));
                    }

                return res;
            }
        }
    }
}