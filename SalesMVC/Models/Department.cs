using System;
using System.Collections.Generic;
using System.Linq;


namespace SalesMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public ICollection<Seller> Sellers  { get; set; } = new List<Seller>();


        public Department()
    {

    }

    public Department(int id, string deptName)
    {
        Id = id;
        DeptName = deptName;
    }

        public void AddSeller(Seller seller) {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
}
}
