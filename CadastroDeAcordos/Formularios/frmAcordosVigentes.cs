using CadastroDeAcordos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAcordos.Formularios
{
    public partial class frmAcordosVigentes : Form
    {
        RetornaDados lerDados = new RetornaDados();
        DataTable tabAuxiliar = new DataTable();

        public frmAcordosVigentes()
        {
            InitializeComponent();
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {

        }

        private void frmAcordosVigentes_Load(object sender, EventArgs e)
        {
            RetornaDados lerDados1 = new RetornaDados();
            dataGriedViewAcordosVigentes.DataSource = lerDados.RetornaAcordosVigentes();
            tabAuxiliar = lerDados1.RetornaAcordosVigentes();
        }

    }
}
