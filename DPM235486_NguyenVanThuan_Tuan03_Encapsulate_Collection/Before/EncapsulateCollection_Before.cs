using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Encapsulate_Collection
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class EncapsulateCollection_Before
    {
        // Van de: tra Collection truc tiep, client co the sua tuy y
        public class Course
        {
            public List<string> Students { get; set; } = new List<string>(); // public set!
        }
        public void Execute()
        {
            var course = new Course();
            course.Students.Add("Alice");
            course.Students.Add("Bob");
            course.Students.Clear(); // client co the xoa sach!
            Console.WriteLine("Students remaining: " + course.Students.Count);
        }
    }
}