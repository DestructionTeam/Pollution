using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEC.Objects
{
    public class Data
    {
        public int idx { get; set; } //monitoring station id
        public int aqi { get; set; } //real time air quality information
        public Time time { get; set; } //last time of check
        public City city { get; set; }

        

    }
}