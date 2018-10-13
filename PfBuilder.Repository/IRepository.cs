namespace PfBuilder.Repository
{
    public interface IRepository<T>
    {
        T GetById(long id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
