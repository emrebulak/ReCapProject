using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfClolorDal : IColorDal
    {
        public void Add(Entities.Concrete.Color entity)
        {
            using (ReCapDbContext contex = new ReCapDbContext())
            {
                var addedEntity = contex.Entry(entity);
                addedEntity.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(Entities.Concrete.Color entity)
        {
            using (ReCapDbContext contex = new ReCapDbContext())
            {
                var deletedEntity = contex.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }

        }

        public Entities.Concrete.Color Get(Expression<Func<Entities.Concrete.Color, bool>> filter)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return context.Set<Entities.Concrete.Color>().SingleOrDefault(filter);
            }
        }

        public List<Entities.Concrete.Color> GetAll(Expression<Func<Entities.Concrete.Color, bool>> filter = null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return filter == null ? context.Set<Entities.Concrete.Color>().ToList() : context.Set<Entities.Concrete.Color>().Where(filter).ToList();
            }
        }

        public void Update(Entities.Concrete.Color entity)
        {
            using (ReCapDbContext contex = new ReCapDbContext())
            {
                var updatedEntity = contex.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }
    }
}
