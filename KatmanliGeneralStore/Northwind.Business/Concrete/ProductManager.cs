using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.ValidationRule.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    //Busines katmanımızda kurallarımız bulunmaktadır
    public class ProductManager:IProductService //ProductManager cıpklaklığı kalktı
    {
        //EfProductDal _productDal = new EfProductDal();//Bu çıplak hatalı IProductDal bunun için vardır
        //bir katman diğerini newleyemez

        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {

            _productDal = productDal;
            //Bu sayede ister entityframework iste nhibernate arası geçişler daha kolay ve mantıklı
            //Bu sayede en ufak Orm kodu göremeyiz
        }

        public void Add(Product product)
        {
            ValidateTool(product);

            _productDal.Add(product);
        }

        private static void ValidateTool(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            //Validationlara uygunluğu sağlaması
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (DbUpdateException e)
            {

                throw new Exception("Silme Gerçekleşmedi");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId==categoryId).ToList();//şecilen kategori id göre filtreledik
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower())).ToList();
        }

        public void Update(Product product)
        {
            ValidateTool(product);
            //Validationlara uygunluğu sağlaması
            _productDal.Update(product);
        }
    }
}
