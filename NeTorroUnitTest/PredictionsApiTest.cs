using Moq;
using System;
using PredictionsApi.Controllers;
using Xunit;
using System.Threading.Tasks;
using Predictions.Persistence;

namespace NeTorroUnitTest
{
    public class PredictionsApiTest
    {
        [Fact]
        public async Task Get_ReturnsNoFoundResult_GivenModelError()
        {
            // Arrange & Act
            var mockRepo = new Mock<IPredictionRepository>();
            var controller = new PredictionsController(mockRepo.Object);
            controller.ModelState.AddModelError("error", "some error");

            // Act
            var result = await controller.GetAll();

            // Assert
            Assert.IsType<Microsoft.AspNetCore.Mvc.NotFoundResult>(result);
        }
    }
}
