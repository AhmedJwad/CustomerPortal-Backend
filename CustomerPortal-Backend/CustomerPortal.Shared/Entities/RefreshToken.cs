using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerPortal.Shared.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }      
        public string TokenHash { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }      
        public DateTime? RevokedAt { get; set; }       
        public string? ReplacedByTokenHash { get; set; }
    }
}
