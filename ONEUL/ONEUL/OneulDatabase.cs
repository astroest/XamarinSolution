using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using ONEUL.Model;

namespace ONEUL
{
    public class OneulDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public OneulDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ListItem>().Wait();
        }

        public Task<List<ListItem>> GetOneulsAsync()
        {
            return _database.Table<ListItem>().ToListAsync();
        }

        public Task<ListItem> GetOneulAsync(int id)
        {
            return _database.Table<ListItem>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveOneulAsync(ListItem oneul)
        {
            if (oneul.ID != 0)
            {
                return _database.UpdateAsync(oneul);
            }
            else
            {
                return _database.InsertAsync(oneul);
            }
        }

        public Task<int> DeleteOneulAsync(ListItem oneul)
        {
            return _database.DeleteAsync(oneul);
        }
    }
}

