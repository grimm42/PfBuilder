using Dapper;
using PfBuilder.Models.Entities;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;

namespace PfBuilder.Repository.Repositories
{
    public class CharacterRepository : IRepository<Character>
    {
        public void Insert(Character entity)
        {
        }

        public void Delete(Character entity)
        {
        }

        public Character LoadEntity(long id)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(RepositoryUtil.LoadConnectionString()))
            {
                Character output = dbConnection.QuerySingle<Character>("Select * From Characters Where Id = @Id", new { Id = id});
                return output;
            }
        }

        public void Update(Character entity)
        {
        }

        public ObservableCollection<Character> LoadEntityCollection()
        {
            using (IDbConnection dbConnection = new SQLiteConnection(RepositoryUtil.LoadConnectionString()))
            {
                var output = dbConnection.Query<Character>("Select * From Characters");
                return new ObservableCollection<Character>(output);
            }
        }
    }
}
