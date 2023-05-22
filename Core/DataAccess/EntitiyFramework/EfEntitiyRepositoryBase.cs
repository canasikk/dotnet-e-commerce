using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntitiyFramework
{
    public class EfEntitiyRepositoryBase<TEntitiy,TContext>:IEntitiyRepository<TEntitiy>
        where TEntitiy: class, IEntitiy, new()
        where TContext: DbContext, new()
    {
        public void Add(TEntitiy entitiy)
        {
            using (TContext context = new TContext())
            {
                var addedEntitiy = context.Entry(entitiy);
                addedEntitiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntitiy entitiy)
        {
            using (TContext context = new TContext())
            {
                var deletedEntitiy = context.Entry(entitiy);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntitiy Get(Expression<Func<TEntitiy, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntitiy>().SingleOrDefault(filter);
            }
        }

        public List<TEntitiy> GetAll(Expression<Func<TEntitiy, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntitiy>().ToList()
                    : context.Set<TEntitiy>().Where(filter).ToList();
            }
        }

        public void Update(TEntitiy entitiy)
        {
            using (TContext context = new TContext())
            {
                var updatedEntitiy = context.Entry(entitiy);
                updatedEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
