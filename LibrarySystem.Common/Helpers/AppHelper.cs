using System;
using System.ComponentModel.DataAnnotations;
using LibrarySystem.Common.DTOs.Library.Helpers;

namespace LibrarySystem.Common.Helpers;

/// <summary>
/// Single shared helper for all solutions: validation, paging, and other common utilities.
/// Use this instead of ValidationHelper, PagingHelper, or project-specific helpers.
/// </summary>
public static class AppHelper
{
    #region Validation

    /// <summary>Validates a DTO (DataAnnotations) and returns a structured result for APIs.</summary>
    public static ValidationResultDto ValidateDto(object dto)
    {
        var result = new ValidationResultDto();
        if (dto == null)
        {
            result.IsValid = false;
            result.Errors.Add("Request body is required.");
            return result;
        }
        var context = new ValidationContext(dto);
        var results = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(dto, context, results, validateAllProperties: true);
        if (!isValid)
        {
            result.IsValid = false;
            foreach (var r in results)
                result.Errors.Add(r.ErrorMessage ?? "Validation error");
            return result;
        }
        result.IsValid = true;
        return result;
    }

    /// <summary>Returns list of validation error messages (e.g. for Identity/Register).</summary>
    public static List<string> Validate(object dto) => ValidateDto(dto).Errors;

    #endregion

    #region Paging

    /// <summary>Normalizes page and pageSize (clamps to valid range).</summary>
    public static void NormalizePage(ref int page, ref int pageSize, int defaultPageSize = 10, int maxPageSize = 200)
    {
        if (page < 1) page = 1;
        if (pageSize <= 0 || pageSize > maxPageSize)
            pageSize = defaultPageSize;
    }

    /// <summary>Builds paging metadata from total count and current page/size.</summary>
    public static PagingInfoDto BuildPagingInfo(long totalCount, int page, int pageSize)
    {
        var totalPages = pageSize > 0 ? (int)Math.Ceiling(totalCount / (double)pageSize) : 1;
        if (totalPages < 1) totalPages = 1;
        if (page > totalPages) page = totalPages;
        return new PagingInfoDto
        {
            Page = page,
            PageSize = pageSize,
            TotalCount = totalCount,
            TotalPages = totalPages,
            HasNextPage = (page * pageSize) < totalCount
        };
    }

    #endregion
}
