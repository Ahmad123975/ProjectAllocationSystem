using Domain_Services.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain_Services.Entities.UserModule
{
    public class UserRole
    {
        [Key]
        public Guid UserRoleId { get; set; }
        public UserRoleType RoleName { get; set; }
        public Guid UserId { get; set; }
    }
}
