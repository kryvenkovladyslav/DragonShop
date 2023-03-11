using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public sealed class TobaccoBL
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public double Weight { get; set; }

        public string Leaf { get; set; }

        public string Package { get; set; }

        public bool IsSmoky { get; set; }

        public bool IsMixed { get; set; }

        public bool IsMint { get; set; }

        public bool IsSweet { get; set; }

        public bool IsIced { get; set; }


        public long ManufacturerID { get; set; }
        public ManufacturerBL Manufacturer{ get; set; }
    }
}
