namespace SalesMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        public Department(int id, string deptName)
        {
            Id = id;
            DeptName = deptName;

        }
    }
}
