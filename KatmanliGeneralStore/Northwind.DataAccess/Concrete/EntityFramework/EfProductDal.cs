using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
        
        //Codem Smell engellemek için IDal oluşturduk çıplak referansı engelleriz
        //Farklı Orm db teknoları içinde önemlidir
        //İntheritence yapabliriz
    {
        //EfEntityRepositoryBase sayesinde baseden ana kodlarımızı yazmaya gerek yok

    }
}
