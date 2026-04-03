using ExpenseTracker.Contract.DTO.Tools;

namespace ExpenseTracker.Contract.Interfaces;

public interface ISystemInfoService
{
    Task<SystemStatusDto> GetSystemMetricsAsync();
}
