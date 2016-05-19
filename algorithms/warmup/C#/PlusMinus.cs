using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        float positives = 0;
        float negatives = 0;
        foreach (var _ in arr)
        {
            if (_ > 0)
            {
                    positives += 1;    
            }
            else if (_ < 0) 
            {
                negatives += 1;
            }
                
        }
        Console.WriteLine(string.Format("{0:0.000000}", positives / n));
        Console.WriteLine(string.Format("{0:0.000000}", negatives / n));
        Console.WriteLine(string.Format("{0:0.000000}", (n - positives - negatives) / n));
    }
}
