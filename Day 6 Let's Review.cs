using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int s = Int32.Parse(Console.ReadLine());
        
        for(int x=1;x<=s;x++)
        {    
            String even = "";
            String odd = "";
            String word = Console.ReadLine();
            
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 1)
                {
                   even += word[i];
                }
                else
                {
                   odd += word[i];
                }
            }
            Console.WriteLine(odd + " " + even);
        }
    }
}