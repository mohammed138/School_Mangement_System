using Microsoft.AspNetCore.Mvc.Rendering;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class SubjectsClassesViewModel
    {
        //public SubjectsClasses SubjectsClasses { get; set; }
        //public List<SubjectsClasses> SubjectsClassesList { get; set; }


        public IEnumerable<SelectListItem> classesDrop { get; set; }
        public IEnumerable<SelectListItem> SubjectsDrop { get; set; }
        public List<int> SubjectIds { get; set; } 
    }
}
