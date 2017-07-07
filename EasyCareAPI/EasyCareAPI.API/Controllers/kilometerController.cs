using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyCareAPI.API.Controllers
{
    public class kilometerController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetKilometers(int medewerkerID)
        {
            return BadRequest();
        }

        [HttpGet]
        public IHttpActionResult UpdateKilometers([FromBody]Type kilometerItem)
        {
            return BadRequest();
        }
    }
}