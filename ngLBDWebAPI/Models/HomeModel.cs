using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngLBDWebAPI.Models
{
    public class HomeModel
    {
        public string firstName { get; set; }
        public string mobile { get; set; }
        public string remarks { get; set; }
        public string email { get; set; }
        public bool locDubaiBusiness { get; set; }
        public bool locDubaiSilicon { get; set; }
        public bool budget400K700K { get; set; }
        public bool budget700K1000K { get; set; }
        public bool budget1000K1250K { get; set; }
        public bool budget1250K1500K { get; set; }
        public bool studio { get; set; }
        public bool oneBed { get; set; }
        public bool twoBed { get; set; }
        public bool retail { get; set; }
        public bool immed { get; set; }
        public bool months3to6 { get; set; }
        public bool months6to12 { get; set; }
        public bool months12to18 { get; set; }

    }
}