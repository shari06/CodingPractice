using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    internal class Maximum_average_pass_ratio
    {
        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            List<Node> tempnodes = new List<Node>();

            foreach (var cl in classes)
            {
                Node node = new Node(); ;
                node.PassStudents = cl[0];
                node.TotalStudents = cl[1];

                double val = ((double)(cl[0] + 1) / (cl[1] + 1));
                double val2 = ((double)cl[0] / cl[1]);

                node.Difference = val - val2;
                tempnodes.Add(node);
            }
            var maxRatio = tempnodes.OrderByDescending(a => a.Difference).Select(a => a.Difference).FirstOrDefault();
            foreach (var node in tempnodes)
            {
                if (node.Difference == maxRatio)
                {
                    node.PassStudents++;
                    node.TotalStudents++;
                    break;
                }
            }

            for (int i = 1; i < extraStudents; i++)
            {
                foreach (var cl in tempnodes)
                {
                    double val = ((double)(cl.PassStudents + 1) / (cl.TotalStudents + 1));
                    double val2 = ((double)cl.PassStudents / cl.TotalStudents);
                    cl.Difference = val - val2;
                }

                if (tempnodes.Any())
                {
                    var maxRatioTemp = tempnodes.OrderByDescending(a => a.Difference).Select(a => a.Difference).FirstOrDefault();

                    foreach (var node in tempnodes)
                    {
                        if (node.Difference == maxRatioTemp)
                        {
                            node.PassStudents++;
                            node.TotalStudents++;
                            break;
                        }
                    }
                }
            }

            double ratio = 0;

            foreach (var cl in tempnodes)
            {
                double val2 = ((double)cl.PassStudents / cl.TotalStudents);
                ratio += val2;
            }

            return ratio / tempnodes.Count();
        }

    }

    public class Node
    {
        public double Difference { get; set; }

        public int PassStudents { get; set; }

        public int TotalStudents { get; set; }

    }
}
