using CodingPractice.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int truckSize = 4;
            int[][] boxTypes = new int[][] { 
                            new int[] { 1, 3 },
                            new int[] { 2, 2 },
                            new int[] { 3, 1 }};
            Maximum_units_on_a_truck maximum_Units_On_A_Truck = new Maximum_units_on_a_truck();
            maximum_Units_On_A_Truck.MaximumUnits(boxTypes, truckSize);
        }
    }
}
