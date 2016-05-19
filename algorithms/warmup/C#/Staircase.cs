using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            var line = "";
            for (int j = 0; j < n; j++)
            {
                if (j < (n - i - 1))
                {
                    line = line + " ";
                }
                else
                {
                    line = line + "#";
                }
            }
            Console.WriteLine(line);
        }
    }
}
