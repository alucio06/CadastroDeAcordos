using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CadastroDeAcordos.Classes;
using System.Data.SqlClient;

namespace CadastroDeAcordos
{
    public partial class frmVisualizarAcordos : Form
    {
        Validacao validacao = new Validacao();

        public frmVisualizarAcordos()
        {
            InitializeComponent();
        }

        //alimenta a tabela com dados do banco
        public void frmVisualizarAcordos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDeAcordosDataSet3.Acordoss'. Você pode movê-la ou removê-la conforme necessário.
            this.adapterAcordos.Fill(this.cadastroDeAcordosDataSet.Acordoss);
        }

        //botao cadastrar acordo abre a tela de cadastro
        private void btnNovoAcordo_Click(object sender, EventArgs e)
        {
            new frmCadastrarAcordo().Show();
        }

        //atualiza a lista da tabela
        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            this.adapterAcordos.Fill(this.cadastroDeAcordosDataSet.Acordoss);
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            try
            {
                this.adapterAcordos.returnConcluidos(this.cadastroDeAcordosDataSet.Acordoss);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void returnConcluidosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.adapterAcordos.returnConcluidos(this.cadastroDeAcordosDataSet.Acordoss);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //formata o campo de busca para a máscara de número de processo
        private void rbNumeroProcessual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumeroProcessual.Checked == true)
            {
                txtCampoDeBusca.Culture = CultureInfo.InvariantCulture;
                txtCampoDeBusca.Mask = "00000.000000/0000-0999";
            }
        }

        //limpa o campo e a máscara quando selecionar para buscar por instituição
        private void rbInstituicao_CheckedChanged(object sender, EventArgs e)
        {
            txtCampoDeBusca.Mask = null;
            txtCampoDeBusca.Text = "";
        }

        //limpa o campo e a máscara quando selecionar para buscar por interessado
        private void rbInteressado_CheckedChanged(object sender, EventArgs e)
        {
            txtCampoDeBusca.Mask = null;
            txtCampoDeBusca.Text = "";
        }

        private DataSet buscarPorNumeroProcessual(DataSet dataSet)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("Select * from Acordoss where situacao = 'Concluído'", new Conexao().conectar());
            adapter.Fill(dataSet);
            return dataSet;
        }  

        //botao buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //se busca for feita pelo número processual
            if (rbNumeroProcessual.Checked == true)
            {
                try
                {
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
