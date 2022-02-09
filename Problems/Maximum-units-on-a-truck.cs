using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    internal class Maximum_units_on_a_truck
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int result = 0;
            try
            {
                int boxCount = 0;
                
                foreach (var boxType in boxTypes.OrderByDescending(row => row[1]))
                {
                    if (boxCount + boxType[0] <= truckSize)
                    {
                        result += boxType[0] * boxType[1];
                        boxCount += boxType[0];
                    }
                    else if (boxCount < truckSize)
                    {
                        for (int i = 0; i <= boxType[0]; i++)
                        {
                            result += boxType[1];
                            boxCount++;
                            if (boxCount >= truckSize)
                            {
                                break;
                            }
                        }
                    }
                    else if (boxCount >= truckSize)
                    {
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
