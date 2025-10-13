using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EF
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EFTravel EF = new EFTravel();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lbl_LocationCount.Text = EF.Location.Count().ToString();
            lbl_CapacityCount.Text = EF.Location.Sum(x => x.Capacity).ToString();
            lbl_GuideCount.Text = EF.Guide.Count().ToString();
            lbl_AvgCapacity.Text = EF.Location.Average(x => (double)x.Capacity).ToString("0.00");
            Lbl_AvgPrice.Text = EF.Location.Average(x => (double)x.Price).ToString("N2") + " TL";
            lbl_LastCountry.Text = EF.Location.OrderByDescending(x => x.LocationID).Select(m => m.Country).FirstOrDefault();
            lbl_KapadokyaTurCapacity.Text = EF.Location.Where(x => x.City == "Kapadokya Turu").Sum(M => M.Capacity).ToString();
            lbl_TürkiyeOrtKapasite.Text = EF.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            int guideID = Convert.ToInt32(EF.Location.Where(x => x.City == "Roma Turu").Select(y => y.GuideID).FirstOrDefault());
            lbl_RomaTurGuide.Text = EF.Guide.Where(x => x.GuideID == guideID).Select(y => y.Name + " " + y.Surname).FirstOrDefault().ToString();
            lbl_MaxcapacityOfTour.Text = EF.Location.Where(x => x.Capacity == EF.Location.Max(y => y.Capacity)).Select(m => m.City + " - " + m.Capacity + " Kişi").FirstOrDefault().ToString();

            var mostExpensive = EF.Location
                .Where(x => x.Price == EF.Location.Max(y => y.Price))
                .Select(m => new { m.City, m.Price })
                .FirstOrDefault();

            if (mostExpensive != null)
                lbl_TheMostExpenciveOfTour.Text = mostExpensive.City + "\n" + ((double)mostExpensive.Price).ToString("N2") + " TL";

            lbl_AysegulTotalTourCount.Text =
                EF.Location.Where(x => x.GuideID == EF.Guide.Where(y => y.Name == "Ayşegül" && y.Surname == "Çınar").Select(m => m.GuideID).FirstOrDefault()).Count().ToString();
        }
    }
}
