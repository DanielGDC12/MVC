using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Models;
using SalesMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace SalesMVC.Services
{
    public class SellersServices
    {
        private readonly SalesMVCContext _context;

        public SellersServices(SalesMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
          return   _context.Seller.ToList();
        }

        public void Insert(Seller sr)
        {
            _context.Add(sr);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
             return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
             
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

    }
}
