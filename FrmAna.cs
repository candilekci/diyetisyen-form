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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frma = new FrmAdminGiris();
            frma.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmDiyetisyenGiris frmd = new FrmDiyetisyenGiris();
            frmd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmhg = new FrmHastaGiris();
            frmhg.Show();
            this.Hide();

        }
    }
}
