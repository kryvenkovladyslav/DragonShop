using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.ViewModels
{
    public sealed class TobaccoViewModel
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

        public ProductBL Product { get; set; }

    }
}
