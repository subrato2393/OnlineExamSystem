using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExam.Organization.Entities
{
    public class Batch
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public int BatchNo { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
