using System.Threading.Tasks;
using System.Web.Http;

namespace BabySitter.Api.Controllers.Interfaces
{
    public interface IBabySitterController
    {
        Task<IHttpActionResult> Get(int id);
    }
}