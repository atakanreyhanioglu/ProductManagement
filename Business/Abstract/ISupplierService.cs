using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        IDataResult<List<Supplier>> GetAll();
        IDataResult<Supplier> GetById(int id);
        IDataResult<List<Supplier>> GetByCityName(string cityName);
        IDataResult<List<Supplier>> GetByCountryName(string countryName);
        IResult Add(Supplier supplier);
        IResult Update(Supplier supplier);
        IResult Delete(Supplier supplier);

    }
}
