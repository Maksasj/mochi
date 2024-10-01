using Mochi.Service.Data;
using Mochi.Service.Models;

namespace Mochi.Service.Repository
{
    public class LogRepository : ILogRepository
    {
        private readonly MochiDbContext _context;

        public LogRepository(MochiDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddLogAsync(LogMessageItem log)
        {
            _context.Logs.Add(log);

            var saveResult = await _context.SaveChangesAsync();

            return saveResult == 1;
        }

        public IEnumerable<LogMessageItem> GetLogs()
        {
            return _context.Logs;
        }

        public async Task<bool> DeleteLogsAsync(IEnumerable<LogMessageItem> logs)
        {
            _context.Logs.RemoveRange(logs);

            var saveResult = await _context.SaveChangesAsync();

            return saveResult != 0;
        }
    }
}
