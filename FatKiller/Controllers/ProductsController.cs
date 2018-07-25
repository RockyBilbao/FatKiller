using System;
using System.Collections.Generic;
using AutoMapper;
using FatKiller.Data.Model;
using FatKiller.Services;
using FatKiller.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FatKiller.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ProductViewModel> GetAll()
        {
            var products = _productService.GetAllProducts();
            return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
        }

        //[HttpGet]
        //public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        //{
        //    var products = await _productService.GetAllProductsAsync();
        //    return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
        //}

        [HttpGet("{id}")]
        public ProductViewModel GetProduct(Guid id)
        {
            var product = _productService.GetProduct(id);
            return _mapper.Map<Product, ProductViewModel>(product);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
