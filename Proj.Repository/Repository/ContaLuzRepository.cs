using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Proj.Domain.Entities;
using Proj.Repository.Data;
using Proj.Repository.Interfaces;

namespace Proj.Repository.Repository
{
    public class ContaLuzRepository : IContaLuzRepository
    {
        private DataContext context;

        public ContaLuzRepository(DataContext context)
        {
            this.context = context;
        }

        public ContaLuz GetByID(int id)
        {
            return context.ContasLuz.SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<ContaLuz> GetAll()
        {
            return context.ContasLuz.ToList().OrderBy(x => x.id);
        }

        public void Create(ContaLuz imovel)
        {
            context.Entry(imovel).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(ContaLuz imovel)
        {
            context.Entry(imovel).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.ContasLuz.Remove(this.GetByID(id));
            context.SaveChanges();
        }

        public ContaLuz GetMenorConsumo()
        {
            return GetAll().Any() ? GetAll().OrderBy(x => x.kwGasto).First() : null;
        }

        public ContaLuz GetMaiorConsumo()
        {
            return GetAll().Any() ? GetAll().OrderBy(x => x.kwGasto).Last() : null;
        }
    }
}