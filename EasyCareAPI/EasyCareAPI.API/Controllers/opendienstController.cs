using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyCareAPI.API.Controllers
{
    public class opendienstController : ApiController
    {
        public IHttpActionResult GetOpenstaandeDiensten(int regioID)
        {
            return BadRequest();
        }

        public IHttpActionResult RegisterOpenstaandeDienst(int dienstID, int medewerkerID)
        {
            return BadRequest();
        }
    }
}