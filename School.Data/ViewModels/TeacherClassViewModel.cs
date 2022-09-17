using School.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class TeacherClassViewModel:BaseClass
    {
        public int[] TeacherIds { get; set; }
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public IEnumerable<SelectListItem> ClassesDrop { get; set; }
        public IEnumerable<SelectListItem> TeachersDrop { get; set; }
    }
}
