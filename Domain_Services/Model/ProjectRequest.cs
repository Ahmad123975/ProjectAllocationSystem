using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Services.Model
{
    public class ProjectRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid StudentId { get; set; }
        public Guid ProjectId { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected
        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
    }
}
