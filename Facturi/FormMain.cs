using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adaugarePartenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addParteneriForm newAddParteneriForm = new addParteneriForm();
            newAddParteneriForm.MdiParent = this;
            newAddParteneriForm.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFacturaNoua frm = new FormFacturaNoua();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormRegistru frm = new FormRegistru();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRapoarte frm = new FormRapoarte();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
