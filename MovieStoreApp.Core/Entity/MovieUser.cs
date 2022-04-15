namespace MovieStoreApp.Core.Entity 
{
    public class MovieUser {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string email { get; set;}
        public string HashedPassword { get; set; }
        public string salt { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDate { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public bool isLocked { get; set; }
        public int AccessFailedCount { get; set; }

    }
}

