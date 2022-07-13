using EMS.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EMS.DataService.Data
{
    public partial class DepartmentData
    {
        SqlConnection Connection = null;
        SqlCommand Command = null;
        SqlDataReader Reader = null;
        private readonly IConfiguration Configuration;

        public DepartmentData(IConfiguration configuration)
        {
            Configuration = configuration;
            string ConString = configuration.GetConnectionString("EMS");
            Connection = new SqlConnection(ConString);
        }

        public List<Department> DBGetAllDepartment()
        {
            List<Department> departments = new List<Department>();
            try
            {
                Command = new SqlCommand("GetAll_Department", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Department department = new Department();
                    department.DepartmentId = (int)Reader["DepartmentId"];
                    department.DepartmentName = Reader["DepartmentName"].ToString();
                    departments.Add(department);
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
            return departments;
        }

    }
}
