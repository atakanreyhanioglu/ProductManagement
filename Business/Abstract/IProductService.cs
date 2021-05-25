using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<ProductDetailDto>> GetAllProductsDetails();
        IDataResult<List<ProductDetailDto>> GetProductDetailsByProductId(int productId);
        IDataResult<List<ProductDetailDto>> GetAllProductsByCategoryId(int categoryId);
        IDataResult<List<ProductDetailDto>> GetAllProductsBySupplierId(int supplierId);
        IDataResult<List<Product>> GetByCategoryId(int categoryId);
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetAll(); 
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);


    }
}
