using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    public class ConnectingRopes
    {


        public int TotalCost(int[] arr)
        {
            List<int> list = new List<int>();
            var vals = arr.Length == 1 ? arr.ToList() : TotalCost(arr, list);
            return vals.Sum();
        }

        private List<int> TotalCost(int[] arr, List<int> cal)
        {
            Array.Sort(arr);
            if (arr.Length > 1)
            {
                int cost = arr[0] + arr[1];
                arr[1] = cost;
                var v = arr.Length == 1 ? arr : arr.Skip(1).ToArray();
                cal.Add(cost);
                TotalCost(v, cal);
            }
            return cal;
        }
    }
}
