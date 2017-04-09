using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITEC.Objects;

namespace ITEC.Code
{
    public class CarProcessing
    {
        public static double Impact(CarConsumption car)
        {
            double fuelemission;
            switch (car.FuelType.Trim().ToLowerInvariant())
            {
                case "diesel":
                    fuelemission = 26.5;
                    break;
                case "petrol":
                    fuelemission = 23.2;
                    break;
                case "gas":
                    fuelemission = 19.0;
                    break;
                default:
                    return -1.0;
            }
            double impact = (fuelemission*car.Consumption*car.Km)/100.0;
            return impact;
        }
    }
}