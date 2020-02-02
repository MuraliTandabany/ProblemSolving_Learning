using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTryOut
{
    class CountingValleys
    {
        static int countingValleys(int n, string s)
        {
            int valleys = 0;
            int currentSeaLevel = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'D')
                {
                    if (currentSeaLevel == 0)
                        valleys += 1;
                    currentSeaLevel -= 1;
                }
                else if (s[i] == 'U')
                {
                    currentSeaLevel += 1;
                }
            }
            return valleys;
        }

        static void CountingValleysMain(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
