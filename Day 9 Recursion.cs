using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
       
        string n = Console.ReadLine();
        Console.WriteLine(factorial(Convert.ToInt32(n)));
          
    }
    
    public static int factorial(int number)
    {
        if (number <= 1)
            return 1;
        else
            return number * factorial(number - 1);
    }
}