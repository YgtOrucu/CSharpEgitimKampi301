using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concreate;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EFCategoryDal());
            InitializeComponent();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            var categoryList = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryList;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtAd.Text;
            if (radioButton1.Checked)
            {
                category.CategoryStatus = true;
            }
            else
            {
                category.CategoryStatus = false;
            }
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme Başarılı");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme Başarılı");
        }

        private void btn_IdGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var getValues = _categoryService.TGetById(id);
            dataGridView1.DataSource = new List<Category> { getValues };
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            int updatedıd = int.Parse(txtID.Text);
            var getUpdateCategory = _categoryService.TGetById(updatedıd);

            getUpdateCategory.CategoryName = txtAd.Text;
            if (radioButton1.Checked)
            {
                getUpdateCategory.CategoryStatus = true;
            }
            else
            {
                getUpdateCategory.CategoryStatus = false;
            }
            _categoryService.TUpdate(getUpdateCategory);
            MessageBox.Show("Güncelleme Başarılı");
        }
    }
}
