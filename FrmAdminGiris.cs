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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        YazilimMimarisiEntities ym = new YazilimMimarisiEntities();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var admin = from x in ym.Tbl_Admin
                        where txtKulaniciAd.Text == x.AdminAd && txtSifre.Text == x.AdminSifre
                        select x;

            if(admin.Any())
            {
                FrmAdminPanel frma = new FrmAdminPanel();
                frma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !","HATALI GİRİŞ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
