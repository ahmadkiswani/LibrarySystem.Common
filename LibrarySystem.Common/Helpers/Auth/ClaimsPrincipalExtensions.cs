using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace LibrarySystem.Common.Helpers.Auth;

/// <summary>
/// Shared claim parsing helpers for microservices.
/// Keeps the claim-reading logic in Common so each service doesn't duplicate it.
/// </summary>
public static class ClaimsPrincipalExtensions
{
    /// <summary>
    /// Returns the external subject id from JWT claims (NameIdentifier or "sub").
    /// </summary>
    public static string? GetExternalSubjectId(this ClaimsPrincipal user)
        => user.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? user.FindFirst("sub")?.Value;

    /// <summary>
    /// Returns external user id as int if present and parseable.
    /// </summary>
    public static int? TryGetExternalUserId(this ClaimsPrincipal user)
    {
        var externalId = user.GetExternalSubjectId();
        return int.TryParse(externalId, out var id) ? id : null;
    }

    public static int? TryGetExternalUserId(this HttpContext? httpContext)
        => httpContext?.User.TryGetExternalUserId();
}

