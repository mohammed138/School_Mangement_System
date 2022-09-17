using Microsoft.AspNetCore.Mvc.Rendering;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class MarkViewModel:BaseClass
    {

        public Mark Mark { get; set; }
        public Decisions Decisions { get; set; }

        

        public List<Mark> MarkList = new List<Mark>();
        public List<Subject> SubjectList { get; set; }


        public Student Student { get; set; } 
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
        public IEnumerable<SelectListItem> SkillsTypeDrop { get; set; }
        public IEnumerable<SelectListItem> StudentDrop { get; set; }
        public IEnumerable<SelectListItem> SubjectsDrop { get; set; }
        public IEnumerable<SelectListItem> ClassDrop { get; set; }
        public IEnumerable<SelectListItem> TeacherDrop { get; set; }
        public string SubjectName { get; set; }
        public int StudentClassID { get; set; }
        public int StudentId { get; set; }
        public List<Student> StudentList { get; set; }
        public int ClassID { get; set; }
        public Class Class { get; set; }

        //public IEnumerable<SelectListItem> SkillsTypeDrop { get; set; }

        /*_____________________________________________________________________________________________________*/

        public List<int> MarkIDs = new List<int>();
 
    }
}
