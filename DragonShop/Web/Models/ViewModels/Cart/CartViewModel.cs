using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.ViewModels
{
    public sealed class CartViewModel 
    {
        private List<ProductViewModel> products;

        public CartViewModel()
        {
            products = new List<ProductViewModel>();
        }


    }
}
