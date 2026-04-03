namespace Domain_Services.Entities
{
    public class Allocation
    {
        public Guid Id { get; set; } 
        // StudentId
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
        public DateTime AllocatedAt { get; set; } 
    }
}
