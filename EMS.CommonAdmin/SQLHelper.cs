using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace EMS.CommonAdmin
{
    public class SQLHelper
    {
        SqlConnection Connection = null;
        SqlCommand Command = null;
        SqlDataReader Reader = null;
        IConfiguration Configuration;

        public SQLHelper()
        {
        }
        public void SqlConnection()
        {
            string ConString = Configuration.GetConnectionString("EMS");
            Connection = new SqlConnection(ConString);
            Connection.Open();
        }

        public void SqlCommand()
        {
            Command = new SqlCommand();
            Command.CommandType = System.Data.CommandType.StoredProcedure;
        }
     
    }
}
