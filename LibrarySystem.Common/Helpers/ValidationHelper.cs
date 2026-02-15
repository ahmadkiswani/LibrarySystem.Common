using LibrarySystem.Common.DTOs.Library.Helpers;

namespace LibrarySystem.Common.Helpers;

/// <summary>Obsolete: use <see cref="AppHelper"/> instead.</summary>
[Obsolete("Use AppHelper.ValidateDto or AppHelper.Validate instead.")]
public static class ValidationHelper
{
    public static ValidationResultDto ValidateDto(object dto) => AppHelper.ValidateDto(dto);
    public static List<string> Validate(object dto) => AppHelper.Validate(dto);
}
