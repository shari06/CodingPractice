using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    public class ContainsDuplicate
    {
        public bool containsDuplicate(int[] nums)
        {
            bool result = false;
            if (nums.Length != nums.Distinct().Count())
            {
                result = true;
            }
            return result;
        }
    }
}
