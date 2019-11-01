using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Proj.Domain.Entities;
using Proj.Repository.Data;
using Proj.Repository.Interfaces;

namespace Proj.Repository.Repository
{
    public class ImovelRepository : IImovelRepository
    {
        private DataContext context;

        public ImovelRepository(DataContext context)
        {
            this.context = context;
        }

        public Imovel GetByID(int id)
        {
            return context.Imoveis.SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<Imovel> GetAll()
        {
            return context.Imoveis.ToList().OrderBy(x => x.id);
        }

        public void Create(Imovel imovel)
        {
            context.Entry(imovel).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(Imovel imovel)
        {
            context.Entry(imovel).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Imoveis.Remove(this.GetByID(id));
            context.SaveChanges();
        }
    }
}