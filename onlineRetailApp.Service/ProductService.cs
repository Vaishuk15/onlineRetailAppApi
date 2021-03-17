using OnlineRetailApp.Models.ViewModel;
using OnlineRetailApp.Repository.EntityModel;
using OnlineRetailApp.Repository.Interface;
using OnlineRetailApp.Services.Interface;
using System;
using System.Collections.Generic;


namespace OnlineRetailApp.Services.Implementation
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        //private readonly object _dbcontext;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public List<Product> Get()
        {
            return _productRepository.Get();
        }

        public Product GetById(Guid id)
        {
            return _productRepository.GetById(id);
        }


        public Product GetByName(String name)
        {
            return _productRepository.GetByName(name);
        }
        public void Add(ProductViewModel productViewModel)
        {

            var product = new Product()
            {
                ProductName = productViewModel.ProductName,
                //ProductId = productViewModel.ProductId,
                AvailableQuantity = productViewModel.AvailableQuantity,
                 /* CreatedDate= productViewModel.CreatedDate,*/
                  CreatedDate=DateTime.UtcNow,
                UnitPrice = productViewModel.UnitPrice


        };

            _productRepository.Add(product);


        }

       public void Delete(Product product)
        {
          

            _productRepository.Delete(product);
          
            

        }

        public void Update(Guid id,ProductViewModel productViewModel)
        {

         

            var productToUpdate = GetById(id);
            productToUpdate.ProductName = productViewModel.ProductName;
            productToUpdate.AvailableQuantity = productViewModel.AvailableQuantity;
            productToUpdate.UpdatedDate = DateTime.UtcNow;
            productToUpdate.UnitPrice = productViewModel.UnitPrice;
            _productRepository.Update(productToUpdate);
            
        }
    }
}
