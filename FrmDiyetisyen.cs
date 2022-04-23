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
    public partial class FrmDiyetisyen : Form
    {
        public FrmDiyetisyen()
        {
            InitializeComponent();
        }

        YazilimMimarisiEntities ym = new YazilimMimarisiEntities();
        public string TC;
       
        void cmbListele()
        {
            var Hkategori = (from x in ym.Tbl_HASTALIK
                             select new
                             {
                                 x.HastalikId,
                                 x.HastalikAd
                             }).ToList();

            cmbHastalik.ValueMember = "HastalikId";
            cmbHastalik.DisplayMember = "HastalikAd";
            cmbHastalik.DataSource = Hkategori;

            var Dkategori = (from x in ym.Tbl_DIYETLER
                             select new
                             {
                                 x.DiyetId,
                                 x.DiyetAd
                             }).ToList();
            cmbDiyet.ValueMember = "DiyetId";
            cmbDiyet.DisplayMember = "DiyetAd";
            cmbDiyet.DataSource = Dkategori;
        }
        void datagridlistele()
        {
            dataGridHasta.DataSource = (from x in ym.Tbl_HASTA
                                        join y in ym.Tbl_HASTALIK on x.HHastalik equals y.HastalikId
                                        join a in ym.Tbl_DIYETLER on x.HDiyet equals a.DiyetId
                                        select new
                                       {
                                          ID = x.HId,
                                          AD = x.HAd,
                                          SOYAD =  x.HSoyad,
                                          TC = x.HTC,
                                          HASTALIK =  y.HastalikAd,  
                                          DİYET = a.DiyetAd
                                       }).ToList();

            
        }

        private void FrmDiyetisyen_Load(object sender, EventArgs e)
        {
            cmbListele();
            datagridlistele();

            lblTC.Text = TC;
            lblAdSoyad.Text = (from x in ym.Tbl_DIYETISYEN
                              where TC == x.DTC
                              select (x.DAd + " " + x.DSoyad)).FirstOrDefault();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_HASTA h = new Tbl_HASTA();
            h.HAd = txtAd.Text;
            h.HSoyad = txtSoyad.Text;
            h.HTC = txtTC.Text;
            h.HHastalik = Convert.ToInt32(cmbHastalik.SelectedValue);
            h.HDiyet = Convert.ToInt32(cmbDiyet.SelectedValue);
            ym.Tbl_HASTA.Add(h);
            ym.SaveChanges();

            MessageBox.Show("Başarılı...");
            datagridlistele();
        }

        private void dataGridHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridHasta.SelectedCells[0].RowIndex;

            txtID.Text = dataGridHasta.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridHasta.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridHasta.Rows[secilen].Cells[2].Value.ToString();
            txtTC.Text = dataGridHasta.Rows[secilen].Cells[3].Value.ToString();
            txtHasta.Text = dataGridHasta.Rows[secilen].Cells[1].Value.ToString();

            int ID = Convert.ToInt32(txtID.Text);

            dataGridDiyet.DataSource = (from x in ym.Tbl_PROGRAM
                                        where ID == x.PHasta
                                        join y in ym.Tbl_HASTA on x.PHasta equals y.HId
                                        select new
                                        {
                                            HASTA = y.HAd,
                                            GUNLER = x.Günler,
                                            KAHVALTI = x.Sabah,
                                            OGLE = x.Ogle,
                                            AKSAM = x.Aksam
                                        }).ToList();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var hg = ym.Tbl_HASTA.Find(x);
            hg.HAd = txtAd.Text;
            hg.HSoyad = txtSoyad.Text;
            hg.HTC = txtTC.Text;
            hg.HHastalik = Convert.ToInt32(cmbHastalik.SelectedValue);
            hg.HDiyet = Convert.ToInt32(cmbDiyet.SelectedValue);
            ym.SaveChanges();

            MessageBox.Show("Başarılı...");
            datagridlistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var hr = ym.Tbl_HASTA.Find(x);
            ym.Tbl_HASTA.Remove(hr);
            ym.SaveChanges();

            MessageBox.Show("Başarılı...");
            datagridlistele();
        }

        private void btnEkleHastalik_Click(object sender, EventArgs e)
        {
            Tbl_HASTALIK ha = new Tbl_HASTALIK();
            ha.HastalikAd = txtYeniHastalik.Text;
            ym.Tbl_HASTALIK.Add(ha);
            ym.SaveChanges();

            MessageBox.Show("Başarılı...");
            cmbListele();
        }

        private void btnEkleDiyet_Click(object sender, EventArgs e)
        {
            Tbl_DIYETLER d = new Tbl_DIYETLER();
            d.DiyetAd = txtYeniDiyet.Text;
            ym.Tbl_DIYETLER.Add(d);
            ym.SaveChanges();

            MessageBox.Show("Başarılı...");
            cmbListele();
        }

        private void btnOgunKaydet_Click(object sender, EventArgs e)
        {
            Tbl_PROGRAM p = new Tbl_PROGRAM();
            p.PHasta = Convert.ToInt32 (txtID.Text);
            p.Günler = cmbGUN.Text;
            p.Sabah = rtxtKahvalti.Text;
            p.Ogle = rtxtOgle.Text;
            p.Aksam = rtxtAksam.Text;
            ym.Tbl_PROGRAM.Add(p);
            ym.SaveChanges();

            MessageBox.Show(cmbGUN.Text + " Günü Başarıyla Kayedildi...");
            datagridlistele();
        }
    }
}
