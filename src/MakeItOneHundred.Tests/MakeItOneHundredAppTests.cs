using System;
using Xunit;
using MakeItOneHundred;
using Moq;
using MakeItOneHundred.Acess;

namespace MakeItOneHundred.Tests
{
    public class MakeItOneHundredTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var outputWriter = new Mock<IOutputWriter>();
            var app = new MakeItOneHundredApp(outputWriter.Object);

            // Act
            app.Run();
            
            // Assert
            outputWriter.Verify(o => o.WriteLine(It.IsAny<string>()), Times.Once());
        }
    }
}
