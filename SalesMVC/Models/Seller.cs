using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate{ get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public int DepartmentID { get; set; }
        public ICollection<SaleRecord> SaleRecord { get; set; } = new List<SaleRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SaleRecord sr)
        {
            SaleRecord.Add(sr);
        }

        public void RemoveSales(SaleRecord sr)
        {
            SaleRecord.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return SaleRecord.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
