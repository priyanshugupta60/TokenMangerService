using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenManagerService.Controllers
{
    public class VerifyAuthTokenController : ApiController
    {
        // POST: api/VerifyAuthToken
        public HttpResponseMessage Post(Models.TokenVerificationRequestModel tokenVerificationRequest)
        {
            try
            {
                var errorModel = new Models.ErrorModel
                {
                    InnerException = "string",
                    Message = "string",
                    Code = 0
                };

                var payloadModel = new Models.TokenPayloadModel
                {
                    Name = "Joe",
                    TokenType = "auth"
                };

                var tokenCreationResponse = new Models.TokenVerificationResponseModel
                {
                    Payload = payloadModel,
                    Error = errorModel
                };

                return Request.CreateResponse(HttpStatusCode.OK, tokenCreationResponse);
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
