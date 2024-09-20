using Microsoft.Extensions.Logging;
using Mochi.Service.Models;
using Mochi.Service.Service;
using Moq;
using NUnit.Framework;
using Mochi.Service.Controllers;

namespace Mochi.UnitTests.Controllers;

public class LoggerControllerTests
{
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public async Task Log_ServiceLogMessage_ExecutedOnce()
    {
        // Arrange
        var serviceMock = new Mock<ILogService>();
        serviceMock.Setup(mock => mock.LogMessage(It.IsAny<LogMessageModel>())).Returns(Task.FromResult(true));
        var controller = new LoggerController(serviceMock.Object);

        // Act
        await controller.Log(new LogMessageModel
        {
            MessageLogLevel = LogLevel.Information,
            SourceName = "Test source",
            Message = "Test message",
            SendAt = DateTimeOffset.Now
        });

        // Assert
        serviceMock.Verify(mock => mock.LogMessage(It.IsAny<LogMessageModel> ()), Times.Once);
    }

    [Test]
    public async Task GetLogs_ServiceGetLogs_ExecutedOnce()
    {
        // Arrange
        var serviceMock = new Mock<ILogService>();
        serviceMock.Setup(mock => mock.GetLogs()).Returns(Enumerable.Empty<LogMessageItem>);
        var controller = new LoggerController(serviceMock.Object);

        // Act
        await controller.GetLogs();

        // Assert
        serviceMock.Verify(mock => mock.GetLogs(), Times.Once);
    }

    [Test]
    public async Task ClearLogs_ServiceClearLogsAsync_ExecutedOnce()
    {
        // Arrange
        var serviceMock = new Mock<ILogService>();
        serviceMock.Setup(mock => mock.ClearLogsAsync()).Returns(Task.FromResult(true));
        var controller = new LoggerController(serviceMock.Object);

        // Act
        await controller.ClearLogs();

        // Assert
        serviceMock.Verify(mock => mock.ClearLogsAsync(), Times.Once);
    }

    [Test]
    public async Task GetLogsCount_ServiceGetLogs_ExecutedOnce()
    {
        // Arrange
        var serviceMock = new Mock<ILogService>();
        serviceMock.Setup(mock => mock.GetLogs()).Returns(Enumerable.Empty<LogMessageItem>);
        var controller = new LoggerController(serviceMock.Object);

        // Act
        await controller.GetLogsCount();

        // Assert
        serviceMock.Verify(mock => mock.GetLogs(), Times.Once);
    }
}
