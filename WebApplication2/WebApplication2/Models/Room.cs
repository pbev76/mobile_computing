using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Room
    {
        public int ID {get; set;}
        public Tile[] hardware { get; set; }
    }
}