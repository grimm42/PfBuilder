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
            using (IDbConnection dbConnection = new SQLiteConnection(RepositoryUtil.LoadConnectionString()))
            {
                string insertQuery = "INSERT INTO Characters(Name, Player, Age, Gender, Alignment) VALUES (@Name, @Player, @Age, @Gender, @Alignment)";
                dbConnection.Execute(insertQuery, entity);
            }
        }

        public void Delete(Character entity)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(RepositoryUtil.LoadConnectionString()))
            {
                string deleteQuery = "Delete From Characters WHERE Id = @Id";
                dbConnection.Execute(deleteQuery, new
                {
                    entity.Id
                });
            }
        }

        public Character LoadEntity(long id)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(RepositoryUtil.LoadConnectionString()))
            {
                return dbConnection.QuerySingleOrDefault<Character>("Select * From Characters Where Id = @Id", new { Id = id});
            }
        }

        public void Update(Character entity)
        {
            using (IDbConnection dbConnection = new SQLiteConnection(RepositoryUtil.LoadConnectionString()))
            {
                string insertQuery = "UPDATE Characters SET Name = @Name, Player = @Player, Age = @Age, Gender = @Gender, Alignment = @Alignment WHERE Id = @Id";
                dbConnection.Execute(insertQuery, new
                {
                    entity.Name,
                    entity.Player,
                    entity.Age,
                    entity.Gender,
                    entity.Alignment,
                    entity.Id
                });
            }
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
