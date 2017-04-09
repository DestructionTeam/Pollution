using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITEC.Objects
{
    public class CarConsumption
    {
        [Required]
        public string FuelType { get; set; }
        [Required]
        public double Consumption { get; set; }
        [Required]
        public double Km { get; set; }
    }
}