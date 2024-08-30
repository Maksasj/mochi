using Mochi.Service.Models;

namespace Mochi.Service.Repository
{
    public interface ILogRepository
    {
        Task<bool> AddLogAsync(LogMessageItem log);

        IEnumerable<LogMessageItem> GetLogs();
    }
}
