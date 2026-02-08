using System.Text.Json.Serialization;

namespace LibrarySystem.Common.DTOs.UserIdentity.Auth
{
    public class AuthResponseDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = "";
        public string Token { get; set; } = "";
        public List<string> Roles { get; set; } = new();
        /// <summary>Permissions from UserIdentity (single source of truth). MVC uses this; no need to parse JWT.</summary>
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; } = new();
    }
}
