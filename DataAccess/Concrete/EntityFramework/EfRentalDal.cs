using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join customer in context.Customers
                             on r.CustomerId equals customer.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 RentalId = r.Id,
                                 CompanyName = customer.CompanyName,
                                 RentDate = (DateTime)r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 BrandName = c.Brand,
                                 CustomerName = user.FirstName,
                                 CustomerLastName = user.LastName,
                                 

                             };

                return result.ToList();

            }
        }
    }
}
