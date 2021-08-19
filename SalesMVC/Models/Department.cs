

namespace SalesMVC.Models
{
    public class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public  Department(int id , string name)
        {
            Id = id;
            Name = name;
        }

    }
}
