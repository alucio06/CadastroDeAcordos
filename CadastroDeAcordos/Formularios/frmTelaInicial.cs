using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDeAcordos.Formularios;

namespace CadastroDeAcordos
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial(string nomeUsuario)
        {
            InitializeComponent();
            lblNomeUsuario.Text = nomeUsuario;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
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

        private void btnAtualizarStatus_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAcordosVigentes());
        }

        private void btnListaDeAcordos_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVisualizarAcordos());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAtualizarStatus());
        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void lblNomeUsuario_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
    }
}
