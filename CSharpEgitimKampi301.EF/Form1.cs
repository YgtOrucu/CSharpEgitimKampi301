using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EFTravel eFTravel = new EFTravel();
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = eFTravel.Guide.ToList();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.Name = txtAd.Text;
            guide.Surname = txtSoyad.Text;
            eFTravel.Guide.Add(guide);
            eFTravel.SaveChanges();
            MessageBox.Show("Başarılı bir şekilde eklendi");

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtID.Text);
            var removevalue = eFTravel.Guide.Find(ıd);
            eFTravel.Guide.Remove(removevalue);
            eFTravel.SaveChanges();
            MessageBox.Show("Başarılı bir şekilde silindi");
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtID.Text);
            var updatevalue = eFTravel.Guide.Find(ıd);
            updatevalue.Name = txtAd.Text;
            updatevalue.Surname = txtSoyad.Text;
            eFTravel.SaveChanges();
            MessageBox.Show("Başarılı bir şekilde güncellendi");
        }

        private void btn_IdGetir_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtID.Text);
            var values = eFTravel.Guide.Where(x => x.GuideID == ıd).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
