using GameStation.BLL.Abstract;
using GameStation.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStation.WebUI.ViewComponents
{
    public class SupplierListViewComponent : ViewComponent
    {
        private ISupplierService _supplierService;
        public SupplierListViewComponent(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        public ViewViewComponentResult Invoke()
        {
            var supplierList = _supplierService.GetAll();
            SupplierListViewModel model = new SupplierListViewModel()
            {
                Suppliers = supplierList
            };
            return View(model);
        }
    }
}
