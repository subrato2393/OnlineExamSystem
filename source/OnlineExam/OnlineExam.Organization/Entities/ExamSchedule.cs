using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExam.Organization.Entities
{
    public class ExamSchedule
    {
        public Guid Id { get; set; }
        public Guid ExamId { get; set; }
        public DateTime ExamDateTime { get; set; } 
    }
}
