using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameStation.BLL.Abstract;
using GameStation.WebUI.Enums;
using GameStation.WebUI.Models;

namespace GameStation.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int supplierId = 1)
        {
            var randomProducts = _productService.GetAll().Where(x => x.SupplierID == supplierId).OrderBy(x => Guid.NewGuid()).Take(8).ToList();
            ProductListViewModel model = new ProductListViewModel()
            {
                Products = randomProducts
            };
            return View(model);
        }
    }
}