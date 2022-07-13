using EMS.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EMS.DataService.Data
{
    public partial class DesignationData
    {
        SqlConnection Connection = null;
        SqlCommand Command = null;
        SqlDataReader Reader = null;
        private readonly IConfiguration Configuration;

        public DesignationData(IConfiguration configuration)
        {
            Configuration = configuration;
            string ConString = configuration.GetConnectionString("EMS");
            Connection = new SqlConnection(ConString);
        }

        public List<Designation> DBGetAllDesignation()
        {
            List<Designation> designations = new List<Designation>();
            try
            {
                Command = new SqlCommand("GetAll_Designation", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Designation designation = new Designation();
                    designation.DesignationId = (int)Reader["DesignationId"];
                    designation.DesignationName = Reader["DesignationName"].ToString();
                    designations.Add(designation);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Reader.Close();
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
            return designations;
        }

    }
}
