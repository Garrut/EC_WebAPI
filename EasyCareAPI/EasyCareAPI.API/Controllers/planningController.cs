using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyCareAPI.API.Controllers
{
    public class planningController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetPlanning()
        {
            return BadRequest();
        }

        [HttpGet]
        public IHttpActionResult GetPlanning(int medewerkerID, string datumVanaf, string datumTot)
        {
            return BadRequest();
        }

        [HttpPut]
        public IHttpActionResult UpdatePlanning([FromBody]Type planningItem)
        {
            return BadRequest();
        }
        

    }
}