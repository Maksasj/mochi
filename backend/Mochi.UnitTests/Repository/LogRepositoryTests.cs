using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mochi.UnitTests.Repository;

    /*
             private readonly ILogService _logService;

       public LoggerController(ILogService logService)
       {
           _logService = logService;
       }

       [HttpPost]
       [Route("Log")]
       public async Task<IActionResult> Log([FromBody] LogMessageModel message)
       {
           var result = await _logService.LogMessage(message);

           if (result == false)
               return BadRequest("Failed to log message");

           return Ok();
       }

       [HttpGet]
       [Route("GetLogs")]
       public async Task<LogMessageItemPageResponseModel> GetLogs(int pageIndex = 0, int itemsPerPage = 100)
       {
           var messages = _logService.GetLogs()
               .Skip(pageIndex * itemsPerPage)
               .Take(itemsPerPage)
               .ToArray();

           return new LogMessageItemPageResponseModel
           {
               PageIndex = pageIndex,
               ItemCount = messages.Length,
               Messages = messages,
           };
       }

       [HttpGet]
       [Route("GetLogsCount")]
       public async Task<long> GetLogsCount()
       {
           return  _logService.GetLogs().LongCount();
       }

       [HttpDelete]
       [Route("ClearLogs")]
       public async Task<IActionResult> ClearLogs()
       {
           var result = await _logService.ClearLogsAsync();

           if (result == false)
               return BadRequest("Failed to clear logs");

           return Ok();
       }
     */

public class LogRepositoryTests
{
}
