using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        
        int dicSize = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        string row="";
        string name="";
        string number="";
        
        for(int x=0;x<dicSize;x++)
        {
           row = Console.ReadLine();
           int index = row.IndexOf(" "); 
           name = row.Substring(0, index); 
           number = row.Substring(index+1 );
            
           phoneBook.Add(name, number); 
        }
        
        for(int y=0;y<dicSize;y++)
        {
            string query = Console.ReadLine();
           if (phoneBook.ContainsKey(query))
           {
              Console.WriteLine(query + "=" + phoneBook[query]);
           } 
           else
              Console.WriteLine("Not found"); 
        }
        
        
        
    }
}