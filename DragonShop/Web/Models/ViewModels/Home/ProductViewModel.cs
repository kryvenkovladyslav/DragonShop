using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.ViewModels
{
    public class ProductViewModel
    {
        public long ID { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int Discount { get; set; }
        public string ImagePath { get; set; }
        public string DescriptionPath { get; set; }

        public TobaccoBL Tobacco { get; set; }
    }
}
