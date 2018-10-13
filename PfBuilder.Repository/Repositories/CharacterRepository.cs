using Dapper;
using PfBuilder.Models.Entities;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace PfBuilder.Repository.Repositories
{
    public class CharacterRepository : IRepository<Character>
    {
        public void Create(Character entity)
        {
        }

        public void Delete(Character entity)
        {
        }

        public Character GetById(long id)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                Character output = dbConnection.QuerySingle<Character>("Select * From Characters Where Id = @Id", new { Id = id});
                return output;
            }
        }

        public void Update(Character entity)
        {
        }

        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
    }
}
