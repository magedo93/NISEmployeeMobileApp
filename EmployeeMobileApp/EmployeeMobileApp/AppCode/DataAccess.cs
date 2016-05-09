using EmployeeMobileApp.Model;
using SQLite.Net;
using System.Collections.Generic;
using Xamarin.Forms;

namespace EmployeeMobileApp.AppCode
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get <ISQLite> ().GetConnection();
            // create the table(s)
            dbConn.CreateTable<Employee> ();
        }
        public List<Employee> GetAllEmployees()
        {
            return dbConn.Query<Employee>("Select * From [Employee]");
        }
        public int SaveEmployee(Employee aEmployee)
        {
            return dbConn.Insert(aEmployee);
        }
        public int DeleteEmployee(Employee aEmployee)
        {
            return dbConn.Delete(aEmployee);
        }
        public int EditEmployee(Employee aEmployee)
        {
            return dbConn.Update(aEmployee);
        }
    }
}
