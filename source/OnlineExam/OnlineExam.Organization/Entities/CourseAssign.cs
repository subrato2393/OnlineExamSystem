using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExam.Organization.Entities
{
    public class CourseAssign
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid TrainerId { get; set; } 
    }
}
