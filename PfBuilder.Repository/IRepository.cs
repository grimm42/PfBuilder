using System.Collections.ObjectModel;

namespace PfBuilder.Repository
{
    public interface IRepository<T>
    {
        T LoadEntity(long id);

        ObservableCollection<T> LoadEntityCollection();

        void Insert(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
