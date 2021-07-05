using OnlineExam.DataAccessLayar;
using System;

namespace OnlineExam.Organization.Entities
{
    public class CourseTag : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; } 
    }
}
