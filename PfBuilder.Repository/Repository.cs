using PfBuilder.Infrastructure.Entity;

namespace PfBuilder.Repository
{
    public class Repository : IRepository<EntityBase>
    {
        public void Insert(EntityBase entity)
        {
        }

        public void Delete(EntityBase entity)
        {
        }

        public EntityBase LoadEntity(long id)
        {
            return new EntityBase();
        }

        public void Update(EntityBase entity)
        {
        }
    }
}
