using System;
using System.Threading.Tasks;
using System.Web.Http.Results;
using BabySitter.Controllers;
using BabySitter.Controllers.Interfaces;
using BabySitter.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BabySitter.Tests
{
    [TestClass]
    public class BabySitterWebApiTest
    {
        private IBabySitterController BabySitterController { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        
        [TestInitialize]
        public void Initialize()
        {
            BabySitterController = new BabySitterController();
            StartTime = DateTime.Parse("5:00PM");
            EndTime =new DateTime(StartTime.Year, StartTime.Month, StartTime.Day + 1, 4, 0, 0);
        }

        [TestMethod]
        public void ValidateWorkHours()
        {
            Assert.IsTrue(StartTime < EndTime, "StartTime < EndTime");
        }

        [TestMethod]
        public async Task ValidateStartTime()
        {
            OkNegotiatedContentResult<IBabySitter> result = await BabySitterController.Get(1) as OkNegotiatedContentResult<IBabySitter>;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.StartTime < StartTime , "starts no earlier than 5:00PM");
        }

        [TestMethod]
        public async Task ValidateEndTime()
        {
            OkNegotiatedContentResult<IBabySitter> result = await BabySitterController.Get(1) as OkNegotiatedContentResult<IBabySitter>;

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Content.EndTime < EndTime, "leaves no later than 4:00AM");
        }
    }
}