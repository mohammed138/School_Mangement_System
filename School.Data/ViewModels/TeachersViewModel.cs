using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class TeachersViewModel
    {
        public Teacher Teacher { get; set; }
        public List<Teacher> TeacherList { get; set; }

        public string SubjectName { get; set; }

    }
}
