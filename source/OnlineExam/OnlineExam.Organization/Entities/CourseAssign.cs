using OnlineExam.DataAccessLayar;
using System;

namespace OnlineExam.Organization.Entities
{
    public class CourseAssign : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; } 
        public Guid TrainerId { get; set; }
        public Trainer Trainer { get; set; } 
    }
}
