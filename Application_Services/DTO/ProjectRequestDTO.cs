using System;
using System.Collections.Generic;
using System.Text;

namespace Application_Services.DTO
{
    public class ProjectRequestDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid StudentId { get; set; }
        public Guid ProjectId { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected
        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
    }
}
