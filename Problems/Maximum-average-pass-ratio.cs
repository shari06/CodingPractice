using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    internal class Maximum_average_pass_ratio
    {

        // class Solution
        //        {
        // 2public:
        // 3    double diff(int a, int b)
        //            {
        //                4        return (double)(a + 1) / (b + 1) - (double)a / b;
        //                5    }
        // 6    double maxAverageRatio(vector<vector<int>>& classes, int extraStudents)
        //            {
        //                7        auto cmp = [&](const pair<int, int>&a, const pair<int, int>&b) { return diff(a.first, a.second) < diff(b.first, b.second); };
        //                8        priority_queue < pair<int, int>, vector<pair<int, int>>, decltype(cmp) > pq(cmp);
        //                9        for (auto c : classes)
        //                {
        //                    10            pq.push({ c[0], c[1]});
        //                11        }
        //12        for (int i=0; i<extraStudents; i++) {
        //13            auto[p, t] = pq.top(); pq.pop();
        //14            pq.push({p+1, t+1});
        //15        }
        //16        double ans = 0;
        //17        while (pq.size()) {
        //18            auto p = pq.top(); pq.pop();
        //19            ans += (double) p.first/p.second;
        //20        }
        //21        return ans / classes.size();
        //22    }
        //23};
        //    }

        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            


            return double.MinValue;
        }

    }
}
