using Moq;
using System;
using PredictionsApi.Controllers;
using Xunit;
using System.Threading.Tasks;
using Predictions.Persistence;
using Predictions.Business;

namespace NeTorroUnitTest
{
    public class PredictionsApiTest
    {
        [Fact]
        public async Task Get_ReturnsNoFoundResult_GivenModelError()
        {
            // Arrange & Act
            var mockRepo = new Mock<IPredictionBusinessLogic>();
            var controller = new PredictionsController(mockRepo.Object);
            controller.ModelState.AddModelError("error", "some error");

            // Act
            var result = await controller.GetAll();

            // Assert
            Assert.IsType<Microsoft.AspNetCore.Mvc.NotFoundResult>(result);
        }
    }
}
