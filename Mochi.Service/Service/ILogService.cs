using System.Reflection.Metadata;
using Mochi.Service.Models;

namespace Mochi.Service.Service
{
    public interface ILogService
    {
        Task<bool> LogMessage(LogMessageModel model);

        IEnumerable<LogMessageItem> GetLogs();
    }
}
