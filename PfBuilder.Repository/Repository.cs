using PfBuilder.Infrastructure.Entity;

namespace PfBuilder.Repository
{
    public class Repository : IRepository<EntityBase>
    {
        public void Create(EntityBase entity)
        {
        }

        public void Delete(EntityBase entity)
        {
        }

        public EntityBase GetById(long id)
        {
            return new EntityBase();
        }

        public void Update(EntityBase entity)
        {
        }
    }
}
