using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Services.Model
{
    public class ProjectAllocation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid StudentId { get; set; }
        public Guid ProjectId { get; set; }
        public DateTime AllocatedAt { get; set; } = DateTime.UtcNow;
    }
}
