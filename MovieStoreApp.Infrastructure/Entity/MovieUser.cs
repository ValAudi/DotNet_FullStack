using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Infrastructure.Entity 
{
    public class MovieUser {
        [Required]
        public int UserId { get; set; }
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string FirstName { get; set; }
        [MaxLength(128)]
        [Column(TypeName = "Varchar")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(256)]
        [Column(TypeName = "Varchar")]
        public string email { get; set;}
        [MaxLength(1024)]
        [Column(TypeName = "Varchar")]
        public string HashedPassword { get; set; }
        [MaxLength(1024)]
        [Column(TypeName = "Varchar")]
        public string salt { get; set; }
        [MaxLength(16)]
        [Column(TypeName = "Varchar")]
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDate { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public bool isLocked { get; set; }
        public int AccessFailedCount { get; set; }

    }
}

