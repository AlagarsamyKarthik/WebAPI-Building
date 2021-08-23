using Service_Request.BusinessEntities;
using Service_Request.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Service_Request.DataLayer
{
    public class BuildingDAL
    {
              
        public static BuildingDO SaveBuilding_Details(string buildingCode, string description, string currentStatus, string createdBy, DateTime createdDate, string lastModifiedBy, DateTime lastModifiedDate)
        {
            BuildingDO build = new BuildingDO();
            try
            {               
                string Constr = ConfigurationManager.ConnectionStrings["BuildingConnection"].ConnectionString;
                DataTable dt = new DataTable();
                using (var con = new SqlConnection(Constr))
                using (var cmd = new SqlCommand("sp_SaveBuilding", con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@buildingCode", buildingCode);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@currentStatus", currentStatus);
                    cmd.Parameters.AddWithValue("@createdBy", createdBy);
                    cmd.Parameters.AddWithValue("@createdDate", createdDate);
                    cmd.Parameters.AddWithValue("@lastModifiedBy", lastModifiedBy);
                    cmd.Parameters.AddWithValue("@lastModifiedDate", lastModifiedDate);
                    cmd.ExecuteNonQuery();   

                }
                return build;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static BuildingDO UpdateBuilding_Details(int id,string buildingCode, string description, string currentStatus, string createdBy, DateTime createdDate, string lastModifiedBy, DateTime lastModifiedDate)
        {
            BuildingDO build = new BuildingDO();
            try
            {
                
                string Constr = ConfigurationManager.ConnectionStrings["BuildingConnection"].ConnectionString;
                DataTable dt = new DataTable();
                using (var con = new SqlConnection(Constr))
                using (var cmd = new SqlCommand("sp_UpdateBuilding", con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@buildingCode", buildingCode);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@currentStatus", currentStatus);
                    cmd.Parameters.AddWithValue("@createdBy", createdBy);
                    cmd.Parameters.AddWithValue("@createdDate", createdDate);
                    cmd.Parameters.AddWithValue("@lastModifiedBy", lastModifiedBy);
                    cmd.Parameters.AddWithValue("@lastModifiedDate", lastModifiedDate);
                    cmd.ExecuteNonQuery();

                }
                return build;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static  List<BuildingDO> GetBuildingDetails()
            
        {
            List<BuildingDO> buildList = new List<BuildingDO>();
            try
            {
               
                string Constr = ConfigurationManager.ConnectionStrings["BuildingConnection"].ConnectionString;
                DataTable dt = new DataTable();
                using (var con = new SqlConnection(Constr))
                using (var cmd = new SqlCommand("sp_Building", con))               
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.Fill(dt);                   
                }

                if(dt.Rows.Count>0)
                {                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        BuildingDO _build = new BuildingDO();
                        _build.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                        _build.buildingCode = dt.Rows[i]["buildingCode"].ToString();
                        _build.description = dt.Rows[i]["description"].ToString();                      
                        int value = Convert.ToInt32(dt.Rows[i]["currentStatus"].ToString());
                        var enumDisplayStatus = (CurrentStatus)value;                     
                        string stringValue = enumDisplayStatus.ToString();
                        _build.currentStatus = stringValue;
                        _build.createdBy = dt.Rows[i]["createdBy"].ToString();
                        _build.createdDate = Convert.ToDateTime(dt.Rows[i]["createdDate"].ToString());
                        _build.lastModifiedBy = dt.Rows[i]["lastModifiedBy"].ToString();
                        _build.lastModifiedDate = Convert.ToDateTime(dt.Rows[i]["lastModifiedDate"].ToString());
                        buildList.Add(_build);
                       
                    }
                }
                return buildList;
            }           
            
            catch (Exception ex)
            {
                throw ex;
            }
          
        }


        public static BuildingDO GetBuildingBy_Id(int Id)
        {
            BuildingDO _build = new BuildingDO();
            try
            {

                string Constr = ConfigurationManager.ConnectionStrings["BuildingConnection"].ConnectionString;
                DataTable dt = new DataTable();
                using (var con = new SqlConnection(Constr))
                using (var cmd = new SqlCommand("sp_GetBuildingBy_Id", con))
                using (var da = new SqlDataAdapter())
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    _build.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    _build.buildingCode = dt.Rows[0]["buildingCode"].ToString();
                    _build.description = dt.Rows[0]["description"].ToString();
                    int value = Convert.ToInt32(dt.Rows[0]["currentStatus"].ToString());
                    var enumDisplayStatus = (CurrentStatus)value;
                    string stringValue = enumDisplayStatus.ToString();
                    _build.createdBy = dt.Rows[0]["createdBy"].ToString();
                    _build.createdDate = Convert.ToDateTime(dt.Rows[0]["createdDate"].ToString());
                    _build.lastModifiedBy = dt.Rows[0]["lastModifiedBy"].ToString();
                    _build.lastModifiedDate = Convert.ToDateTime(dt.Rows[0]["lastModifiedDate"].ToString());
                }
                return _build;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static BuildingDO DeleteBuildingBy_Id(int Id)
        {
            BuildingDO _build = new BuildingDO();
            try
            {
              
                string Constr = ConfigurationManager.ConnectionStrings["BuildingConnection"].ConnectionString;
                DataTable dt = new DataTable();
                using (var con = new SqlConnection(Constr))
                using (var cmd = new SqlCommand("sp_DeleteBuildingBy_Id", con))
                using (var da = new SqlDataAdapter())
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }

             
                return _build;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

       
    }
}