using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        public string TenLop { get; set; }
        public string MaLop { get; set; }

    }
}