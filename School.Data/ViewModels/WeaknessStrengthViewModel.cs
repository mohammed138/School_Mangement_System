using Microsoft.AspNetCore.Mvc.Rendering;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class SkillsSuggestionsViewModel:BaseClass
    {
        public SkillsSuggestions SkillsSuggestions { get; set; }
        public List<SkillsSuggestions> SkillsSuggestionsList { get; set; }

        public IEnumerable<SelectListItem> StudentDrop { get; set; }
        public IEnumerable<SelectListItem> SubjectDrop { get; set; }
        public int ClassID { get; set; }
        public string SubjectName { get; set; }
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
    }
}
