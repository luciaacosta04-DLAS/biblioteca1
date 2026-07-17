using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace avance_1_sistema_de_biblioteca
{
    public partial class frmDashboard : Form


    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            FrmLibro frm = new FrmLibro();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(frm);

            frm.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            FrmPrestamos frm = new FrmPrestamos();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(frm);

            frm.Show();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            FrmCliente frm = new FrmCliente();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(frm);

            frm.Show();
        }
    }
}
