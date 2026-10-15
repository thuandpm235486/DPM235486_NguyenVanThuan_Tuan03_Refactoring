using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Unidirectional_Association_to_Bidirectional
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ChangeUnidirectionalAssociationToBidirectional_Real
    {
        // Ung dung: SinhVien - LopHoc quan he hai chieu
        public class Course
        {
            public string Name { get; set; }
            public List<Student2> Students { get; } = new List<Student2>();
        }
        public class Student2
        {
            public string Name { get; set; }
            private List<Course> _courses = new List<Course>();
            public IReadOnlyList<Course> Courses { get { return _courses.AsReadOnly(); } }
            public void Enroll(Course c)
            {
                if (!_courses.Contains(c)) { _courses.Add(c); c.Students.Add(this); }
            }
        }
        public void Run()
        {
            var s = new Student2 { Name = "Nguyen Van Tuan" };
            var c1 = new Course { Name = "Refactoring" };
            var c2 = new Course { Name = "Design Patterns" };
            s.Enroll(c1); s.Enroll(c2);
            Console.WriteLine(s.Name + " enrolled in " + s.Courses.Count + " courses:");
            foreach (var c in s.Courses) Console.WriteLine("  - " + c.Name);
            Console.WriteLine(c1.Name + " has " + c1.Students.Count + " student(s)");
        }
    }
}