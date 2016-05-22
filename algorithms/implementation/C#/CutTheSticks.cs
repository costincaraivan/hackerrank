using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    int positiveMin(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            return Int32.MinValue;
        }
        var min = Int32.MaxValue;
        foreach(var element in array)
        {
            if (min > element && element > 0)
            {
                min = element;
            }
        }
        return min;
    }
    
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        var count = arr.Length;
        while (count != 0)
        {
            var solution = new Solution();
            
            var min = solution.positiveMin(arr);
            var shortened = 0;
                       
            for(var index = 0; index < arr.Length; index++)
            {
                if (arr[index] > 0)
                {
                    if (arr[index] - min <= 0)
                    {
                        count -= 1;
                    }
                    shortened += 1;
                }
                arr[index] -= min;
            }
            Console.WriteLine(shortened);          
        }
    }
}
