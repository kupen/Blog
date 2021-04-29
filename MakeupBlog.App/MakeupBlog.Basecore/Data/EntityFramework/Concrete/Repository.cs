

using MakeupBlog.Basecore.Data.EntityFramework.Abstract;
using MakeupBlog.Basecore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace MakeupBlog.Basecore.Data.EntityFramework.Concrete
{
    public class Repository<TContext, TEntity> : IRepository<TEntity>
        where TEntity : BaseModel
        where TContext : DbContext
    {
        protected TContext ctx;
        public Repository(TContext context)
        {
            ctx = context;
        }
        public bool Delete(TEntity model)
        {
            model.IsDeleted = true;
            model.IsActive = false;
            return ctx.SaveChanges () > 0;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, params string[] includeList)
        {

            List<TEntity> result = null;
            try
            {
                IQueryable<TEntity> query = null;
                if (filter != null)
                {
                    query = ctx.Set<TEntity>().Where(filter);
                }
                else
                {
                    query = ctx.Set<TEntity>();
                }
                foreach (var includeItem in includeList)
                {
                    query = query.Include(includeItem);
                }
                result = query.ToList();
            }
            catch (Exception)
            {
                //TODO: Hata
            }
            return result;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeList)
        {
            IQueryable<TEntity> query = null;
            try
            {
                query = ctx.Set<TEntity>().Where(filter);
                if (includeList != null)
                {
                    foreach (var item in includeList)
                    {
                        query.Include(item);
                    }
                }
                return query.FirstOrDefault();
            }
            catch (Exception)
            {
                throw new Exception("Getiremedi");
            }
        }
        public bool Insert(TEntity model)
        {
            ctx.Set<TEntity>().Add(model);
            return ctx.SaveChanges() > 0;
        }

        public bool Update(TEntity model)
        {
            model.Updated = DateTime.Now;
            ctx.Set<TEntity>().AddOrUpdate(x => x.Id, model);
            return ctx.SaveChanges() > 0;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    ctx.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Repository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

     
    }
}
#endregion