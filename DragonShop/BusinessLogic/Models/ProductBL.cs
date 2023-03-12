using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
    public sealed class ProductBL
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int Discount { get; set; }
        public string ImagePath { get; set; }
        public string DescriptionPath { get; set; }

        public TobaccoBL Tobacco { get; set; }

    }
}
