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
    public partial class frmVisualizarAcordos : Form
    {
  
        public frmVisualizarAcordos()
        {
            InitializeComponent();
        }

        public void frmVisualizarAcordos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDeAcordosDataSet.Acordoss'. Você pode movê-la ou removê-la conforme necessário.
            this.acordossTableAdapter.Fill(this.cadastroDeAcordosDataSet.Acordoss);

        }

        private void dtvListaAcordos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovoAcordo_Click(object sender, EventArgs e)
        {
            new frmCadastrarAcordo().Show();
        }

    }
}
