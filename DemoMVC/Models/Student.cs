using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
        public int Mahocsinh { get; set; }
        public string Hoten { get; set; }
        public string Quequan { get; set; }
    }
}