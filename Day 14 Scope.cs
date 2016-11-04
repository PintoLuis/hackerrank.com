using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
	
	public Difference (int[] array)
        {
            elements = array;
        }

        public int computeDifference()
        {
            Array.Sort(elements);
            maximumDifference = elements[elements.Length-1] - elements[0];

            return maximumDifference;
        }
	} 

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        Difference d = new Difference(a);
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}