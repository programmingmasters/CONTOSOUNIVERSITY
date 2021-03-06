﻿namespace ContosoUniversity.Models
{

    /// <summary>
    /// A Mapping Class for Course and Assignment without 'payloads'.
    /// The Name "CourseAssignment" is preferred over "CourseInstructor".
    /// </summary>
    public class CourseAssignment
    {
        //Primary key is autogenerated if not defined by EF Core.
        
        public int InstructorID { get; set; }

        public int CourseID { get; set; }

        public Instructor Instructor { get; set; }

        public Course Course { get; set; }
    }
}


