//Consider a staircase of size :
//   #
//  ##
// ###
//####
//Observe that its base and height are both equal to, and the image is drawn using # symbols and spaces. The last line is not preceded by any spaces.
//Write a program that prints a staircase of size.
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

namespace CodeTryOut
{
    class Staircase
    {

        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var ash = new string('#', i);
                Console.WriteLine(string.Format("{0}", ash.PadLeft(n)));
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
