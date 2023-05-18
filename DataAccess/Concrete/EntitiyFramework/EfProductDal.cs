﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entitiy)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntitiy = context.Entry(entitiy);
                addedEntitiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entitiy)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntitiy = context.Entry(entitiy);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entitiy)
        { 
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntitiy = context.Entry(entitiy);
                updatedEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}