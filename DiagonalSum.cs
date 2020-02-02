//Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros.Print the decimal value of each fraction on a new line.
//Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.
//For example, given the array  there are  elements, two positive, two negative and one zero.Their ratios would be , and.It should be printed as
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTryOut
{
    class DiagonalSum
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int pDSum = 0;
            int sDSum = 0;
            int i = 0;
            int j = arr.Count() - 1;
            foreach (var row in arr)
            {
                var b = row.ToArray();
                pDSum = pDSum + row[i];
                sDSum = sDSum + row[j];
                i++;
                j--;
            }
            return System.Math.Abs(pDSum - sDSum);
        }
        static void DiagonalMain(string[] args)
        {
            //TextWriter textWriter = new StreamWriter("C:\\", true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalSum.diagonalDifference(arr);
            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
