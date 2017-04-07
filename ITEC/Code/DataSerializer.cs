using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITEC.Objects;
using Newtonsoft.Json;

namespace ITEC.Code
{
    public static class DataSerializer
    {
        public static Response GetResponse(string json)
        {
            Response r = JsonConvert.DeserializeObject<Response>(json);
            return r;
        }
    }
}