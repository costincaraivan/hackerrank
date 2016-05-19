using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        
        // 12AM = 00:00
        // 12PM = 12:00
        // 01PM = 13:00

        var meridian = time.Substring(time.Length - 2, 2);
        time = time.Substring(0, time.Length - 2);
        var hourString = time.Split(':')[0];
        var minute = time.Split(':')[1];
        var second = time.Split(':')[2];
        var hour = int.Parse(hourString);
      
        if (meridian == "PM")
        {
            if (hour != 12)
            {
                hour += 12;
            }
        }
        else
        {
            if (hour == 12)
            {
                hour = 0;
            }
        }
            
        Console.WriteLine(string.Format("{0:00}:{1}:{2}", hour, minute, second));

    }
}
