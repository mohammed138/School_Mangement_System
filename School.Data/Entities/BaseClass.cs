using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class BaseClass
    {
        
        public BaseClass()
        {
            IsDelete = false;
            CreatedAt = DateTime.Now;
            IsArchive = false;

        }




        [Display(Name = "تم الإضافة بواسطة   ")]
        public string CreatedBy { get; set; }

        [Display(Name = "تم التعديل بواسطة   ")]
        public string? UpdatedBy { get; set; }



        [Display(Name = "تم الإضافة في  ")]
        public DateTime CreatedAt { get; set; }



        [Display(Name = "تم التعديل في  ")]
        public DateTime? UpdatedAt { get; set; }



        [Display(Name = " نشط ")]
        public bool? IsActive { get; set; }



        [Display(Name = "محذوف ")]
        public bool? IsDelete { get; set; }



        [Display(Name = "مؤرشف  ")]
        public bool? IsArchive { get; set; }


        //public Semester Semester { get; set; }
        //[Display(Name = "الفصل الدراسي ")]
        //public int SemesterId { get; set; }

    }
}
