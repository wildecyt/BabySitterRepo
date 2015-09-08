using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BabySitter.Api.Controllers.Interfaces;
using BabySitter.Data.Models;
using BabySitter.Data.Models.Interfaces;

namespace BabySitter.Api.Controllers
{
    public class BabySitterController : ApiController, IBabySitterController
    {
        private IHttpActionResult GetBabySitter(int id)
        {
            BabySitterContext dbBabySitterContext = new BabySitterContext();
            
            // ReSharper disable once SuspiciousTypeConversion.Global
            Data.Models.BabySitter babySitter = dbBabySitterContext.BabySitters.Find(1);

            return Ok<IBabySitter>(babySitter);
        }

        // GET api/<controller>/5
        [ResponseType(typeof(IBabySitter))]
        public async Task<IHttpActionResult> Get(int id)
        {
            return await Task.FromResult(GetBabySitter(id));
        }
    }
}