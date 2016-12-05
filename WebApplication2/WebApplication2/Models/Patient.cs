using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Patient
    {
        public int id { get; set; }
        public int bleID { get; set; }
        public string history { get; set; }
        public string name { get; set; }
        public int BP_High { get; set; }
        public int BP_Low { get; set; }
        public int Pulse { get; set; }
        public int O2Sat { get; set; }
        public int[] ECG { get; set; }
        public int ecg_dt { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public Boolean currentPatient { get; set; }
    }
}