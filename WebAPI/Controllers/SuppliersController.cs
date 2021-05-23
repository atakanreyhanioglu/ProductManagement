﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        ISupplierService _supplierService;
        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _supplierService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _supplierService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycityname")]
        public IActionResult GetByCityName(string cityName)
        {
            var result = _supplierService.GetByCityName(cityName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycountryname")]
        public IActionResult GetByCountryName(string countryName)
        {
            var result = _supplierService.GetByCountryName(countryName);
            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Supplier supplier)
        {
            var result = _supplierService.Add(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }
        [HttpPost("update")]
        public IActionResult Update(Supplier supplier)
        {
            var result = _supplierService.Update(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Supplier supplier)
        {
            var result = _supplierService.Delete(supplier);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
