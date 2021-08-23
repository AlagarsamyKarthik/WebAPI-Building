using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service_Request.Models
{
    public class Output
    {
        public Int32 statuscode { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }
}