using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToTheChase.Models
{
    public class Runner
    {
        [Required]
        public int RunnerID { get; set; }
        [Display(Name ="Runner Number")]
        public int RunnerNumber { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Pace in Minutes")]
        public int PaceMinutes { get; set; }
        [Display(Name = "Pace in Seconds")]
        public int PaceSeconds { get; set; }
        [Display(Name = "Van Type")]
        public Van Van;
        public List<int> Legs { get; set; }
    }
}