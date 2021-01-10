using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static int simpleArraySum(int[] ar) 
    {
        int total = 0;
        
        foreach(var num in ar)
            total += num;

        return total;
    }

    static void Main(string[] args) 
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
