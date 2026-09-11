using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PEMINJAMANALATSEKOLA
{
    class KF
    {
        public static void untukformadit(Form formapa, Panel panelapa)
        {
            panelapa.Controls.Clear();
            formapa.FormBorderStyle = FormBorderStyle.None;
            formapa.Dock = DockStyle.Fill;
            panelapa.Controls.Add(formapa);
            formapa.Show();
        }
    }
}
