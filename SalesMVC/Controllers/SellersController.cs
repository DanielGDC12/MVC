using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Services;



namespace SalesMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellersServices _sellerServices;

        public SellersController(SellersServices sellerServices)
        {
            _sellerServices = sellerServices;
        }

        
        public IActionResult Index()
        {

            var list = _sellerServices.FindAll();
            return View(list);
        }
    }
}
