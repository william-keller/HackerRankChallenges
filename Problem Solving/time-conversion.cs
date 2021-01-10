using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static string timeConversion(string s) 
    {
        var datetime = Convert.ToDateTime(s);
        return datetime.ToString("HH:mm:ss");
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
