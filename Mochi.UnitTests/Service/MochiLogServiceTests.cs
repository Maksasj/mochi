using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Mochi.Service.Models;
using Mochi.Service.Repository;
using Mochi.Service.Service;
using Moq;
using NUnit.Framework;

namespace Mochi.UnitTests.Service;

public class MochiLogServiceTests
{
    [SetUp]
    public void SetUp()
    {
       
    }

    /*
       public async Task<bool> LogMessage(LogMessageModel model)
       {
           return await _logRepository.AddLogAsync();
       }

       public IEnumerable<LogMessageItem> GetLogs()
       {
           return _logRepository.GetLogs().Reverse();
       }

       public async Task<bool> ClearLogsAsync()
       {
           return  await _logRepository.DeleteLogsAsync(GetLogs());
       }
     */

    [Fact]
    public async Task LogMessage_LogValidLogMessage_ReturnsTrue()
    {
        // Arrange
        var model = new LogMessageModel
        {
            MessageLogLevel = LogLevel.Information,
            SourceName = "Test source name",
            Message = "Test message",
            SendAt = DateTimeOffset.Now
        };

        var repositoryMock = new Mock<ILogRepository>();
        repositoryMock.Setup(mock => mock.AddLogAsync(It.IsAny<LogMessageItem>())).Returns(Task.FromResult(true));

        var service = new MochiLogService(repositoryMock.Object);

        // Act
        await service.LogMessage(model);

        // Assert
        repositoryMock.Verify(mock => mock.AddLogAsync(It.IsAny<LogMessageItem>()), Times.Once);
    }

    [Fact]
    public async Task LogMessage_LogManyValidLogMessage_ReturnsTrue()
    {
        // Arrange
        var model = new LogMessageModel
        {
            MessageLogLevel = LogLevel.Information,
            SourceName = "Test source name",
            Message = "Test message",
            SendAt = DateTimeOffset.Now
        };

        var repositoryMock = new Mock<ILogRepository>();
        repositoryMock.Setup(mock => mock.AddLogAsync(It.IsAny<LogMessageItem>())).Returns(Task.FromResult(true));

        var service = new MochiLogService(repositoryMock.Object);

        // Act
        for (int i = 0; i < 1234; ++i)
            await service.LogMessage(model);

        // Assert
        repositoryMock.Verify(mock => mock.AddLogAsync(It.IsAny<LogMessageItem>()), Times.Exactly(1234));
    }
}
