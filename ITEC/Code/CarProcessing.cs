using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEC.Code
{
    public class CarProcessing
    {
        public static double Impact(string fueltype, double consumption, double kilometers)
        {
            double fuelemission;
            switch (fueltype.Trim().ToLowerInvariant())
            {
                case "diesel":
                    fuelemission = 26.5;
                    break;
                case "petrol":
                    fuelemission = 23.2;
                    break;
                case "autogas":
                    fuelemission = 19.0;
                    break;
                default:
                    return -1.0;
            }
            double impact = fuelemission*consumption*kilometers;
            return impact;
        }
    }
}