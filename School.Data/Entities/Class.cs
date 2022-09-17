using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Class:BaseClass
    {

        public Class()
        {
            //TeacherClass = new HashSet<TeacherClass>();
        }


        [Key]
        [Display(Name = " معرف الصف")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "اسم الصف")]
        public string Name { get; set; }

        [Display(Name = "رمز الصف")]
        public string Symbol { get; set; }

        [Display(Name = "سعة الصف")]
        public int Capacity { get; set; }





        //public virtual ICollection<TeacherClass> TeacherClass { get; set; }
        //public virtual ICollection<StudentClass> StudentClass { get; set; }
        //public virtual ICollection<Subject> Subjects { get; set; }


    }
}
