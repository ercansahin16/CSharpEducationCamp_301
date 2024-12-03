using C_EducationCamp.DataAccessLayer.Abstrack;
using C_EducationCamp.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EducationCamp.DataAccessLayer.Repositories
{
   public class GenericRepository<T> : IGenericDal<T> where T : class
   {
      CampContext context=new CampContext();

      private readonly DbSet<T> _object;

      public GenericRepository()
      {
         _object=context.Set<T>();
      }

      public void Delete(T entity)
      {
         var deleteEntity=context.Entry(entity);
         deleteEntity.State= EntityState.Deleted;
         context.SaveChanges();
      }

      public List<T> GetAll()
      {
         return _object.ToList();
      }

      public T GetById(int id)
      {
        return _object.Find(id);
      }

      public void Insert(T entity)
      {
         var AddEntity=context.Entry(entity);
         AddEntity.State= EntityState.Added;
         context.SaveChanges();
      }

      public void Update(T entity)
      {
         var UpdateEntity=context.Entry(entity);
         UpdateEntity.State= EntityState.Modified;
         context.SaveChanges();
      }
   }
}
