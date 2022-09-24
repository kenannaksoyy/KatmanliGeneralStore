using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Northwind.Business.ValidationRule.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>//Validation ile ürün için kurallar gerçekleşcek iş katmanında olmalı
    {
        //fluent validation kuralları hazır var bir çoğu
        public ProductValidator()
        {
            //Kurallarımızı yazıyoruz

            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz");//ürün ismi girilmeli
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);//fiyat 0dan büyük olmalı
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);//Urünt stokta yok vb.//int16 short
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);//categoy id 2 ise stok 10 büyük olmalı

            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün adı A ile başlamalı");//Kendi kuralımızı böyle yazarız metotu söyleyerek
            //metot func olarak çalışıyor
        }

        private bool StartWithA(string arg)//kendi kuralımızı yazıyoruz
        {
            return arg.StartsWith("A");//A ile başlarsa true döner yoksa false
        }
    }
}
