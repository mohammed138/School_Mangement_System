 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
   
    public class SubjectsClasses:BaseClass
    {
        public Class Class { get; set; }

        [Display(Name = "اسم الصف")]
        public int ClassId { get; set; }
         

        public Subject Subject { get; set; }

        [Display(Name = "اسم المادة ")]
        public int SubjectId { get; set; }

    }
}
