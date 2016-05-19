using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            
            var height = 1;
    
            for(var index = 0; index < n / 2; index++)
            {
                height = height * 2 + 1;
            }
            if (n % 2 == 1)
            {
                height = height * 2;
            }

            Console.WriteLine(height);
        }
    }
}
