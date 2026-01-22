namespace LibrarySystem.Common.DTOs.UserIdentity.Auth

{
    public class AuthResponseDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = "";
        public string Token { get; set; } = ""; 
        public List<string> Roles { get; set; } = new();
    }
}
