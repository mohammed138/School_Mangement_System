using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Duration:BaseClass
    {
        [Key]
        [Display(Name = "معرف المدة ")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "اسم الشهر ")]
        public string Name { get; set; }
    }
}
