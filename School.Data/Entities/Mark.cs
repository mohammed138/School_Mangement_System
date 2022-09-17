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



       


        [Display(Name = "ملاحظات")]
        public string Notice { get; set; }


        [Display(Name = "العلامة ")]
        public float? FirstTermValue { get; set; }


        [Display(Name = "العلامة ")]
        public float? MidTermValue { get; set; }


        [Display(Name = "العلامة ")]
        public float? FinalTermValue { get; set; }



        //public float Total => (float)(this.FirstTermValue + this.FinalTermValue + this.MidTermValue);


        public SkillsType FSkillsType { get; set; }
        [Display(Name = " تقييم الفصلي")]
        public int? FSkillsTypeId { get; set; }

        public SkillsType MSkillsType { get; set; }
        [Display(Name = " التقييم النصفي ")]
        public int? MSkillsTypeId { get; set; }

        public SkillsType FinalSkillsType { get; set; }
        [Display(Name = "التقييم النهائي ")]
        public int? FinalSkillsTypeId { get; set; }







        //public SkillsType SkillsType { get; set; }
        //[Display(Name = "نوع الدرجة ")]
        //public int SkillsTypeId { get; set; }


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



        public bool? IsAllowToAdd { get; set; }


    }
}
