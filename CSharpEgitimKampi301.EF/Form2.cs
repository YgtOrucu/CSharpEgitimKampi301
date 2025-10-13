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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        EFTravel EF = new EFTravel();
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            var values = EF.Location.Select(x => new
            {
                City = x.City,
                Country = x.Country,
                Capacity = x.Capacity,
                Price = x.Price,
                DayNight = x.DayNight,
                Guide = x.Guide.Name + " " + x.Guide.Surname,
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var values = EF.Guide.Select(X => new
            {
                FullName = X.Name + " " + X.Surname,
                X.GuideID
            }).ToList();


            cbRehber.DisplayMember = "FullName";
            cbRehber.ValueMember = "GuideID";
            cbRehber.DataSource = values;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Location location = new Location()
            {
                City = txtSehir.Text,
                Country = txtÜlke.Text,
                Capacity = Convert.ToByte(numKapasite.Value),
                Price = decimal.Parse(txtFiyat.Text),
                DayNight = txtGeceGündüz.Text,
                GuideID = Convert.ToInt32(cbRehber.SelectedValue),
            };
            EF.Location.Add(location);
            EF.SaveChanges();
            MessageBox.Show("Lokasyon Eklendi");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deletedvalue = EF.Location.Find(id);
            EF.Location.Remove(deletedvalue);
            EF.SaveChanges();
            MessageBox.Show("Lokasyon Silindi");
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var updatevalue = EF.Location.Find(id);
            updatevalue.Price = decimal.Parse(txtFiyat.Text);
            updatevalue.Capacity = Convert.ToByte(numKapasite.Value);
            updatevalue.DayNight = txtGeceGündüz.Text;
            updatevalue.GuideID = Convert.ToInt32(cbRehber.SelectedValue);
            EF.SaveChanges();
            MessageBox.Show("Lokasyon Güncellendi");
        }

        private void btn_IdGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var values = EF.Location.Where(x => x.LocationID == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
