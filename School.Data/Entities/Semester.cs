using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Semester:BaseClass
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="نوع الفصل الدراسي")]
        public string Name { get; set; }
    }
}
