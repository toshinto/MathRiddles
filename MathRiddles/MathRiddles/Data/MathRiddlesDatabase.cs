using MathRiddles.Models;
using SQLite;

namespace MathRiddles.Data
{
    public class MathRiddlesDatabase
    {
        readonly SQLiteAsyncConnection database;

        public MathRiddlesDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }
    }
    
}
