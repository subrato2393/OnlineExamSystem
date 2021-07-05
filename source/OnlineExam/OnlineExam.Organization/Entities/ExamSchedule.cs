using OnlineExam.DataAccessLayar;
using System;

namespace OnlineExam.Organization.Entities
{
    public class ExamSchedule : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public DateTime ExamDateTime { get; set; }
        public Guid ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
