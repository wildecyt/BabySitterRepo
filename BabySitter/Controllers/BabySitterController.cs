using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BabySitter.Api.Controllers.Interfaces;
using BabySitter.Data.Models.Interfaces;

namespace BabySitter.Api.Controllers
{
    public class BabySitterController : ApiController, IBabySitterController
    {
        private IHttpActionResult GetBabySitter(int id)
        {
            return Ok<IBabySitter>(new Data.Models.BabySitter
                                   {
                                       StartTime = DateTime.Parse("5:00PM"),
                                       EndTime = DateTime.Parse("4:00AM")
            });
        }

        // GET api/<controller>/5
        [ResponseType(typeof(IBabySitter))]
        public async Task<IHttpActionResult> Get(int id)
        {
            return await Task.FromResult(GetBabySitter(id));
        }
    }
}