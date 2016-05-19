using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);
            
            var arrivedOnTime = 0;
            foreach(var studentArrival in a)
            {
                if(studentArrival <= 0)
                {
                    arrivedOnTime += 1;
                }
            }
            if (arrivedOnTime >= k)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");                
            }
        }
    }
}
