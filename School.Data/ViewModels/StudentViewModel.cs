using School.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
    public class StudentViewModel:BaseClass
    {

        public IEnumerable<SelectListItem> SemesterDrop { get; set; }
        public IEnumerable<SelectListItem> ClassDrop { get; set; }
        public IEnumerable<SelectListItem> GenderDrop { get; set; }



        public Student Student { get; set; } 
        public List<Student> StudentList;

            
            
    }
}
