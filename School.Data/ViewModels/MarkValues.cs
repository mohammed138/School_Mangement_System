using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class MarkValues
    {
 
 

        [Required]
        [Range(0, 5, ErrorMessage = "  يجب أن يكون حقل الإختبارات القصيرة من 0الى 5 درجات ")]
        [Display(Name = "الإختبارات القصيرة  ")]
        public float? ShortQuizzes { get; set; }



        [Range(0, 15, ErrorMessage = "  يجب أن يكون حقل التقويم النوعي  من 0الى 15 درجات ")]
        [Display(Name = " درجات التقويم النوعي  ")]
        public float? QualitativeAssessmentGrades { get; set; }


        [Range(0, 40, ErrorMessage = "  يجب أن يكون حقل الدرجة النهائية  القصيرة من 0الى 40 درجات ")]
        [Display(Name = "الدرجة النهائية   ")]
        public float? FinalTermValue { get; set; }

 





   
        public int? StudentId { get; set; } 
        public int? SubjectId { get; set; } 
        public int? ClassId { get; set; } 
        public int? TeacherId { get; set; }



    }
}
