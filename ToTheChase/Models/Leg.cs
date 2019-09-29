using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToTheChase.Models
{
    public class Leg
    {
        public int LegID { get; set; }
        public int LegNumber { get; set; }
        public string LegName { get; set; }
        public string LegDescrition { get; set; }
        [Display(Name ="Lenght (mi)")]
        public double LengthInMiles { get; set; }
        public Exchange StartExchange { get; set; }
        public Exchange EndExchange { get; set; }
    }
}