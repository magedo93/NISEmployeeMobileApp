using SQLite.Net;

namespace EmployeeMobileApp.AppCode
{
    interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}