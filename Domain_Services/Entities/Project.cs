using Domain_Services.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain_Services.Entities
{
    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; } 
        public Guid UserId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ProjectStatus Status { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
