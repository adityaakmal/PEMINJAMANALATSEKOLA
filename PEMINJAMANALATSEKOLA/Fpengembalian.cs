using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEMINJAMANALATSEKOLA
{
    public partial class Fpengembalian : Form
    {
        public Fpengembalian()
        {
            InitializeComponent();
        }

       
        private void Fpengembalian_Load(object sender, EventArgs e)
        {

        }
        private void bersihkan()
        {
            Txtidpengembalian.Clear();
            txtKodePeminjaman.Clear();
            dtp_tgl_apengembalian.Value = DateTime.Now;
            cmbKondisialat.SelectedIndex = -1;
            cmbPenerima.SelectedIndex = -1;
            txtCatatanPengembalian.Clear();
        }


    }
}
