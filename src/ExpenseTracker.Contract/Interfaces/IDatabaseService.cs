using ExpenseTracker.Contract.DTO;

namespace ExpenseTracker.Contract.Interfaces;

public interface IDatabaseService
{
    Task<IEnumerable<MigrationDto>> GetMigrationHistoryAsync();
    Task<string> GetScriptAsync(string migrationId);
    Task<bool> SyncDatabaseAsync();
    string GetSnapshotInfo();
    Task<bool> RollbackDatabaseAsync(string migrationId);
}
