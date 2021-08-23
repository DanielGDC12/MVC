using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMVC.Data;
using SalesMVC.Models;

namespace SalesMVC.Services
{
    public class DepartmentsServices
    {
        private readonly SalesMVCContext _context;

        public DepartmentsServices(SalesMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.DeptName).ToList();
        }

        public void Insert(Department dpt)
        {
            _context.Add(dpt);
            _context.SaveChanges();
        }
    }
}
