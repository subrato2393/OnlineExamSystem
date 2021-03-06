using OnlineExam.DataAccessLayar;
using System;

namespace OnlineExam.Organization.Entities
{
    public class Batch : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public int BatchNo { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}
