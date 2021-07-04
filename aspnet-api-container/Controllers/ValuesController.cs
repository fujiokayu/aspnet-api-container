using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aspnet_api_container.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/
        public string Get()
        {
            return System.Guid.NewGuid().ToString();
        }
    }
}
