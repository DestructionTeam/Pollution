using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEC.Objects
{
    public class SearchData
    {
        public int uid { get; set; }
        public string aqi { get; set; }
        public Time time { get; set; }
        public Station station { get; set; }
        public double getAqi()
        {
            double a;
            if (double.TryParse(aqi, out a))
            {
                return double.Parse(aqi);
            }
            return -1;
        }
    }
}