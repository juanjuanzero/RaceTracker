using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToTheChase.Models
{
    public class Exchange
    {
        public int ExchangeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsMajorExchange { get; set; }

    }
}