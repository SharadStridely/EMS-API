using System;

namespace EMS.Model
{
    public enum Hobbies
    {
        Cricket, Chess, Listen_Music, Reading, Singing 
    }
    public class Employee 
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public DateTime DOB { get; set; }
        public int Gender { get; set; }
        public string Hobbies { get; set; }
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
        public int DesgnId { get; set; }
        public string DesignationName { get; set; }
        public bool IsDeleted { get; set; }

    }
}
