using Domain_Services.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain_Services.Entities
{
    public class Request
    {
        [Key]
        public Guid RequestId{ get; set; } = Guid.NewGuid();
        // Student
        public Guid UserID { get; set; }
        public Guid ProjectId { get; set; }
        public RequestStatus Status { get; set; }
        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
    }
}
