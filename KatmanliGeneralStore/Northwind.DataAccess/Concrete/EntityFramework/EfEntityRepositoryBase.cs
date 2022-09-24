using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext : DbContext,new()
        //Contextlerimiz farklı veriler farklı old. için genericler yaptık
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);//ilgiliye nesneye erişcek kod ona abone old
                addedEntity.State = EntityState.Added;//Sonra yeni eklenecek olarak işaretledik
                context.SaveChanges();//kaydettik
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);//ilgiliye nesneye erişcek kod ona abone oldu
                deletedEntity.State = EntityState.Deleted;//Sonra delete olarak işaretledik
                context.SaveChanges();//kaydettik
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                
                return context.Set<TEntity>().SingleOrDefault(filter);
                //filtremizi koyduk
                //Tamamen generic çalısıoz
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())//TContext ile iştediğimiz contextle calısırız
            {
                return filter==null?context.Set<TEntity>().ToList()://fitreyoksa
                context.Set<TEntity>().Where(filter).ToList();//filtrevarsa
                //Tamamen generic calısıoz
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var uptadedEntity = context.Entry(entity);//ilgiliye nesneye erişcek kod ona abone oldu
                uptadedEntity.State = EntityState.Modified;//Sonra update olarak işaretledik
                context.SaveChanges();//kaydettik
            }
        }
    }
}
