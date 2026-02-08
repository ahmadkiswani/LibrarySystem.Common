namespace LibrarySystem.Common.Auth;

/// <summary>
/// Permission identifiers. Source of truth for claim values is UserIdentity; this enum is for type-safe usage in presentation and policies.
/// </summary>
public enum Permission
{
    UserManage,
    CategoryManage,
    BookView,
    BookCreate,
    BookUpdate,
    BookDelete,
    BorrowView,
    BorrowCreate,
    BorrowReturn,
    BorrowApprove,
    ReportView
}
