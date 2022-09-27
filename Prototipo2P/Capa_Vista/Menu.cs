using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos b = new productos();
            b.MdiParent = this;
            b.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras b = new Compras();
            b.MdiParent = this;
            b.Show();
        }

        private void lotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lote b = new Lote();
            b.MdiParent = this;
            b.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventarios b = new Inventarios();
            b.MdiParent = this;
            b.Show();
        }
    }
}
