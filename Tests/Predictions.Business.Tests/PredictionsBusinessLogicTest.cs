using FluentAssertions;
using Moq;
using Predictions.Business.Models;
using Predictions.Persistence;
using Predictions.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Predictions.Business.Tests
{
    public class PredictionsBusinessLogicTest
    {
        [Fact]
        public async Task GetAllPredictions_Returns_All_Predictions()
        {
            // arrange
            var repositoryMock = new Mock<IPredictionRepository>();
            var predictions = new List<Prediction>
            {   new Prediction { Id = 1,Company = new Company{ Name = "Auchan"}, CompanyId = 1, Date = System.DateTime.Now.Date, OpenPrice = 100,ClosePrice =110,Volume=2323,HighPrice =222, LowPrice=33}
            };
            repositoryMock.Setup(x => x.GetPredictions()).ReturnsAsync(predictions);
            var businessLogic = new PredictionBusinessLogic(repositoryMock.Object);
            var expectedResult = new List<PredictionDto>
            {   new PredictionDto { CompanyName = "Auchan", Date = System.DateTime.Now.Date, OpenPrice = 100,ClosePrice =110,Volume=2323,HighPrice =222, LowPrice=33}
            };

            // act
            var result = await businessLogic.GetAllPredictions();


            // assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
