using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
       where TEntity : class, new()
       where TContext : DbContext, new()
    {
        public bool Add(TEntity entity)
        {

            using (TContext context = new TContext())
            {

                var addedEnttiy = context.Entry(entity);
                addedEnttiy.State = EntityState.Added;
                var result = context.SaveChanges();
                if(result != 0)
                {
                    return true;
                }

                return false;
                
            }

        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {

                return context.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {

                return filter == null
                  ? context.Set<TEntity>().ToList()
                  : context.Set<TEntity>().Where(filter).ToList();

            }


        }

        public bool IsExist(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {

                var result = context.Set<TEntity>().SingleOrDefault(filter);
                if (result == null)
                {
                    return false;
                }
                return true;



            }
        }

        public bool Update(TEntity entity)
        {

            using (TContext context = new TContext())
            {

                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
               var result =  context.SaveChanges();

                if (result != 0)
                {
                    return true;
                }

                return false;

            }

        }
    }
}
