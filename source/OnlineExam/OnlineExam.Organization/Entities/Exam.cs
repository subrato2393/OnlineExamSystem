using OnlineExam.DataAccessLayar;
using System;
using System.Collections.Generic;

namespace OnlineExam.Organization.Entities
{
    public class Exam : IEntity<Guid>
    {
        public Guid Id { get; set; }
     //   public Enum ExamType { get; set; }
        public string Code { get; set; }
        public string Topic { get; set; }
        public int FullMarks { get; set; }
        public double Duration { get; set; }
        public List<QusAndAns> QusAndAns { get; set; }
        public ExamSchedule ExamSchedule { get; set; }
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
    }
}
