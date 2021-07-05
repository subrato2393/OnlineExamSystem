using OnlineExam.DataAccessLayar;
using System;
using System.Collections.Generic;

namespace OnlineExam.Organization.Entities
{
    public class Tag : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<CourseTag> CourseTags { get; set; }
    }
}
