using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntitiyRepository<T> where T:class,IEntitiy,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null );
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);

      
    }
}
