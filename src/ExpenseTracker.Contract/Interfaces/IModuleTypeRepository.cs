using ExpenseTracker.Contract.DTO;
using ExpenseTracker.Contract.Helpers;

namespace ExpenseTracker.Contract.Interfaces;

public interface IModuleTypeRepository
{
    // Read
    Task<ModuleTypeDto?> GetByIdAsync(int id);
    Task<ModuleTypeDto?> GetByNameAsync(string name);
    Task<IEnumerable<ModuleTypeDto>> InquireAsync(bool? isActive = null);
    Task<IEnumerable<ModuleTypeDto>> GetMenuTreeAsync();

    // Validation
    Task<CustomValidateResult> ValidateAsync(ModuleTypeDto dto);

    // Operations
    Task<ModuleTypeDto> CreateAsync(ModuleTypeDto dto, int? currentUserId);
    Task<ModuleTypeDto> UpdateAsync(ModuleTypeDto dto, int? currentUserId);
    Task DeleteAsync(int id);
}