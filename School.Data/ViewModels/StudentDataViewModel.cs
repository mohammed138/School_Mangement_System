using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
   public class StudentDataViewModel:BaseClass 
    { 
        public MarkViewModel MarkViewModel { get; set; }
        public SkillsSuggestionsViewModel SkillsSuggestionsViewModel { get; set; }
        public ClassViewModel ClassViewModel { get; set; }
        public SkillsBehaviorViewModel SkillsBehaviorViewModel { get; set; }
        public SkillsViewModel SkillsViewModel { get; set; }
        public bool EVABIsActive { get; set; }
        public bool MArkIsActive { get; set; }
        public bool WKIsActive { get; set; }
        public bool EVAIsActive { get; set; }
        public bool SkillsActive { get; set; }
    }
}
