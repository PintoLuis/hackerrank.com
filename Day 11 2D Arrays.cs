using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' '); 
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        
        int total;
        int totalMax=-Int32.MaxValue;

        for(int x = 0; x < arr.Length; x++)
        {
            
            for(int y = 0;y < arr.Length; y++)
            {
                if(y+3<= arr.Length && x+3<= arr.Length)
                {
                    int a, b, c, d, e, f, g;
                    
                    a = arr[x][y];
                    b = arr[x][y+1];
                    c = arr[x][y+2];
                    d = arr[x+1][y+1];
                    e = arr[x+2][y];
                    f = arr[x+2][y+1];
                    g = arr[x+2][y+2];

                    total = a + b + c + d + e + f + g;
                    if (total > totalMax)
                        totalMax = total;
                }
            }
        }
        
        Console.WriteLine(totalMax);
    }
}
