using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concreate;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public FrmProduct()
        {
            _productService = new ProductManager(new EFProducktDal());
            _categoryService = new CategoryManager(new EFCategoryDal());
            InitializeComponent();
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var AllGetCategories = _categoryService.TGetAll();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = AllGetCategories;
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btn_EFWithListeleme_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deletedProduckt = _productService.TGetById(id);
            _productService.TDelete(deletedProduckt);
            MessageBox.Show("Silme İşlemi Gerçekleşti");
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtName.Text;
            product.ProductStock = Convert.ToInt32(numStock.Value);
            product.ProductPrice = Convert.ToDecimal(txtPrice.Text);
            product.CategoryID = (int)cmbCategory.SelectedValue;
            product.ProductDescription = "TEST";

            _productService.TInsert(product);
            MessageBox.Show("Ekleme İşlemi Gerçekleşti");
        }

        private void btn_IdGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var Products = _productService.TGetById(id);


            dataGridView1.DataSource = new List<object>
            {
                new
                {
                    Name =  Products.ProductName,
                    Stock = Products.ProductStock,
                    Price = Products.ProductPrice,
                    Description = Products.ProductDescription,
                    CategoryName= Products.Category.CategoryName,
                }
            };
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var UpdatedProducts = _productService.TGetById(id);

            UpdatedProducts.ProductName = txtName.Text;
            UpdatedProducts.ProductStock = Convert.ToInt32(numStock.Value);
            UpdatedProducts.ProductPrice = Convert.ToDecimal(txtPrice.Text);
            UpdatedProducts.CategoryID = (int)cmbCategory.SelectedValue;

            _productService.TUpdate(UpdatedProducts);
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
        }
    }
}
