using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution 
{
    static void Main(string[] args) 
    {
        var input = Console.ReadLine();
        
        int[] arr = Array.ConvertAll(
            input.Split(' '), 
            arrTemp => Convert.ToInt32(arrTemp));
            
        miniMaxSum(arr);
    }
    
    static void miniMaxSum(int[] arr) 
    {
        Array.Sort(arr);
        long minSum = arr.Take(4).Sum(num => (long)num);
        
        Array.Reverse(arr);
        long maxSum = arr.Take(4).Sum(num => (long)num);
        
        Console.WriteLine($"{minSum} {maxSum}");
    }
}
