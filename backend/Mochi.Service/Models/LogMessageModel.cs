namespace Mochi.Service.Models
{
    public class LogMessageModel
    {
        public LogLevel MessageLogLevel { get; set; }
        
        public string SourceName { get; set; }

        public string Message { get; set; }
        
        public DateTimeOffset SendAt { get; set; }
    }
}
