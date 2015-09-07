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

        [TestInitialize]
        public void Initialize()
        {
            BabySitterController = new BabySitterController();
            StartTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 17, 0, 0);
        }

        [TestMethod]
        public async Task ValidateStartTime()
        {
            OkNegotiatedContentResult<IBabySitter> result = await BabySitterController.Get(1) as OkNegotiatedContentResult<IBabySitter>;

            Assert.IsNotNull(result);
            Assert.IsFalse(result.Content.StartTime > StartTime, "starts no earlier than 5:00PM");
        }
    }
}