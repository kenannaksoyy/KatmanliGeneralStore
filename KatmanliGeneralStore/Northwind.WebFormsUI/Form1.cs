using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        //arayüz katmanında sadece arayüz kodları olur katmanlı önemli
        public Form1()
        {
            InitializeComponent();

            //_productService = new ProductManager(new EfProductDal());//çıplaklık kalktı
            //_categoryService = new CategoryManager(new EfCategoryDal());
            //Bir katman diğerine newleyemez bunu IOC container Ninject ile çözcez

            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            //Bağılılık 0a indi
        }
        private IProductService _productService;//Iproductservis ile düzeltioz
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";//kategori ismi görüncek
            cbxCategory.ValueMember = "CategoryId";//ama secimde id lazım

            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //Entity ile çalışcaz belirttik
            //ProductManager cıplak olmıcak IProductServis ile düzelttik

            //ProductManager productManager2 = new ProductManager(new EhProductDal());
            //farklı Ormlere geçişler kolaylastı

            dgwProducts.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {     
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProducts.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                    ProductName = tbxProductNameAdd.Text,
                    QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmountAdd.Text)

                });
                MessageBox.Show("Ürün Eklendi");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                ProductName = tbxProductNameUpdate.Text,
                QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                UnitsInStock = Convert.ToInt16(tbxStockAmountUpdate.Text)

            });
            MessageBox.Show("Ürün Güncellendi");
            LoadProducts();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProducts.CurrentRow;
            tbxProductNameUpdate.Text = row.Cells[1].Value.ToString();
            cbxCategoryUpdate.SelectedValue = row.Cells[2].Value;
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            tbxStockAmountUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgwProducts.CurrentRow != null)//secim yoksa
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi");
                    LoadProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
