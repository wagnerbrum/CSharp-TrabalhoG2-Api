using System.Collections.Generic;
using Proj.Domain.Entities;

namespace Proj.Repository.Interfaces
{
    public interface IRepository<Entity> where Entity : class
    {
        Entity GetByID(int id);
        IEnumerable<Entity> GetAll();
        void Create(Entity entity);
        void Update(Entity entity);
        void Delete(int id);
    }
}