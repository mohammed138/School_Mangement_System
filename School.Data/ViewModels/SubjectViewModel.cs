using Microsoft.AspNetCore.Mvc.Rendering;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class SubjectViewModel:BaseClass
    {
        public Subject Subject { get; set; }
        public List<Subject> SubjectList { get; set; }
        public IEnumerable<SelectListItem> ClassDrop { get; set; }
        public IEnumerable<SelectListItem> TeacherDrop { get; set; }
    }
}
