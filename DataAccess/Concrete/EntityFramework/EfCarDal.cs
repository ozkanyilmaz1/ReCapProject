using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
    //    public void Add(Car car)
    //    {
    //        using (RentCarContext context = new RentCarContext())
    //        {
    //            var addedEntity = context.Entry(car);
    //            addedEntity.State = EntityState.Added;
    //            context.SaveChanges();
    //        }
    //    }

    //    public void Delete(Car car)
    //    {
    //        using (RentCarContext context = new RentCarContext())
    //        {
    //            var deletedEntry = context.Entry(car);
    //            deletedEntry.State = EntityState.Deleted;
    //            context.SaveChanges();
    //        }
    //    }

    //    public Car Get(Expression<Func<Car, bool>> filter)
    //    {
    //        using (RentCarContext context = new RentCarContext())
    //        {
    //            return context.Set<Car>().SingleOrDefault(filter);
    //        }
    //    }

        
    //    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    //    {
    //        using (RentCarContext context = new RentCarContext())
    //        {
    //            return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
    //        }
    //    }

    //    public List<Car> GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Uptade(Car car)
    //    {
    //        using (RentCarContext context = new RentCarContext())
    //        {
    //            var uptadedEntry = context.Entry(car);
    //            uptadedEntry.State = EntityState.Modified;
    //            context.SaveChanges();
    //        }
    //    }
    }
}
