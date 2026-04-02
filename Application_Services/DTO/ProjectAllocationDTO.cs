using System;
using System.Collections.Generic;
using System.Text;

namespace Application_Services.DTO
{
    public class ProjectAllocationDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid StudentId { get; set; }
        public Guid ProjectId { get; set; }
        public DateTime AllocatedAt { get; set; } = DateTime.UtcNow;
    }
}
