//Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros.Print the decimal value of each fraction on a new line.

//Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.

//For example, given the array  there are  elements, two positive, two negative and one zero.Their ratios would be , and.It should be printed as
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTryOut
{
    class PlusMinusSolution
    {
        static void plusMinus(int[] arr)
        {
            int pos = 0;
            int neg = 0;
            int zero = 0;
            foreach (var a in arr)
            {
                if (a > 0)
                {
                    pos = pos + 1;
                }
                else if (a < 0)
                {
                    neg = neg + 1;
                }
                else if (a == 0)
                {
                    zero = zero + 1;
                }
            }
            decimal posR = ((decimal)pos) / arr.Count();
            decimal negR = ((decimal)neg) / arr.Count();
            decimal zeroR = ((decimal)zero) / arr.Count();
            Console.WriteLine(posR.ToString());
            Console.WriteLine(negR.ToString());
            Console.WriteLine(zeroR.ToString());

        }

        static void PlusMinusMain(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }
 }
