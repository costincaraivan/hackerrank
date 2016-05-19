using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            
            var length = n;
            while(length % 3 !=0)
            {
                length -= 5;
            }
            if(length < 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(string.Format("{0}{1}",
                                                string.Join("", Enumerable.Repeat("5", length)), 
                                                string.Join("", Enumerable.Repeat("3", (n - length)))));
            }
        }
    }
}
