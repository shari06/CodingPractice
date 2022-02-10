using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    internal class Pairs_of_songs_with_total_durations_divisible_by_60
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            int result = 0;
            List<Input> haskKeys = new List<Input>();

            for (int i = 0; i < time.Length; i++)
            {
                int div = time[i] % 60;
                if (haskKeys.Where(a => a.Key == 60 - div).Any())
                {
                    result = result + haskKeys.Where(a => a.Key == 60 - div).Count();
                }

                if (div == 0)
                {
                    var val = haskKeys.Where(a => a.Key == 60 && a.Value == 0).Select(a => a.Value).FirstOrDefault();
                    haskKeys.Add(new Input { Key = 60, Value = val + 1 });

                }
                else
                {
                    var val = haskKeys.Where(a => a.Key == div && a.Value == 0).Select(a => a.Value).FirstOrDefault();
                    haskKeys.Add(new Input { Key = div, Value = val + 1 });

                }
            }
            return result;
        }

        public class Input
        {
            public int Key { get; set; }

            public int Value { get; set; }
        }
    }
}
