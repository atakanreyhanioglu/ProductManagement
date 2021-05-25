using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindSqlContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductDetailDto, bool>> filter = null)
        {
            using(NorthwindSqlContext context = new NorthwindSqlContext())
            {
                var result = from p in context.Products
                             join s in context.Suppliers on p.SupplierID equals s.SupplierID
                             join c in context.Categories on p.CategoryID equals c.CategoryID



                             select new ProductDetailDto
                             {
                                 ProductID = p.ProductID,
                                 SupplierID = p.SupplierID,
                                 CategoryID = p.CategoryID,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock,
                                 CategoryName = c.CategoryName,
                                 CompanyName = s.CompanyName,
                                 ContactName = s.ContactName,
                                 City = s.City,
                                 Country = s.Country,
                                 Region = s.Region,
                                 Phone = s.Phone

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
        
    }
}
