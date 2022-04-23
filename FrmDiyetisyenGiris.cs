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
    public partial class FrmDiyetisyenGiris : Form
    {
        public FrmDiyetisyenGiris()
        {
            InitializeComponent();
        }

        YazilimMimarisiEntities ym = new YazilimMimarisiEntities();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var diyetisyen = from x in ym.Tbl_DIYETISYEN
                             where txtTC.Text == x.DTC && txtSifre.Text == x.DSifre
                             select x;

            if(diyetisyen.Any())
            {
                
                FrmDiyetisyen frmd = new FrmDiyetisyen();
                frmd.TC = txtTC.Text;
                frmd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !", "HATALI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
