using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEC.Objects
{
    public class Iaqi
    {
        public Value h { get; set; }    //hydrogen pollution
        public Value o3 { get; set; }   //o3 value
        public Value pm10 { get; set; } //pm10 pollution
        public Value pm25 { get; set; } //pm2.5 pollution
        public Value p { get; set; }    //phosporus pollution
        public Value t { get; set; }
    }
}