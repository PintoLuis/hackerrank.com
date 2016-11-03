using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int remainder = 0;
        List<int> list = new List<int>();
        int Seq = 1;
        int maxSeq = 1;

        while (n > 0)
        { 
            remainder = n % 2;
            n = n / 2;

            list.Add(remainder);
        }

        for(int i = 1; i < list.Count; i++)
        {
            if (list[i - 1] == 1 && list[i] == 1)
            {
                Seq++;
                if (Seq > maxSeq)
                    maxSeq = Seq;

            }
            else
                Seq = 1;
        }
        
        Console.WriteLine(maxSeq);
    }
}
