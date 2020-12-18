using FluentAssertions;
using Moq;
using Predictions.Business.Models;
using Predictions.Persistence;
using Predictions.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public async Task GetAllPredictions_Returns_No_Predictions()
        {
            // arrange
            var repositoryMock = new Mock<IPredictionRepository>();
            var predictions = new List<Prediction> { };
            repositoryMock.Setup(x => x.GetPredictions()).ReturnsAsync(predictions);
            var businessLogic = new PredictionBusinessLogic(repositoryMock.Object);
            var expectedResult = new List<PredictionDto> { };

            // act
            var result = await businessLogic.GetAllPredictions();


            // assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public async Task GetPredictionDtosForCompany_Returns_One_Company()
        {
            // arrange
            var repositoryMock = new Mock<IPredictionRepository>();
            var predictions = new List<Prediction>
            {   new Prediction { Id = 1,Company = new Company{ Name = "Auchan"}, CompanyId = 1, Date = System.DateTime.Now.Date, OpenPrice = 100,ClosePrice =110,Volume=2323,HighPrice =222, LowPrice=33},
                new Prediction { Id = 2,Company = new Company{ Name = "Khaufland"}, CompanyId = 2, Date = System.DateTime.Now.Date, OpenPrice = 5,ClosePrice =140,Volume=421,HighPrice =500, LowPrice=4},
            };
            repositoryMock.Setup(x => x.GetPredictionsById(1)).ReturnsAsync(predictions.Where(p => p.CompanyId == 1).ToList());
            var businessLogic = new PredictionBusinessLogic(repositoryMock.Object);

            var expectedResult = new List<PredictionDto>
            {   new PredictionDto { CompanyName = "Auchan", Date = System.DateTime.Now.Date, OpenPrice = 100,ClosePrice =110,Volume=2323,HighPrice =222, LowPrice=33}
            };

            // act
            var result = await businessLogic.GetPredictionDtosForCompany(1);


            // assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public async Task GetPredictionDtosForCompany_No_Company()
        {
            // arrange
            var repositoryMock = new Mock<IPredictionRepository>();
            var predictions = new List<Prediction>
            {   new Prediction { Id = 1,Company = new Company{ Name = "Auchan"}, CompanyId = 1, Date = System.DateTime.Now.Date, OpenPrice = 100,ClosePrice =110,Volume=2323,HighPrice =222, LowPrice=33},
                new Prediction { Id = 2,Company = new Company{ Name = "Khaufland"}, CompanyId = 2, Date = System.DateTime.Now.Date, OpenPrice = 5,ClosePrice =140,Volume=421,HighPrice =500, LowPrice=4},
            };
            repositoryMock.Setup(x => x.GetPredictionsById(3)).ReturnsAsync(predictions.Where(p => p.CompanyId == 3).ToList());
            var businessLogic = new PredictionBusinessLogic(repositoryMock.Object);

            var expectedResult = new List<PredictionDto> {};

            // act
            var result = await businessLogic.GetPredictionDtosForCompany(3);

            // assert
            result.Should().BeEquivalentTo(expectedResult);
        }


        [Fact]
        public async Task GetPredictionDtosForCompany_More_Companys_With_Same_Id()
        {
            // arrange
            var repositoryMock = new Mock<IPredictionRepository>();
            var predictions = new List<Prediction>
            {   new Prediction { Id = 1,Company = new Company{ Name = "Auchan"}, CompanyId = 1, Date = System.DateTime.Now.Date, OpenPrice = 100,ClosePrice =110,Volume=2323,HighPrice =222, LowPrice=33},
                new Prediction { Id = 2,Company = new Company{ Name = "Khaufland"}, CompanyId = 1, Date = System.DateTime.Now.Date, OpenPrice = 5,ClosePrice =140,Volume=421,HighPrice =500, LowPrice=4},
                new Prediction { Id = 3,Company = new Company{ Name = "Saturn"}, CompanyId = 2, Date = System.DateTime.Now.Date, OpenPrice = 200,ClosePrice =200,Volume=5125,HighPrice =1000, LowPrice=100},
            };
            repositoryMock.Setup(x => x.GetPredictionsById(1)).ReturnsAsync(predictions.Where(p => p.CompanyId == 1).ToList());
            var businessLogic = new PredictionBusinessLogic(repositoryMock.Object);

            var expectedResult = new List<PredictionDto> 
            {
             new PredictionDto { CompanyName = "Auchan", Date = System.DateTime.Now.Date, OpenPrice = 100,ClosePrice =110,Volume=2323,HighPrice =222, LowPrice=33},
             new PredictionDto { CompanyName = "Khaufland", Date = System.DateTime.Now.Date, OpenPrice = 5,ClosePrice =140,Volume=421,HighPrice =500, LowPrice=4}
            };

            // act
            var result = await businessLogic.GetPredictionDtosForCompany(1);

            // assert
            result.Should().BeEquivalentTo(expectedResult);
        }

    }
}
