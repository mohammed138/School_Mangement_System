using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ViewModels
{
   public class ListOfStudentMarks:BaseClass
    {

        public Mark Mark { get; set; }
        public List<Mark> StudentMarks { get; set; }



    }
}
