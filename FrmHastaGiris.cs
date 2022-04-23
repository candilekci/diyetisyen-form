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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        YazilimMimarisiEntities ym = new YazilimMimarisiEntities();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var hasta = from x in ym.Tbl_HASTA
                        where txtTC.Text == x.HTC
                        select x;

            if(hasta.Any())
            {
                FrmHastaPanel frmh = new FrmHastaPanel();
                frmh.TCH = txtTC.Text;
                frmh.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !", "HATALI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
