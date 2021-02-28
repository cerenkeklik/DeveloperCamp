using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    // kısıtlamaların sebebi programcı bizim altyapılarımızı doğru bir şekilde 
    //kullansın diye yönlendirmek
    public class EfEntityRepositoryBase<TEntity,TContext>: IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext: DbContext, new()
    {
        //NuGet - .NET ortamındaki kullanabileceğimiz paketleri barındıran yer
        //ADO.NET - DBye bağlanmamızı sağlayan, dbyi kontrol etmemizi sağlayan, sorgu yazmamızı sağlayan bir kütüphane.
        //Bununla yazdığımız kodlar yorucu bu yüzden süreçleri kolaylaştırmak ve oop ile ilişkiyi sağlayıp kolaylaştırmak için ORM kullanırız.
        //ORM - Entity Framework bir ORM dir- Object Relational Mapping
        public void Add(TEntity entity)
        {
            //IDisponsable pattern implementation on C#
            //Using bittiği anda bellekten contexti temizle. Garbage collectoru bekleme. Yer kaplamasın.
            using (TContext context = new TContext())
            {

                var addedEntity = context.Entry(entity);// referansı yakala
                addedEntity.State = EntityState.Added; //ekleneceğini bildir
                context.SaveChanges(); // ekle 
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                var deletedEntity = context.Entry(entity);// referansı yakala
                deletedEntity.State = EntityState.Deleted; //silineceğini bildir
                context.SaveChanges(); // sil 
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

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                var updatedEntity = context.Entry(entity);// referansı yakala
                updatedEntity.State = EntityState.Modified; //güncelleneceğini bildir
                context.SaveChanges(); // güncelle
            }
        }
    }
}
