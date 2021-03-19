using OnlineRetailApp.Repository.EntityModel;
using OnlineRetailApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRetailApp.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {

        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Product> Get()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetById(Guid id)
        {
            return _dbContext.Products
                  .FirstOrDefault(product => product.ProductId == id);
        }

        public Product GetByName(string name)
        {
            return _dbContext.Products
                  .FirstOrDefault(product => product.ProductName == name);
        }

        public void Add(Product product)
        {

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }



        public void Update( Product product)
        {

          _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
        }

        public void Delete(Product product) {
          
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public void UpdateQuantity(Order order)
        {

            Product product = GetById(order.ProductId);
            product.AvailableQuantity -= order.Quantity;
            _dbContext.SaveChanges();
        }

    }
}

