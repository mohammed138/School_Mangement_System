using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Teacher:BaseClass
    {
        [Key]
        [Display(Name = "معرف المعلم")]

        public int Id { get; set; }


        [Display(Name = "الاسم الأول ")]
        [Required]
        public string FirstName { get; set; }


        [Display(Name = "اسم العائلة ")]
        [Required]
        public string LastName { get; set; }


        [Display(Name = "رقم الهاتف")]
        //[Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Display(Name = "الايميل")]
        public string EmailAddress { get; set; }


        [Display(Name = "اسم المعلم ")] 
        public string FullName => FirstName + " " + LastName;

        [Display(Name = " سنة التعيين ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        public DateTime AppointmentYear { get; set; }


        [Display(Name = "اسم التخصص")]
        public string Specialization { get; set; }
        


 
    }
}
