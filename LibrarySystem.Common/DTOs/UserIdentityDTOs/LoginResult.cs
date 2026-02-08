using LibrarySystem.Common.DTOs.UserIdentity.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Common.DTOs.UserIdentityDTOs
{
    public class LoginResult
    {
        public AuthResponseDto Response { get; set; } = null!;
        public string RefreshToken { get; set; } = "";
        public DateTime RefreshTokenExpiresAt { get; set; }
    }
}
