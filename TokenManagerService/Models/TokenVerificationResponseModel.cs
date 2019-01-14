using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenManagerService.Models
{
    public class TokenVerificationResponseModel
    {
        public Models.TokenPayloadModel Payload { get; set; }
        public Models.ErrorModel Error { get; set; }
    }
}