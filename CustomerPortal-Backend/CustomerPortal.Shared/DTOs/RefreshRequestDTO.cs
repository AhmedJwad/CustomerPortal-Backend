using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerPortal.Shared.DTOs
{
    public class RefreshRequestDTO
    {
        [Required]
        public string RefreshToken { get; set; } = null!;
    }
}
