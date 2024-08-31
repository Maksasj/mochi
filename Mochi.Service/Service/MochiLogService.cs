using Mochi.Service.Models;
using Mochi.Service.Repository;
using SQLitePCL;

namespace Mochi.Service.Service
{
    public class MochiLogService : ILogService
    {
        private readonly ILogRepository _logRepository;

        public MochiLogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public async Task<bool> LogMessage(LogMessageModel model)
        {
            return await _logRepository.AddLogAsync(new LogMessageItem
            {
                Id = Guid.NewGuid(),
                MessageLogLevel = model.MessageLogLevel,
                SourceName = model.SourceName,
                Message = model.Message,
                SendAt = model.SendAt,
                ReceivedAt = DateTimeOffset.Now
            });
        }

        public IEnumerable<LogMessageItem> GetLogs()
        {
            return _logRepository.GetLogs().Reverse();
        }

        public async Task<bool> ClearLogsAsync()
        {
            return  await _logRepository.DeleteLogsAsync(GetLogs());
        }
    }
}
