using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Mochi.Service.Models
{
    public class LogMessageItem
    {
        [Required]
        public Guid Id { get; set; }

        public LogLevel LogLevel { get; set; }

        public string SourceName { get; set; }

        public string Message { get; set; }

        public DateTimeOffset SendAt { get; set; }

        public DateTimeOffset ReceivedAt { get; set; }
    }
}
