using CashDrawer.Core.Interfaces;
using SQLite;
using System.IO;

namespace CashDrawer.Droid.Services
{
    class DBConnectionService : IDBConnectionService
    {
        private string _dbName = "CashDrawerDB.db";

        public SQLiteConnection GetDataBaseConnection()
        {
            string path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), _dbName);
            return new SQLiteConnection(path);
        }
    }
}