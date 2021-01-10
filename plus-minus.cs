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

class Solution {

    const int PRECISION = 6;  
    
    static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(
            Console.ReadLine().Split(' '), 
            arrTemp => Convert.ToInt32(arrTemp));
        
        plusMinus(arr);
    }

    static void plusMinus(int[] arr) 
    {
        int positives = 0, negatives = 0, zeros = 0;
         
        foreach(var number in arr) 
        {
            if (number == 0)
                zeros++;
            else if (number > 0)
                positives++;
            else if (number < 0)
                negatives++;
        }
        
        ShowResult(new List<decimal>()
        {
            CalculateRatio(positives, arr.Length),
            CalculateRatio(negatives, arr.Length),
            CalculateRatio(zeros, arr.Length)
        });
    }
    
    static void ShowResult(IEnumerable<decimal> results)
    {
        foreach(var result in results)
            Console.WriteLine($"{result:N6}");
    }
    
    static decimal CalculateRatio(decimal dividend, decimal divisor)
    {
        if (divisor == 0) 
            throw new DivideByZeroException();
        
        return dividend / divisor;
    }
}
