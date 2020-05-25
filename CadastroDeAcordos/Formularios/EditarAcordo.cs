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
    public partial class frmEditarAcordo : Form
    {
        public frmEditarAcordo()
        {
            InitializeComponent();
        }

        private void frmEditarAcordo_Load(object sender, EventArgs e)
        {

        }

        public void preencherCampos(string numeroProcessual, string tipoAcordo, string continente, string pais, string instituicao,DateTime dataPublicacao, DateTime dataInicio, DateTime dataFinal, string situacao, string interessado, string email, string telefone, string celular, string descricao, string status)
        {
            txtNumeroProcessual.Text = numeroProcessual;
            cbxTipoDeAcordo.Text = tipoAcordo;
            cbxContinente.Text = continente;
            cbxPais.Text = pais;
            txtNomeInstituicao.Text = instituicao;
            cbxSituacao.Text = situacao;
            txtNomeInteressado.Text = interessado;
            txtEmail.Text = email;
            txtTelefone.Text = telefone;
            txtCelular.Text = celular;
            txtDescricao.Text = descricao;
            txtStatus.Text = status;

            if(situacao == "Concluído")
            {
                dtpDataPublicacao.Checked = true;
                dtpDataPublicacao.Value = dataPublicacao;
                dtpDataInicio.Checked = true;
                dtpDataInicio.Value = dataInicio;
                dtpDataFinal.Checked = true;
                dtpDataFinal.Value = dataFinal;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
