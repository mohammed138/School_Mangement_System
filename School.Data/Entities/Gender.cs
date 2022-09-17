using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Gender:BaseClass
    {

        [Key]
        [Display(Name = "Gender  Id ")]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Gender Name ")]
        public string Name { get; set; }
    }
}
