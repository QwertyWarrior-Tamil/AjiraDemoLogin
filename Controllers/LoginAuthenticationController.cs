
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using AjiraDemoLogin.Models;
using AjiraDemoLogin;

namespace PostmanProject.Controllers
{
    public class BasicAuthController : ApiController
    {
        [HttpGet]
        [BasicLogin]
        public HttpResponseMessage Get()
        {
            string userName = Thread.CurrentPrincipal.Identity.Name;
            using (SampleLogin123Entities entities = new SampleLogin123Entities())
            {
                if (userName != "")
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entities.DataOfPPLs.ToList());
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }


    }
}
