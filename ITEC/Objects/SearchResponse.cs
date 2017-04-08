using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEC.Objects
{
    public class SearchResponse
    {
        public string status { get; set; }
        public SearchData[] data { get; set; }
        public string message { get; set; }
        public string keyword { get; set; }
    }
}