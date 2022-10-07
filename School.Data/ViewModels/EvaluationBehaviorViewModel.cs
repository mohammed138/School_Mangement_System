using Microsoft.AspNetCore.Mvc.Rendering;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class SkillsBehaviorViewModel:BaseClass
    {
        public SkillsBehavior SkillsBehavior { get; set; } 
        public List<SkillsBehavior> SkillsBehaviorList { get; set; }


        public Student Student { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }

         
        public IEnumerable<SelectListItem> CompletionTypeDrop { get; set; }
        public IEnumerable<SelectListItem> StudentDrop { get; set; }
        public IEnumerable<SelectListItem> SubjectsDrop { get; set; }
        public IEnumerable<SelectListItem> ClassDrop { get; set; }
        public IEnumerable<SelectListItem> TeacherDrop { get; set; }
        public IEnumerable<SelectListItem> DurationDrop { get; set; }
        public int ClassID { get; set; }
        public Decisions Decisions { get; set; }
        public int? StudentID { get; set; }
    }
}
