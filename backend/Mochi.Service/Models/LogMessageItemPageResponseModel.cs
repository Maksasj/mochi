namespace Mochi.Service.Models
{
    public class LogMessageItemPageResponseModel
    {
        public int PageIndex { get; set; }

        public int ItemCount { get; set; }

        public LogMessageItem[] Messages { get; set; }
    }
}
