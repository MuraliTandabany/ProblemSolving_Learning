//Given a square matrix, calculate the absolute difference between the sums of its diagonals.
//For example, the square matrix  is shown below:
//1 2 3
//4 5 6
//9 8 9  
//The left-to-right diagonal = .The right to left diagonal = .Their absolute difference is .
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
