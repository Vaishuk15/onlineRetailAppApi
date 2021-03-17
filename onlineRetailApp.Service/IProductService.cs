using OnlineRetailApp.Models.ViewModel;
using OnlineRetailApp.Repository.EntityModel;
using System;
using System.Collections.Generic;

namespace OnlineRetailApp.Services.Interface
{
    public interface IProductService
    {
        List<Product> Get();
        Product GetById(Guid id);
        Product GetByName(String name);

        void Add(ProductViewModel productViewModel);

      

        void Update(Guid id,ProductViewModel productViewModel);
        
        void Delete(Product product);
    }
}
