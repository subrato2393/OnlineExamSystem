using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExam.Organization.Entities
{
    public class Exam
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Enum ExamType { get; set; }
        public string Code { get; set; }
        public string Topic { get; set; }
        public int FullMarks { get; set; }
        public double Duration { get; set; } 
    }
}
