using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;
        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }
        public IResult Add(Supplier supplier)
        {
            _supplierDal.Add(supplier);
            return new SuccessResult(Messages.SupplierAdded);
        }

        public IResult Delete(Supplier supplier)
        {
            _supplierDal.Delete(supplier);
            return new SuccessResult(Messages.SupplierDeleted);
        }

        public IDataResult<List<Supplier>> GetAll()
        {
            return new SuccessDataResult<List<Supplier>>(_supplierDal.GetAll(), Messages.AllSuppliersListed);
        }

        public IDataResult<List<Supplier>> GetByCityName(string cityName)
        {
            return new SuccessDataResult<List<Supplier>>(_supplierDal.GetAll(p=>p.City == cityName), Messages.AllSuppliersListedByCityName);

        }

        public IDataResult<List<Supplier>> GetByCountryName(string countryName)
        {
            return new SuccessDataResult<List<Supplier>>(_supplierDal.GetAll(p => p.Country == countryName), Messages.AllSuppliersListedByCountryName);
        }

        public IDataResult<Supplier> GetById(int id)
        {
            return new SuccessDataResult<Supplier>(_supplierDal.Get(p => p.SupplierID == id));
        }

        public IResult Update(Supplier supplier)
        {
            _supplierDal.Update(supplier);
            return new SuccessResult(Messages.SupplierUpdated);
        }

    }
}
