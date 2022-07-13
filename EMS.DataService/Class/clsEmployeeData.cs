using EMS.CommonAdmin;
using EMS.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EMS.DataService.Data
{
    public partial class EmployeeData
    {

        SqlConnection Connection = null;
        SqlCommand Command = null;
        SqlDataReader Reader = null;
        private readonly IConfiguration Configuration;

        public EmployeeData(IConfiguration configuration)
        {
            Configuration = configuration;
            string ConString = configuration.GetConnectionString("EMS");
            Connection = new SqlConnection(ConString);
        }

        public List<Employee> DBGetAllEmployee()
        {

            List<Employee> employees = new List<Employee>();

            try
            {
                
                Command = new SqlCommand("GetAll_Employees", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Employee emp = new Employee();
                    emp.EmployeeId = (int)Reader["EmployeeId"];
                    emp.FirstName = Reader["FirstName"].ToString();
                    emp.MiddleName = Reader["MiddleName"].ToString();
                    emp.LastName = Reader["LastName"].ToString();
                    emp.Salary = (int)Reader["Salary"];
                    emp.DOB = (DateTime)Reader["DOB"];
                    emp.Gender = (int)Reader["Gender"];
                    emp.Hobbies = Reader["Hobbies"].ToString();
                    emp.DepartmentName = Reader["DepartmentName"].ToString();
                    emp.DesignationName = Reader["DesignationName"].ToString();
                    employees.Add(emp);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Reader.Close();
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
            return employees;

        }

        public Employee DBGetById(int id)
        {
            Employee emp = new Employee();
            try
            {
                Command = new SqlCommand("GetByIdEmployee", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@EmployeeId", id);
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    
                    emp.EmployeeId = (int)Reader["EmployeeId"];
                    emp.FirstName = Reader["FirstName"].ToString();
                    emp.MiddleName = Reader["MiddleName"].ToString();
                    emp.LastName = Reader["LastName"].ToString();
                    emp.Salary = (int)Reader["Salary"];
                    emp.DOB = (DateTime)Reader["DOB"];
                    emp.Gender = (int)Reader["Gender"];
                    emp.Hobbies = Reader["Hobbies"].ToString();
                    emp.DepartmentName = Reader["DepartmentName"].ToString();
                    emp.DesignationName = Reader["DesignationName"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Reader.Close();
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
            return emp;

        }

        #region CREATE UPDATE DELETE
        public void DBCreateEmployee(Employee employee)
        {
            try
            {
                Command = new SqlCommand("Create_Employee", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                Command.Parameters.AddWithValue("@MiddleName", employee.MiddleName);
                Command.Parameters.AddWithValue("@LastName", employee.LastName);
                Command.Parameters.AddWithValue("@Salary", employee.Salary);
                Command.Parameters.AddWithValue("@DOb", employee.DOB);
                Command.Parameters.AddWithValue("@Gender", employee.Gender);
                Command.Parameters.AddWithValue("@Hobbies", employee.Hobbies);
                Command.Parameters.AddWithValue("@DeptId", employee.DeptId);
                Command.Parameters.AddWithValue("@DesgnId", employee.DesgnId);
                Connection.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
        }

        public void DBUpdateEmployee(Employee employee)
        {
            try
            {
                Command = new SqlCommand("Update_Employee", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                Command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                Command.Parameters.AddWithValue("@MiddleName", employee.MiddleName);
                Command.Parameters.AddWithValue("@LastName", employee.LastName);
                Command.Parameters.AddWithValue("@Salary", employee.Salary);
                Command.Parameters.AddWithValue("@DOB", employee.DOB);
                Command.Parameters.AddWithValue("@Gender", employee.Gender);
                Command.Parameters.AddWithValue("@Hobbies", employee.Hobbies);
                Command.Parameters.AddWithValue("@DeptId", employee.DeptId);
                Command.Parameters.AddWithValue("@DesgnId", employee.DesgnId);

                Connection.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }
        }

        public void DBDeleteEmployee(int id)
        {

            try
            {

                Command = new SqlCommand("Delete_Employee", Connection);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("EmployeeId", id));
                Connection.Open();
                Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }

        }

        #endregion

    }
}
