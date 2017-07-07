using System.Web.Http;

namespace EasyCareAPI.API.Controllers
{
    public class userController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Authenticate()
        {
            return BadRequest();
        }
    }
}
