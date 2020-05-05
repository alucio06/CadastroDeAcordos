using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAcordos
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnVisualizarAcordos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVisualizarAcordos());
        }

        private void btnCadastrarAcordo_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCadastrarAcordo());
        }

        private void btnAtualizarStatus_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAtualizarStatus());
        }
    }
}
