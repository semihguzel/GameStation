using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameStation.BLL.Abstract;
using GameStation.WebUI.Enums;

namespace GameStation.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            ViewBag.Steam = _productService.GetAll().Where(x => x.SupplierID == Convert.ToInt32(SupplierEnum.Steam)).OrderBy(x => Guid.NewGuid()).Take(3);
            //ViewBag.Origin = _productService.GetAll().Where(x => x.SupplierID == Convert.ToInt32(SupplierEnum.Origin)).OrderBy(x => Guid.NewGuid()).Take(6);
            return View();
        }
    }
}