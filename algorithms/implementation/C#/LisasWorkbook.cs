using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections;

class Solution {
    static void Main(String[] args) {
        
        string[] firstLine = Console.ReadLine().Split(' ');
        
        int problemsPerPage = Convert.ToInt32(firstLine[1]);
        int[] problems = Array.ConvertAll(Console.ReadLine().Split(' '),Int32.Parse);
        
        var temporaryWorkbook = new ArrayList();
        for(int index = 0; index < problems.Length; index++) 
        {
             temporaryWorkbook.Add(Enumerable.Range(1, problems[index])
                .Select((val, idx) => new { Value = val, Index = idx })
                .GroupBy(elem => elem.Index / problemsPerPage)
                .Select(myGroup => myGroup.Select(elem => elem.Value).ToArray())
                .ToArray());
        }
        
        var workbook = new ArrayList();
        foreach(var pageGroup in temporaryWorkbook)
        {
            foreach(var page in (Int32[][])pageGroup) 
            {
                workbook.Add(page);
            }
        }
        
        int count = 0;
        for(int index = 0; index < workbook.Count; index++)
        {
            if(Array.IndexOf((Int32[])workbook[index], index + 1) != -1)
            {   
                count += 1;
            }
        }
        Console.WriteLine(count);
    }
}
