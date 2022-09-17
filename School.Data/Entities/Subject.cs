using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Subject:BaseClass
    {


        [Key]
        [Display(Name = "معرف المادة  ")]
        public int Id { get; set; }


        [Display(Name = "اسم المادة  ")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "  وصف المادة  ")]
        public string Description { get; set; }


        [Display(Name = "الصف ")]
        public Class Class { get; set; }

        [Display(Name = "اسم الصف ")]
        public int ClassId { get; set; }



        [Display(Name = "مدرس المادة  ")]
        public Teacher Teacher { get; set; }
        [Display(Name = "مدرس المادة  ")]
        public int TeacherId { get; set; }


        //public virtual ICollection<Teacher> Teacher { get; set; }
        //public virtual ICollection<Class> Classes { get; set; }

    }
}
