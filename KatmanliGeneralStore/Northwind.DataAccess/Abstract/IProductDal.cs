using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>//Böylece aynı operasyonları yazmayız
    {
        /*List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);*/
        //IEntityRespository ve genericler ile tekrar tekrar yazmamıs engelleriz daha düzgün olur
    }
}
