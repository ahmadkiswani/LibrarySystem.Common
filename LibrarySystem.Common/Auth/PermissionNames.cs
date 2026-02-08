namespace LibrarySystem.Common.Auth;


public static class PermissionNames
{
    public const string UserManage = "user.manage";
    public const string CategoryManage = "category.manage";
    public const string BookView = "book.view";
    public const string BookCreate = "book.create";
    public const string BookUpdate = "book.update";
    public const string BookDelete = "book.delete";
    public const string BorrowView = "borrow.view";
    public const string BorrowCreate = "borrow.create";
    public const string BorrowReturn = "borrow.return";
    public const string BorrowApprove = "borrow.approve";
    public const string ReportView = "report.view";

    public static string FromPermission(Permission permission)
    {
        return permission switch
        {
            Permission.UserManage => UserManage,
            Permission.CategoryManage => CategoryManage,
            Permission.BookView => BookView,
            Permission.BookCreate => BookCreate,
            Permission.BookUpdate => BookUpdate,
            Permission.BookDelete => BookDelete,
            Permission.BorrowView => BorrowView,
            Permission.BorrowCreate => BorrowCreate,
            Permission.BorrowReturn => BorrowReturn,
            Permission.BorrowApprove => BorrowApprove,
            Permission.ReportView => ReportView,
            _ => string.Empty
        };
    }
}
