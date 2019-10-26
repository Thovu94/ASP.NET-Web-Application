using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST8256Lab2
{
    public class Student
    {
        private string id;
        public string ID { get { return id; } }
        private string name;
        public string Name { get { return name; } }
        private int grade;
        public int Grade { get { return grade; } }

        List<Course> course = new List<Course>();

        public Student(string id, string name, int grade)
        {
            this.id = id;
            this.name = name;
            this.grade = grade;

        }
    }
}