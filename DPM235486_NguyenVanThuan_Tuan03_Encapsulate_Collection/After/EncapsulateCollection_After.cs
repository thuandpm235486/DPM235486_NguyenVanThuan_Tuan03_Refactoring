using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Encapsulate_Collection
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class EncapsulateCollection_After
    {
        // Giai phap: dong goi collection, chi lo ra ReadOnly, kiem soat qua method
        public class Course
        {
            private readonly List<string> _students = new List<string>();
            public IReadOnlyList<string> Students { get { return _students.AsReadOnly(); } }
            public void AddStudent(string name)
            {
                if (!_students.Contains(name)) _students.Add(name);
                else Console.WriteLine("  [Warn] " + name + " already enrolled!");
            }
            public bool RemoveStudent(string name) { return _students.Remove(name); }
            public int StudentCount { get { return _students.Count; } }
        }
        public void Execute()
        {
            var course = new Course();
            course.AddStudent("Alice");
            course.AddStudent("Bob");
            course.AddStudent("Alice"); // duplicate bi bao cao
            Console.WriteLine("Students: " + course.StudentCount);
            foreach (var s in course.Students) Console.WriteLine("  - " + s);
        }
    }
}