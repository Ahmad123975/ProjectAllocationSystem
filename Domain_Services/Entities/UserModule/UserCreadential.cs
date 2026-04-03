using System.ComponentModel.DataAnnotations;

namespace Domain_Services.Entities.UserModule
{
    public class UserCreadential
    {
        [Key]
        public Guid UserCreadentialId { get; set; }
        public Guid UserId { get; set; }
        public byte[] PasswordHash { get; set; } 
        public byte[] PasswordSalt { get; set; }
        public string Otp {  get; set; }
        public DateTime? OtpExpiry { get; set; }


    }
}
