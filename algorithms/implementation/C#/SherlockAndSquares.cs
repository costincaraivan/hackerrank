using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int testCases = Convert.ToInt32(Console.ReadLine());

        for(int testIndex = 0; testIndex < testCases; testIndex++)
        {
            string ab = Console.ReadLine();
            int a = Convert.ToInt32(ab.Split(' ')[0].ToString());
            int b = Convert.ToInt32(ab.Split(' ')[1].ToString());
                
            var count = 0;
            for(int index = 0; index < b; index++)
            {
                if ((index * index >= a) && (index * index <= b))
                {
                    count += 1    ;
                }
                if (index * index > b)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
