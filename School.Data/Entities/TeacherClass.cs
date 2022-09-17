 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
     
    public class TeacherClass
    { 
        public Class Class { get; set; }
        [Display(Name = "اسم الصف")]
        public int ClassId { get; set; }

          
        public Teacher Teacher { get; set; }

        [Display(Name = "سم الأستاذ")]
        public int TeacherId { get; set; }

 
    }
}
