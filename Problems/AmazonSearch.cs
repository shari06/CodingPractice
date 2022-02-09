using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Problems
{
    internal class AmazonSearch
    {
        public List<List<string>> searchSuggestions(List<string> repository, string customerQuery)
        {
            List<List<string>> result = new List<List<string>>();

            //mo
            //mou
            //mous
            //mouse

            for (int i = 2; i <= customerQuery.Length; i++)
            {
                var searchString = customerQuery.Substring(0, i);
                result.Add(repository.Where(a => a.ToLower().StartsWith(searchString.ToLower())).OrderBy(a => a, StringComparer.OrdinalIgnoreCase).Take(3).Select(a => a.ToLower()).ToList());
            }

            return result;
        }
    }
}
