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



        [Display(Name = "الإختبارات القصيرة  ")]
        public float ShortQuizzes { get; set; }

        [Display(Name = " درجات التقويم النوعي  ")]
        public float QualitativeAssessmentGrades { get; set; }
         

        [Display(Name = "الخاتبار النهائي ")]
        public float? FinalTermValue { get; set; }
         
        public float Total => (float)(this.ShortQuizzes + this.FinalTermValue + this.QualitativeAssessmentGrades );
         





        public Student Student { get; set; }
        [Display(Name = "اسم الطالب")]
        public int StudentId { get; set; }
         
        public Subject Subject { get; set; }

        [Display(Name = "اسم المادة ")]
        public int SubjectId { get; set; }


        public Class Class { get; set; }
        [Display(Name = "اسم الصف")]
        public int ClassId { get; set; }
         
        public Teacher Teacher { get; set; }
        [Display(Name = "اسم المعلم ")]
        public int TeacherId { get; set; }

         
    }
}



