using MyWebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApi.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product1", Price = 10.0M },
            new Product { Id = 2, Name = "Product2", Price = 20.0M },
        };

        public IEnumerable<Product> GetAll() => _products;

        public Product GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product) => _products.Add(product);

        public void Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                _products[index] = product;
            }
        }

        public void Delete(int id) => _products.RemoveAll(p => p.Id == id);
    }
}
