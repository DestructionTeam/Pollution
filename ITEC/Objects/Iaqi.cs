using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEC.Objects
{
    public class Iaqi
    {
        public Value h { get; set; }    //humidity
        public Value o3 { get; set; }   //ozone value
        public Value pm10 { get; set; } //pm10 pollution
        public Value pm25 { get; set; } //pm2.5 pollution
        public Value p { get; set; }    //pressure
        public Value t { get; set; }    //temperature
    }
}