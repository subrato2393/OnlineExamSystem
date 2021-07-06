using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExam.Organization.BusinessObjects
{
    public class Course
    {
        public Guid UserId { get; set; } 
        public string Name { get; set; }
        public string Code { get; set; }
        public double? CourseDuration { get; set; }
        public double? Credit { get; set; }
        public string Outline { get; set; }
    }
}
