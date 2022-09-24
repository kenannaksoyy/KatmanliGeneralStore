using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService//ProductManagerda cıplak kalmamalı
    {
        List<Product> GetAll();
        List<Product> GetProductsByProductName(string productName);
        List<Product> GetProductsByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
