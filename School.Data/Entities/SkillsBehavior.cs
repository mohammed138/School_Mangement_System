using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class SkillsBehavior : BaseClass
    {
        [Key]
        [Display(Name = "معرف التقييم ")]
        public int Id { get; set; }

        [Display(Name = " البند  ")]
        [Required]
        public string Name { get; set; }


        [Display(Name = "اسم الطالب")]
        public Student Student { get; set; }

        [Display(Name = "اسم الصف")]
        public Class Class { get; set; }


        [Display(Name = " المادة ")]
        public Subject Subject { get; set; }


        [Display(Name = " المعلم ")]
        public Teacher Teacher { get; set; }


        [Display(Name = "  الأسبوع ")]
        public Duration Duration { get; set; }


        [Display(Name = " التقييم ")]
        public CompletionType CompletionType { get; set; }


         
        [Display(Name = " الصف")]
        public int? ClassId { get; set; }
        [Display(Name = " المادة ")]
        public int? SubjectId { get; set; }

        [Display(Name = " الطالب")]
        public int? StudentId { get; set; }

        [Display(Name = " المعلم ")]
        public int? TeacherId { get; set; }

        [Display(Name = "  الأسبوع ")]
        public int? DurationId { get; set; }

        [Display(Name = " التقييم ")]
        public int? CompletionTypeId { get; set; }

     


    }
}
