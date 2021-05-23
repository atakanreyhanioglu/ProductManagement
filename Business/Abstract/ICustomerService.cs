using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int id);
        IDataResult<List<Customer>> GetByCityName(string cityName);
        IDataResult<List<Customer>> GetByCountryName(string countryName);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);

    }
}
