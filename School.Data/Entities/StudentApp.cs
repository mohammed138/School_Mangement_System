using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class StudentApp : IdentityUser 
    {
        

        //[Key]
        //[Display(Name = "معرف الطالب")]
        //public int Id { get; set; }

        [Required] 
        [Display(Name = "الاسم الأول")]
        public string FirstName { get; set; }

        [Required] 
        [Display(Name = "اسم العائلة ")]
        public string LastName { get; set; }


        [Display(Name = "اسم الطالب ")]
        public string FullName => FirstName + " " + LastName;


        [Display(Name = "رقم الهاتف ")]
        [Required]
        public string PhoneNumber { get; set; }

        [Display(Name = "الايميل")]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "تاريخ الميلاد")]

        public DateTime DOP { get; set; }

        [Display(Name = " عنوان السكن ")]
        [Required]
        public string AddressName { get; set; }

        [Display(Name = "العام الدراسي")]
        [Required]
        [DataType(DataType.Date)]
        public string SchoolYear { get; set; }


        [Display(Name = "مكان الولادة ")]
        [Required]
        public string PlaceOBirth { get; set; }
         
        public Gender Gender { get; set; }
        [Display(Name = "الجنس")]
        public int GenderId { get; set; }


        [Display(Name = "الصف ")]  
        public Class Class { get; set; }

        [Display(Name = "اسم الصف ")]
        public int ClassId { get; set; }

        public Semester Semester { get; set; }
        [Display(Name = "الفصل الدراسي ")]
        public int SemesterId { get; set; }

        //public virtual ICollection<StudentClass> StudentClass { get; set; }



    }
}
