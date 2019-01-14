using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenManagerService.Controllers
{
    public class HealthController : ApiController
    {
        // GET: api/Health
        public HttpResponseMessage Get()
        {
            try
            {
                var errorModel = new Models.ErrorModel
                {
                    InnerException = "string",
                    Message = "string",
                    Code = 0
                };

                var healthModel = new Models.HealthModel {
                    Error = errorModel,
                    message = "string",
                    Health = nameof(Models.HealthModel.health.green)
                };

                return Request.CreateResponse(HttpStatusCode.OK, healthModel);
            }
            catch
            {
                var errorModel = new Models.ErrorModel
                {
                    InnerException = "Unexpected condition encountered",
                    Message = "Oops, this wasn't supposed to happen !!!",
                    Code = 50001
                };
                return Request.CreateResponse(HttpStatusCode.InternalServerError, errorModel);
            }
        }
    }
}
