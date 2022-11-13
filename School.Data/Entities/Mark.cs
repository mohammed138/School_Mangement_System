using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Mark:BaseClass
    {



        [Key]
        [Display(Name = "معرف العلامة ")]
        public int Id { get; set; }


        [Required]
        [Range(0, 5, ErrorMessage = "  يجب أن يكون حقل الإختبارات القصيرة من 0الى 5 درجات ")]
        [Display(Name = "الإختبارات القصيرة  ")]
        public float? ShortQuizzes { get; set; }


  
        [Range(0, 10, ErrorMessage = "  يجب أن يكون حقل التقويم النوعي  من 0الى 15 درجات ")] 
        [Display(Name = " درجات التقويم النوعي  ")]
        public float? QualitativeAssessmentGrades { get; set; }


        [Range(0, 25, ErrorMessage = "  يجب أن يكون حقل الدرجة النهائية  القصيرة من 0الى 20 درجات ")]
        [Display(Name = "الدرجة النهائية   ")]
        public float? FinalTermValue { get; set; }
         
        //public float? Total => (float)(this.ShortQuizzes + this.FinalTermValue + this.QualitativeAssessmentGrades );



        


        public Student Student { get; set; }
        [Display(Name = "اسم الطالب")]
        public int? StudentId { get; set; }
         
        public Subject Subject { get; set; }

        [Display(Name = "اسم المادة ")]
        public int? SubjectId { get; set; }


        public Class Class { get; set; }
        [Display(Name = "اسم الصف")]
        public int? ClassId { get; set; }
         
        public Teacher Teacher { get; set; }
        [Display(Name = "اسم المعلم ")]
        public int? TeacherId { get; set; }

         
    }
}



