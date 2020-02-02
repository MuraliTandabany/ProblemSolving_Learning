//Problem Statement - Gary is an avid hiker.He tracks his hikes meticulously, paying close attention to small details like topography.During his last hike he took exactly  steps.For every step he took, he noted if it was an uphill, , or a downhill, step.Gary's hikes start and end at sea level and each step up or down represents a  unit change in altitude. We define the following terms:
//A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
//A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
//Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.
//For example, if Gary's path is , he first enters a valley  units deep. Then he climbs out an up onto a mountain  units high. Finally, he returns to sea level and ends his hike.
﻿using System;
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
