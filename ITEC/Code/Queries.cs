using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITEC.Objects;

namespace ITEC.Code
{
    public static class Queries
    {
        public static SearchData GetHighestPolluted(SearchResponse response)
        {
            double maxaqi = response.data.Max(m => m.getAqi());
            SearchData data = response.data.FirstOrDefault(m=>m.getAqi().Equals(maxaqi));
            return data;
        }

        public static List<SearchData> SortByPollution(SearchResponse response)
        {
            List<SearchData> sorted = response.data.OrderByDescending(m => m.getAqi()).ToList();
            foreach (var listdata in sorted)
            {
                if (listdata.getAqi().Equals(-1))
                {
                    sorted.Remove(listdata);
                }
            }
            return sorted;
        }

        public static SearchData GetLowestPolluted(SearchResponse response)
        {
            double minaqi = response.data.Min(m => m.getAqi());
            SearchData data = response.data.FirstOrDefault(m => m.getAqi().Equals(minaqi));
            return data;
        }
    }
}