using OnlineExam.DataAccessLayar;
using System;

namespace OnlineExam.Organization.Entities
{
    public class QusAndAns : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
      //  public Enum OptionType { get; set; }
        public int Options { get; set; }
        public int Marks { get; set; } 
        public Guid ExamId { get; set; }
        public Exam Exam { get; set; } 
    }
}
