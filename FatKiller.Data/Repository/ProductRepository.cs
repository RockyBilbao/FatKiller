using System;
using System.Collections.Generic;
using FatKiller.Data.Interfaces;
using FatKiller.Data.Model;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FatKiller.Data.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : IProductRepository
    {
        private readonly ProjectEntities _productDatabaseContext;

        public ProductRepository(ProjectEntities productDatabaseContext)
        {
            _productDatabaseContext = productDatabaseContext;
        }

        public IQueryable<Product> GetAll()
        {
            return _productDatabaseContext.Product;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await GetAll().ToListAsync();
        }

        public Product GetById(Guid productId)
        {
            var result = _productDatabaseContext.Product.FirstOrDefault(x => x.ProductId == productId);
            if (result != null)
            {
                return result;
            }
            throw new Exception("Product not found."); //todo zmienić treść exception
        }

        public IQueryable<Product> GetWhere(Func<Product, bool> predicate)
        {
            return _productDatabaseContext.Product.Where(predicate).AsQueryable();
        }

        public void Add(Product product)
        {
            if (product == null)
            {
                throw new Exception("Product object cannot be null.");
            }

            _productDatabaseContext.Product.Add(product);
            _productDatabaseContext.SaveChanges();
        }

        public void Delete(Product product)
        {
            if (product == null)
            {
                throw new Exception("Product object cannot be null.");
            }

            _productDatabaseContext.Product.Remove(product);
            _productDatabaseContext.SaveChanges();
        }

        public void Update(Product product)
        {
            if (product == null)
            {
                throw new Exception("Product object cannot be null.");
            }

            _productDatabaseContext.Product.Update(product);
            _productDatabaseContext.SaveChanges();
        }

        public int Count(Func<Product, bool> predicate)
        {
            return _productDatabaseContext.Product.Count();
        }

    }

}
