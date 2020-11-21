﻿using ProductMicroService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroService.Repository
{
   public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productId);
        void InsertProduct(Product product);
        void DeleteProduct(int ProductId);
        void UpdateProduct(Product product);
        void Save();
    }
}
