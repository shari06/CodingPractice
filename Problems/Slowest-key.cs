using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    internal class Slowest_key
    {
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            char value = '\0';
            int[] keyPressTime = new int[releaseTimes.Length];
            int longestKeyPress = 0;
            for (int i = 0; i < releaseTimes.Length; i++)
            {
                if (i == 0)
                {
                    keyPressTime[i] = releaseTimes[i];
                    longestKeyPress = releaseTimes[i];
                }
                else
                {
                    int keyPValue = releaseTimes[i] - releaseTimes[i - 1];
                    keyPressTime[i] = keyPValue;
                    if (keyPValue > longestKeyPress)
                    {
                        longestKeyPress = keyPValue;
                    }
                }
            }

            if (keyPressTime.Where(a => a == longestKeyPress).Count() == 1)
            {
                int index = Array.IndexOf(keyPressTime, longestKeyPress);
                value = keysPressed[index];
            }
            else
            {
                List<char> lstchar = new List<char>();
                for (int i = 0; i < keyPressTime.Length; i++)
                {
                    if (keyPressTime[i] == longestKeyPress)
                    {
                        lstchar.Add(keysPressed[i]);
                    }
                }
                value = lstchar.OrderByDescending(a => a).FirstOrDefault();
            }

            return value;
        }
    }
}
