using System;
using System.Collections.Generic;
using System.Text;

namespace Application_Services.DTO
{
    public class ProjectDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid TeacherId { get; set; }
        public string Status { get; set; } = "Open"; // Open, Closed
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
