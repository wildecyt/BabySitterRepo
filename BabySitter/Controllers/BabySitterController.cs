using System;
using System.Threading.Tasks;
using System.Web.Http;
using BabySitter.Controllers.Interfaces;
using BabySitter.Models.Interfaces;

namespace BabySitter.Controllers
{
    public class BabySitterController : ApiController, IBabySitterController
    {
        private IHttpActionResult GetBabySitter(int id)
        {
            return Ok<IBabySitter>(new Models.BabySitter
                                   {
                                       StartTime = DateTime.Parse("5:00PM"),
                                       EndTime = DateTime.Parse("4:00AM")
            });
        }

        // GET api/<controller>/5
        public async Task<IHttpActionResult> Get(int id)
        {
            return await Task.FromResult(GetBabySitter(id));
        }
    }
}