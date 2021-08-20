using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using SalesMVC.Models;
using SalesMVC.Data;

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

    }
}
