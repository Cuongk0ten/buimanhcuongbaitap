using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Employeee : Person
    {
        public string EmployeeeID { get; set; }
        public string SDT { get; set; }
    }

}