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
        [Display(Name ="Leg Number")]
        public int LegNumber { get; set; }
        [Display(Name = "Leg Name")]
        public string LegName { get; set; }
        [Display(Name = "Leg Description")]
        public string LegDescrition { get; set; }
        [Display(Name ="Lenght (mi)")]
        public double LengthInMiles { get; set; }
        public Exchange StartExchange { get; set; }
        public Exchange EndExchange { get; set; }
        [Display(Name ="Leg Difficulty")]
        public LegDifficulty LegDifficulty { get; set; }
        public int AssignedRunner { get; set; }
    }
}