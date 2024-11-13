using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace BCLservice.ServiceData
{
    using System.Data;
    using System.Net.NetworkInformation;
    using System.Data.SqlClient;
    using System.Configuration;
    using global::BCLservice.DataStore;

    public class dtTableOptions_Services
    {
        private string _connectionstring = ConfigurationManager.ConnectionStrings["BCLservice.Properties.Settings.dbconnection"].ConnectionString;
        private SqlConnection _connection;

        public dtTableOptions_Services()
        {

        }

        public static List<BuildingOptionsObject> returnBuildingOptionsObject()
        {
            BuildingOptionsObject obj = new BuildingOptionsObject();
            List<BuildingOptionsObject> results = new List<BuildingOptionsObject>();
            string _connectionstring = ConfigurationManager.ConnectionStrings["BCLservice.Properties.Settings.dbconnection"].ConnectionString;
            SqlConnection _connection = new SqlConnection(_connectionstring);
            BclDbConnection conn = new BclDbConnection();
            SqlCommand scmd = new SqlCommand("BCL_BuildingOptions_Select", _connection);
            DataTable dt = new DataTable();
            SqlDataAdapter td = new SqlDataAdapter(scmd);
            _connection.Open();
            td.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    obj = new BuildingOptionsObject();
                    obj.Value = dr.Field<int>("PK_Building_Id");
                    obj.DisplayText = dr.Field<string>("Name_Short");
                    results.Add(obj);
                }
            }
            return results;
        }
    }
}
