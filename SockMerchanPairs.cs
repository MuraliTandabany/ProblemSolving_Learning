//John works at a clothing store.He has a large pile of socks that he must pair by color for sale.Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
//For example, there are  socks with colors.There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTryOut
{
    class SockMerchanPairs
    {         
            static int sockMerchant(int n, int[] ar)
            {
                int pairs = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    for (int j = i + 1; j < ar.Length; j++)
                    {
                        if (ar[i] == ar[j])
                        {
                            pairs = pairs + 1;
                            List<int> temp = ar.ToList();
                            temp.RemoveAt(j);
                            ar = temp.ToArray();
                            break;
                        }
                    }
                }
                return pairs;
            }

            static void SockMerchantMain(string[] args)
            {
                //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int n = Convert.ToInt32(Console.ReadLine());

                int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
                int result = sockMerchant(n, ar);
                Console.WriteLine(result);

                //textWriter.WriteLine(result);

                //textWriter.Flush();
                //textWriter.Close();
            }
    }
}
