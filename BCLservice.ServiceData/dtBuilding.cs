using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCLservice.ServiceData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Net.NetworkInformation;
    using System.Data.SqlClient;
    using System.Configuration;
    using global::BCLservice.DataStore;

    namespace BCLservice.ServiceData
    {
        public class dtBuilding
        {
            private string _connectionstring = ConfigurationManager.ConnectionStrings["BCLservice.Properties.Settings.dbconnection"].ConnectionString;
            private SqlConnection _connection;

            public dtBuilding()
            {

            }

            
            public static List<BuildingObject> returnBuildingObject()
            {
                BuildingObject obj = new BuildingObject();
                List<BuildingObject> results = new List<BuildingObject>();
                string _connectionstring = ConfigurationManager.ConnectionStrings["BCLservice.Properties.Settings.dbconnection"].ConnectionString;
                SqlConnection _connection = new SqlConnection(_connectionstring);
                BclDbConnection conn = new BclDbConnection();
                SqlCommand scmd = new SqlCommand("BCL_Building_Select", _connection);
                DataTable dt = new DataTable();
                SqlDataAdapter td = new SqlDataAdapter(scmd);
                _connection.Open();
                td.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        obj.PK_Building_Id = dr.Field<int>("PK_Building_Id");
                        obj.Name_Short = dr.Field<string>("Name_Short");
                        obj.Name_Long = dr.Field<string>("Name_Long");
                        results.Add(obj);
                    }
                }

                return results;
            }


        }
    }

}
