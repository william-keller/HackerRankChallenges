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

    static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }

    static void staircase(int size) 
    {
        string spacesString = "", sharpsString = "";
        
        for (int spaces = (size - 1); spaces >= 0; spaces--) 
        {
            spacesString = new String(' ', spaces);
            sharpsString =  new String('#', size - spaces);
            
            Console.WriteLine(
                string.Format("{0}{1}", spacesString, sharpsString)
            );
        }
    }
}
