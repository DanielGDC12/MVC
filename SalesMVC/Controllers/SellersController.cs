using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Services;
using SalesMVC.Models;
using SalesMVC.Models.ViewModel;

namespace SalesMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellersServices _sellerServices;
        private readonly DepartmentsServices _departmentsServices;

        public SellersController(SellersServices sellerServices, DepartmentsServices departmentsServices )
        {
            _departmentsServices = departmentsServices;
            _sellerServices = sellerServices;
        }

        
        public IActionResult Index()
        {

            var list = _sellerServices.FindAll();
            return View(list);
        }


        public IActionResult Create()
        {
            var dept = _departmentsServices.FindAll();
            var viewModel = new SellerFormViewModel { Departments = dept };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller sr)
        {
            _sellerServices.Insert(sr);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _sellerServices.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerServices.Remove(id);
            return RedirectToAction(nameof(Index));
        }



        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _sellerServices.FindById(id.Value);

            if(obj == null)
            {
                return NotFound();

            }
            return View(obj);
        }




    }
}
