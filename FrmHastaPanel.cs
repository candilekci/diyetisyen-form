using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazilim_Mimarisi_Project
{
    public partial class FrmHastaPanel : Form
    {
        public FrmHastaPanel()
        {
            InitializeComponent();
        }
        YazilimMimarisiEntities ym = new YazilimMimarisiEntities();
        public string TCH;
        private void FrmHastaPanel_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = (from x in ym.Tbl_HASTA
                               where TCH == x.HTC
                               select x.HAd + " " + x.HSoyad).FirstOrDefault();

            lblTC.Text = TCH;

            lblHastalik.Text = (from x in ym.Tbl_HASTA
                                where TCH == x.HTC
                                join y in ym.Tbl_HASTALIK on x.HHastalik equals y.HastalikId
                                select y.HastalikAd).FirstOrDefault();

            lblDiyet.Text = (from x in ym.Tbl_HASTA
                             where TCH == x.HTC
                             join y in ym.Tbl_DIYETLER on x.HDiyet equals y.DiyetId
                             select y.DiyetAd).FirstOrDefault();

            dataGridDiyet.DataSource = (from x in ym.Tbl_PROGRAM
                                        join y in ym.Tbl_HASTA on x.PHasta equals y.HId
                                        where TCH == y.HTC
                                        select new
                                        {
                                            x.Günler,
                                            x.Sabah,
                                            x.Ogle,
                                            x.Aksam

                                        }).ToList();

        }
    }
}
