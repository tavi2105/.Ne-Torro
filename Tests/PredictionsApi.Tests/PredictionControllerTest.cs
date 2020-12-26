using Moq;
using Predictions.Business;
using PredictionsApi.Controllers;
using System.Threading.Tasks;
using Xunit;

namespace PredictionsApi.Tests
{
    public class PredictionControllerTest
    {
        [Fact]
        public async Task Get_ReturnsNoFoundResult_GivenModelError()
        {
            // Arrange & Act	
            var mockRepo = new Mock<IPredictionBusinessLogic>();
            var controller = new PredictionsController(mockRepo.Object);

            // Act	
            var result = await controller.GetById(10);

            // Assert	
            Assert.IsType<Microsoft.AspNetCore.Mvc.NotFoundResult>(result);
        }
    }
}
