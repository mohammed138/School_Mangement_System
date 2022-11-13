using Microsoft.AspNetCore.Mvc.Rendering;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class CRUDMarksViewModel
    {

        public List<Student> StudentList { get; set; }
        public List<Mark> MarkList { get; set; }
        public MarkValues MarkValues { get; set; }
        public List<Mark> MarkValuesList;
        public List<Mark> MarkValuessssList;
        public int index = 0;
        public int ControllerIndex = 0;

        public Mark Mark { get; set; }
        public IEnumerable<SelectListItem> SubjectsDrop { get; set; }

    }
}
