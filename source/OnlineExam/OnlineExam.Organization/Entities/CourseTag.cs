using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExam.Organization.Entities
{
    public class CourseTag
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; } 
    }
}
