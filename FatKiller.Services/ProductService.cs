using FatKiller.Data.Model;
using FatKiller.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace FatKiller.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Product GetProduct(Guid productId);
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll().AsEnumerable();
        }

        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return _productRepository.GetAllAsync();
        }

        public Product GetProduct(Guid productId)
        {
            return _productRepository.GetById(productId);
        }
    }
}
