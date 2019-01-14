using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenManagerService.Models
{
    public class TokenCreationResponseModel
    {
        public string Token { get; set; }
        public Models.ErrorModel Error { get; set; }
    }
}