using Microsoft.Extensions.Logging;
using PipelineTestWebApp.Api.Controllers;
using System;
using Xunit;

namespace PipelineTestWebAppXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ControllerReturnsValuesTest()
        {
            var weatherForecastController = new WeatherForecastController();

            var result = weatherForecastController.Get();

            Assert.NotNull(result);
        }
    }
}
