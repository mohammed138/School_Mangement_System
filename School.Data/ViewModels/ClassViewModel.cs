using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Data.Entities;
using School.Data.ViewModels;



namespace School.Data.ViewModels
{
    public class ClassViewModel:BaseClass
    {
        public Class Class;
        public Teacher Teacher;
        public Student Student;
        public Subject Subject;
        public int Capacity;


        public int StudentId { get; set; }
        public Decisions Decisions { get; set; }

        public List<Class> ClassList;
        public List<Teacher> TeacherList;
        public List<Student> StudentList;
        public List<Subject> SubjectList;

        
        public List<int> ClassIDs;
        public List<int> StudentIDs;
        public List<int> TeacherIDs;
        public List<int> SubjectIDs;
        public int classCap;
    }
}
