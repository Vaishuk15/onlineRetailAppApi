using OnlineRetailApp.Repository.EntityModel;
using System;
using System.Collections.Generic;

namespace OnlineRetailApp.Repository.Interface
{
    public interface IProductRepository
    {

        List<Product> Get();
        Product GetById(Guid id);
        Product GetByName(String name);

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        void UpdateQuantity(Order order);
   
    }
}
