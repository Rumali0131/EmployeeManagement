using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementWeb.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public String Position { get; set; }
        public int Salary { get; set; }
        public String? ContactNo { get; set; }
    }
}
