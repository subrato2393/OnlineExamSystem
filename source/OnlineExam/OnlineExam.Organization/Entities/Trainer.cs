using OnlineExam.DataAccessLayar;
using System;
using System.Collections.Generic;

namespace OnlineExam.Organization.Entities
{
    public class Trainer : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public byte[] Image { get; set; }
        public List<CourseAssign> CourseAssigns { get; set; }
    }
}
