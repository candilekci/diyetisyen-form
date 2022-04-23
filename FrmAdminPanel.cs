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
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        YazilimMimarisiEntities ym = new YazilimMimarisiEntities();
        void Listele()
        {
            dataGridDiyetisyen.DataSource = (from x in ym.Tbl_DIYETISYEN
                                            select new
                                             {
                                                ID = x.DId,
                                                AD = x.DAd,
                                                SOYAD = x.DSoyad,
                                                TC = x.DTC,
                                                SİFRE = x.DSifre
                                             }).ToList();

            dataGridHasta.DataSource = (from x in ym.Tbl_HASTA
                                        join y in ym.Tbl_HASTALIK on x.HHastalik equals y.HastalikId
                                        join a in ym.Tbl_DIYETLER on x.HDiyet equals a.DiyetId
                                        select new
                                        {                                           
                                            AD = x.HAd,
                                            SOYAD = x.HSoyad,
                                            TC = x.HTC,
                                            HASTALIK = y.HastalikAd,
                                            DİYET = a.DiyetAd
                                        }).ToList();

        }
        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridDiyetisyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridDiyetisyen.SelectedCells[0].RowIndex;

            txtID.Text = dataGridDiyetisyen.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridDiyetisyen.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridDiyetisyen.Rows[secilen].Cells[2].Value.ToString();
            txtTC.Text = dataGridDiyetisyen.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = dataGridDiyetisyen.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_DIYETISYEN d = new Tbl_DIYETISYEN();
            d.DAd = txtAd.Text;
            d.DSoyad = txtSoyad.Text;
            d.DTC = txtTC.Text;
            d.DSifre = txtSifre.Text;
            ym.Tbl_DIYETISYEN.Add(d);
            ym.SaveChanges();

            MessageBox.Show("Kayıt Başarılı ... ");

            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var dg = ym.Tbl_DIYETISYEN.Find(x);
            dg.DAd = txtAd.Text;
            dg.DSoyad = txtSoyad.Text;
            dg.DTC = txtTC.Text;
            dg.DSifre = txtSifre.Text;
            ym.SaveChanges();

            MessageBox.Show("Güncelleme Başarılı ...");

            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var dr = ym.Tbl_DIYETISYEN.Find(x);
            ym.Tbl_DIYETISYEN.Remove(dr);
            ym.SaveChanges();

            MessageBox.Show("Güncelleme Başarılı ...");

            Listele();
        }
    }
}
