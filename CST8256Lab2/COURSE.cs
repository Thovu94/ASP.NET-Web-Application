using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST8256Lab2
{
    public class Course
    {
        private string coursenumber;
        public string CourseNumber { get { return coursenumber; } }

        private string coursename;
        public string CourseName { get { return coursename; } }

        private List<Student> studentlist;
        public List<Student> StudentList { get { return studentlist; } }

        public Course(string coursenumber, string coursename)
        {
            this.coursenumber = coursenumber;
            this.coursename = coursename;
            //StudentList = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            StudentList.Add(student);
        }
        public List<Student> GetStudents()
        {
            return StudentList;
        }
        public override string ToString()
        {
            return coursenumber + " " + coursename;
        }
    }
}