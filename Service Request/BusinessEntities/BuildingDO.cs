using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service_Request.BusinessEntities
{
    public class BuildingDO
    {
        public Int32 Id { get; set; }
        public string buildingCode { get; set; }
        public string description { get; set; }
        public string currentStatus { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public string lastModifiedBy { get; set; }
        public DateTime lastModifiedDate { get; set; }
    }
}