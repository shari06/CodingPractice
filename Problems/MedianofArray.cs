using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    public class MedianofArray
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            Double result = 0;
            List<int> vs = new List<int>();
            vs.AddRange(nums1);
            vs.AddRange(nums2);
            vs = vs.OrderBy(a => a).ToList();
            if (vs.Count % 2 == 0)
            {
                int median = vs.Count / 2;
                result = ((double)vs[median - 1] + (double)vs[median]) / 2;
            }
            else
            {
                int median = vs.Count / 2;
                result = vs[median];
            }
            return result;

        }
    }
}
