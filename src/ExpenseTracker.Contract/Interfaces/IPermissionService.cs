using ExpenseTracker.Contract.Models.ModulePermission;

namespace ExpenseTracker.Contract.Interfaces;

public interface IPermissionService
{
    Task<ModulePermissions> GetPermissionsAsync(string controller, int userId, int roleId, bool isSuperAdmin);
}
