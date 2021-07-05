using OnlineExam.DataAccessLayar;
using System;
using System.Collections.Generic;

namespace OnlineExam.Organization.Entities
{
    public class Course : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double CourseDuration { get; set; }
        public double Credit { get; set; }
        public string Outline { get; set; }
        public List<CourseTag> CourseTags { get; set; }
        public List<CourseAssign> CourseAssigns { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Batch> Batches { get; set; } 
    }
}
