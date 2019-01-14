using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenManagerService.Models
{
    public class HealthModel
    {
        public Models.ErrorModel Error { get; set; }
        public string message { get; set; }
        public enum health { green, yellow, red };
        public string Health { get; set; }
    }
}