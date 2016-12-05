using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Instrument
    {
        public int id { get; set; }
        public int BP_High { get; set; }
        public int BP_Low { get; set; }
        public int O2Sat { get; set; }
        public int Pulse { get; set; }
        
    }
}