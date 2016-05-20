using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            
            var count = 0;
            var digits = n.ToString();
            foreach (var digit in digits)
            {
                if (Int32.Parse(digit.ToString()) != 0)
                {
                    if (n % Int32.Parse(digit.ToString()) == 0)
                    {
                        count += 1;   
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
