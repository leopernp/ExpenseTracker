using ExpenseTracker.Contract.DTO;

namespace ExpenseTracker.Contract.Interfaces;

public interface IMenuCacheService
{
    Task<IEnumerable<ModuleTypeDto>> GetMenuAsync(int userId, int roleId, bool isSuperAdmin = false);
    void InvalidateMenu(int userId);
    void InvalidateAllMenus();
}