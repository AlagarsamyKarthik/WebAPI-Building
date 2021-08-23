using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service_Request.Entities
{
    public enum CurrentStatus
    {
        NotApplicable = 0,
        Created = 1,
        InProgress = 2,
        Complete = 3,
        Canceled = 4,
    }
}