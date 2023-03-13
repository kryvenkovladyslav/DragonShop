using AutoMapper;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.ViewModels;

namespace Web.Controllers
{
    public sealed class CartController : Controller
    {
        private IProductService productService;
        private IList<ProductViewModel> products;

        public CartController(IProductService productService, IList<ProductViewModel> products)
        {
            this.products = products;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(long id)
        {
            var productBL = await productService.GetProduct(id, true);

            MapperConfiguration configuration = new MapperConfiguration(config =>
            {
                config.CreateMap(typeof(ProductBL), typeof(ProductViewModel));
                config.CreateMap(typeof(TobaccoBL), typeof(TobaccoViewModel));
            });

            Mapper mapper = new Mapper(configuration);
            var productViewModel = mapper.Map<ProductBL, ProductViewModel>(productBL);

            products.Add(productViewModel);

            return RedirectToAction(actionName: "Manufacturers", controllerName: "Home");
        }
    }
}
