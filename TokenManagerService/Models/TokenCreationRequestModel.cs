using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenManagerService.Models
{
    public class TokenCreationRequestModel
    {
        public Models.TokenPayloadModel Payload { get; set; }
        public int ExpiryInHours { get; set; }
    }
}