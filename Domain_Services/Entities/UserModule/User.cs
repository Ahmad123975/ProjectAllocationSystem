using System.ComponentModel.DataAnnotations;

namespace Domain_Services.Entities.UserModule
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Session { get; set; }    // e.g. "2020-24", "2022-26"
        public string? Section { get; set; }   // e.g. "A", "B", "C"
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
