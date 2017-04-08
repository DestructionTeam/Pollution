using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEC.Objects
{
    public class Data
    {
        public int idx { get; set; }    //monitoring station id
        public double aqi { get; set; }    //real time air quality information
        public Time time { get; set; }  //last time of check
        public City city { get; set; }  //city where it is done
        public string dominentpol { get; set; } //most dominant pollution 
        public Attribution[] attributions { get; set; }
        public Iaqi iaqi { get; set; }
    }
}