using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class SkillsType:BaseClass
    { 
        [Key]
        [Display(Name = "Skills Type Id ")]
        public int Id { get; set; }


        [Display(Name = "Skills Type Name ")]
        public string Name { get; set; }
    }
}
