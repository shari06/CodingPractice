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

            Console.WriteLine(" Problems \n 1 for Truck Size \n 2 for Amazon Search \n 3 for Slowest key \n 4 for Maximum pass average ratio");
            var keyValue = Console.ReadLine();

            if (keyValue == "1")
            {
                int truckSize = 4;
                int[][] boxTypes = new int[][] {
                                new int[] { 1, 2 },
                                new int[] { 2, 2 },
                                new int[] { 3, 1 }};
                Maximum_units_on_a_truck maximum_Units_On_A_Truck = new Maximum_units_on_a_truck();
                maximum_Units_On_A_Truck.MaximumUnits(boxTypes, truckSize);
            }
            else if (keyValue == "2")
            {
                AmazonSearch amazonSearch = new AmazonSearch();
                amazonSearch.searchSuggestions(new List<string>() { "abbS","abc"
                ,"Abs"
                ,"bcs"
                ,"bdsa"
                ,"cdde"
                ,"rgb"
                ,"yjmm"
                ,"xxmm"
                ,"zeee" }, "abbs");
            }
            else if (keyValue == "3")
            {
                Slowest_key slowest_Key = new Slowest_key();
                int[] sampleValue = { 9, 29, 49, 50 };
                slowest_Key.SlowestKey(sampleValue, "cbcd");
            }
            else if (keyValue == "4")
            {

                int[][] stdList = new int[][] {
                                new int[] { 1, 2 },
                                new int[] { 3, 5 },
                                new int[] { 2, 2 }};
                Maximum_average_pass_ratio maximum_Average_Pass_Ratio = new Maximum_average_pass_ratio();
                maximum_Average_Pass_Ratio.MaxAverageRatio(stdList, 2);
            }
        }
    }
}
