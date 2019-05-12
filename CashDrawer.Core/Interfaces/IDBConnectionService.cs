using SQLite;

namespace CashDrawer.Core.Interfaces
{
    public interface IDBConnectionService
    {
        SQLiteConnection GetDataBaseConnection();
    }
}