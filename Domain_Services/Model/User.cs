using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Services.Model
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // Admin, Teacher, Student

        // Only for Students
        public string? Session { get; set; }    // e.g. "2020-24", "2022-26"
        public string? Section { get; set; }   // e.g. "A", "B", "C"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
