using Service_Request.BusinessEntities;
using Service_Request.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service_Request.BusinessLayer
{
    public class BuildingBL
    {

        public List<BuildingDO> GetBuildingDetails_All()
        {
            try
            {
                return BuildingDAL.GetBuildingDetails();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BuildingDO GetBuilding_Id(int Id)
        {
            try
            {
                return BuildingDAL.GetBuildingBy_Id(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BuildingDO SaveBuilding(string buildingCode, string description, string currentStatus,string createdBy, DateTime createdDate, string lastModifiedBy, DateTime lastModifiedDate)
        {
            try
            {
                return BuildingDAL.SaveBuilding_Details( buildingCode,  description,  currentStatus, createdBy,  createdDate,  lastModifiedBy,  lastModifiedDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BuildingDO UpdateBuilding(int id,string buildingCode, string description, string currentStatus, string createdBy, DateTime createdDate, string lastModifiedBy, DateTime lastModifiedDate)
        {
            try
            {
                return BuildingDAL.UpdateBuilding_Details(id, buildingCode, description, currentStatus, createdBy, createdDate, lastModifiedBy, lastModifiedDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }     

   
        public BuildingDO DeleteBuilding_Id(int Id)
        {
            try
            {
                return BuildingDAL.DeleteBuildingBy_Id(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
              

        
    }
}