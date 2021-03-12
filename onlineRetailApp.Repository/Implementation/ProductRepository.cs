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

            _dbContext.Add(product);
            _dbContext.SaveChanges();
        }



        public void Update(Guid id, Product product)
        {
            /*product.Name = product.Name;
            product.AvailableQuantity= product.AvailableQuantity;*/

            var dbProduct = _dbContext.Products.FirstOrDefault(productUpdate => productUpdate.ProductId == id);

            dbProduct.ProductName = product.ProductName;
            dbProduct.AvailableQuantity = product.AvailableQuantity;
            dbProduct.UpdatedDate = product.UpdatedDate;
            dbProduct.UnitPrice = product.UnitPrice;

            _dbContext.Products.Update(dbProduct);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id) {
            Product product = _dbContext.Products.FirstOrDefault(productDelete => productDelete.ProductId == id);
        
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }


    }
}

