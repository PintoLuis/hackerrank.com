using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
		
		  // Declare second integer, double, and String variables.
        int x ;
        double dou ;
        String st ;
        // Read and save an integer, double, and String to your variables.
        x = Int32.Parse(Console.ReadLine());
        dou = Double.Parse(Console.ReadLine());
        st = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        int sum = i+x;
        Console.WriteLine(sum);
        
        // Print the sum of the double variables on a new line.


        double sum2 = d + dou;
        string result= string.Format("{0:0.0}", sum2 );
        Console.WriteLine(result);

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + st);
		
    }
}