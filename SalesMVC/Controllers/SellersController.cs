using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Services;
using SalesMVC.Models;

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


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller sr)
        {
            _sellerServices.Insert(sr);
            return RedirectToAction(nameof(Index));
        }

    }
}
