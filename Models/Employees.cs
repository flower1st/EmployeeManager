using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManager.Models
{
    [Table("Employees")]
    public class Employees
    {
        [Required(ErrorMessage = "Employee ID is required")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Eployee last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Eployee first name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Eployee title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Eployee birth date is required")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Eployee hire date is required")]
        public DateTime HireDate { get; set; }
        [Required(ErrorMessage = "Eployee country is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Eployee notes is required")]
        public string Notes { get; set; }
    }
}
