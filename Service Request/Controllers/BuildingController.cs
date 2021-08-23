
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Service_Request.Entities;
using Service_Request.Models;
using Service_Request.BusinessEntities;
using Service_Request.BusinessLayer;


namespace Service_Request.Controllers
{
    public class BuildingController : ApiController
    {
        
        //private IBuildingBusinessLayer _objBuildingDAL;
        //public BuildingController(IBuildingBusinessLayer objBuildingDAL)
        //{
        //    _objBuildingDAL = objBuildingDAL;
        //}


        // GET api/<controller>

        [HttpGet]
        [Route("api/GetBuildingDetails")]
        public Output GetBuildingDetails()
        {
            Output result = new Output();
            try
            {
                List<BuildingDO> buildDO = new List<BuildingDO>();
                BuildingBL buildobj = new BuildingBL();
                buildDO = buildobj.GetBuildingDetails_All();
                result.data = buildDO;
                result.message = "Success";
                result.statuscode = 200;
                return result;
            }
            catch (Exception ex)
            {
                result.data = "";
                result.message = ex.Message;
                result.statuscode = 204;
                return result;
                throw ex;
            }
        }

        [HttpPost]
        [Route("api/InsertBuildDetails")]
        public Output InsertBuildDetails(string buildingCode, string description, string currentStatus, string createdBy, DateTime createdDate, string lastModifiedBy, DateTime lastModifiedDate)
        {
            Output result = new Output();
            try
            {
                BuildingDO buildDO = new BuildingDO();
                BuildingBL buildobj = new BuildingBL();
                buildDO = buildobj.SaveBuilding(buildingCode, description, currentStatus, createdBy, createdDate, lastModifiedBy, lastModifiedDate);
                result.message = "Saved Successfully";
                result.statuscode = 200;
                return result;
            }
            catch (Exception ex)
            {
                result.data = "";
                result.message = ex.Message;
                result.statuscode = 404;
                return result;
                throw ex;
            }
        }


        // PUT api/<controller>

        [HttpPut]
        [Route("api/UpdateBuildingDetails")]
        public Output UpdateBuildingDetails(int id,string buildingCode, string description, string currentStatus, string createdBy, DateTime createdDate, string lastModifiedBy, DateTime lastModifiedDate)
        {
            Output result = new Output();
            try
            {
                BuildingDO buildDO = new BuildingDO();
                BuildingBL buildobj = new BuildingBL();
                buildDO = buildobj.UpdateBuilding(id, buildingCode, description, currentStatus, createdBy, createdDate, lastModifiedBy, lastModifiedDate);
                result.message = "Updated Successfully";
                result.statuscode = 200;
                return result;
            }
            catch (Exception ex)
            {
                result.data = "";
                result.message = ex.Message;
                result.statuscode = 400;
                return result;
                throw ex;
            }
        }

        

        // GET api/<controller> ById

        [HttpGet]
        [Route("api/GetBuildingById")]

        public Output GetBuildingById(int Id)
        {
            Output result = new Output();
            try
            {
                BuildingDO buildDO = new BuildingDO();
                BuildingBL buildobj = new BuildingBL();
                buildDO = buildobj.GetBuilding_Id(Id);
                result.data = buildDO;
                result.message = "Success";
                result.statuscode = 201;
                return result;
            }
            catch (Exception ex)
            {
                result.data = "";
                result.message = ex.Message;
                result.statuscode = 404;
                return result;
                throw ex;
            }
        }

        // DELETE api/<controller>

        [HttpDelete]
        [Route("api/DeleteBuildingBy_Id")]

        public Output DeleteBuildingBy_Id(int Id)
        {
            Output result = new Output();
            try
            {
                BuildingDO buildDO = new BuildingDO();
                BuildingBL buildobj = new BuildingBL();
                buildDO = buildobj.DeleteBuilding_Id(Id);
                result.data = buildDO;
                result.message = "Deleted Successfully";
                result.statuscode = 201;
                return result;
            }
            catch (Exception ex)
            {
                result.data = "";
                result.message = ex.Message;
                result.statuscode = 400;
                return result;
                throw ex;
            }
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}