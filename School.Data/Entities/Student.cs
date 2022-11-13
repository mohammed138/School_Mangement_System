using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Student:BaseClass
    {
        

        [Key]
        [Display(Name = "معرف الطالب")]
        public int Id { get; set; }

        [Required(ErrorMessage = "حقل الاسم الأول مطلوب ")]
        [Display(Name = "الاسم الأول")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "حقل اسم العائلة مطلوب  ")] 
        [Display(Name = "اسم العائلة ")]
        public string LastName { get; set; }


        [Display(Name = "اسم الطالب ")]
        public string FullName => FirstName + " " + LastName;


        [Required(ErrorMessage = "حقل رقم الهاتف   مطلوب  ")]
        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "يجب أن يكون العدد عددًا طبيعيًا")]


        [Display(Name = "رقم الهاتف")]
        public string PhoneNumber { get; set; }

        [Display(Name = "الايميل")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "تاريخ الميلاد")]
        //[ErrorMessage = "حقل تاريخ الميلاد   مطلوب  "]

        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        public DateTime DOP { get; set; }

        [Display(Name = " عنوان السكن ")]
        [Required(ErrorMessage = "حقل   عنوان السكن مطلوب  ")] 
        public string AddressName { get; set; }

        [Display(Name = "العام الدراسي")]
        [Required(ErrorMessage = "حقل السنة مطلوب  ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        public DateTime SchoolYear { get; set; }


        [Display(Name = "مكان الولادة ")]
        [Required(ErrorMessage = "حقل مكان الولادة    مطلوب  ")] 
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

 


    }
}
