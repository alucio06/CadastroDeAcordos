using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDeAcordos.Classes;

namespace CadastroDeAcordos.Formularios
{
    public partial class frmEditarAcordo : Form
    {
        List<Control> camposObrigatorios = new List<Control>();
        bool mouseClicked;
        Point clickedAt;
        string numeroProcessualAtual;
        string statusAtual;
        string DataUltimoStatus;
        Editar editarAcordo = new Editar();
        Validacao validacao = new Validacao();
        Excluir excluir = new Excluir();

        public frmEditarAcordo()
        {
            InitializeComponent();
        }

        private void frmEditarAcordo_Load(object sender, EventArgs e)
        {
        }

        //preenche os campos com as informações da linha selecionada na tabela
        public void preencherCampos(string numeroProcessual, string tipoAcordo, string continente, string pais, string instituicao, string dataPublicacao, string dataInicio, string dataFinal, string situacao, string interessado, string email, string telefone, string celular, string descricao, string status, string dataUltimoStatus)
        {
            //pega a data do ultimo status para verificar se irá haver alteração no status e consequentemente, alteração na data;
            DataUltimoStatus = dataUltimoStatus;
            statusAtual = status;
            numeroProcessualAtual = numeroProcessual;

            //alimenta combo box situacao e tipo de acordo
            alimentaComboBox();

            //alimentando os txtBox do form
            txtNumeroProcessual.Text = numeroProcessual;
            cbxTipoDeAcordo.Text = tipoAcordo;
            cbxContinente.Text = continente;
            cbxPais.Text = pais;
            txtNomeInstituicao.Text = instituicao;
            txtDataPublicacao.Text = dataPublicacao;
            txtDataInicio.Text = dataInicio;
            txtDataFinal.Text = dataFinal;
            cbxSituacao.Text = situacao;
            txtNomeInteressado.Text = interessado;
            txtEmail.Text = email;
            txtTelefone.Text = telefone;
            txtCelular.Text = celular;
            txtDescricao.Text = descricao;
            txtStatus.Text = status;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //botão editar acordo
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //se o status foi alterado, é alterado a data do último status
            if (txtStatus.Text != statusAtual)
            {
                DataUltimoStatus = DateTime.Today.ToString(); ;
            }

            //se campos forem validos, instancia classe editar com os parâmetros
            if (validacao.camposObrigatoriosSaoValidos(retornaCamposObrigatorios()))
            {
                if (cbxSituacao.Text == "Concluído")
                {
                    editarAcordo = new Editar(numeroProcessualAtual, txtNumeroProcessual.Text.Replace(',', '.'), cbxTipoDeAcordo.Text, cbxContinente.Text, cbxPais.Text, txtNomeInstituicao.Text, DateTime.Parse(txtDataPublicacao.Text), DateTime.Parse(txtDataInicio.Text), DateTime.Parse(txtDataFinal.Text), cbxSituacao.Text, txtNomeInteressado.Text, txtEmail.Text, txtTelefone.Text, txtCelular.Text, txtDescricao.Text, txtStatus.Text, DateTime.Parse(DataUltimoStatus));
                }
                else
                {
                    editarAcordo = new Editar(numeroProcessualAtual, txtNumeroProcessual.Text.Replace(',', '.'), cbxTipoDeAcordo.Text, cbxContinente.Text, cbxPais.Text, txtNomeInstituicao.Text, cbxSituacao.Text, txtNomeInteressado.Text, txtEmail.Text, txtTelefone.Text, txtCelular.Text, txtDescricao.Text, txtStatus.Text, DateTime.Parse(DataUltimoStatus));
                }
                MessageBox.Show(editarAcordo.mensagem);
                this.Close();
            }

            else
            {
                string camposObrigatoriosNaoPreenchidos = validacao.camposObrigatoriosNaoPreenchidos(retornaCamposObrigatorios());
                MessageBox.Show("Para editar o acordo é necessário preencher todos os campos obrigatórios.\nPreencha corretamente os seguintes campos: " + camposObrigatoriosNaoPreenchidos);
            }
        }

        //botão fechar form
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //código para permitir que o usuário arraste o formulário
        private void frmEditarAcordo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        //retorna lista com os campos obrigatórios do formulário de cadastro
        public List<Control> retornaCamposObrigatorios()
        {
            camposObrigatorios.Clear();
            txtDataPublicacao.Tag = "";
            txtDataInicio.Tag = "";
            txtDataFinal.Tag = "";

            foreach (Control control in this.Controls)
            {
                if (control.Tag != null)
                {
                    if (control.Tag.ToString().Contains("*"))
                    {
                        camposObrigatorios.Add(control);
                    }
                }
            }

            if (cbxSituacao.Text == "Concluído")
            {
                camposObrigatorios.Add(txtDataPublicacao);
                camposObrigatorios.Add(txtDataInicio);
                camposObrigatorios.Add(txtDataFinal);
                txtDataPublicacao.Tag = "Data de Publicação*";
                txtDataInicio.Tag = "Data de Início*";
                txtDataFinal.Tag = "Data Final*";
            }

            return camposObrigatorios;
        }

        //botão para excluir acordo da tabela
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show($"Você realmente deseja excluir o acordo {numeroProcessualAtual}?", "Confirmar Exclusão", MessageBoxButtons.YesNoCancel);

            if (resultado.ToString() == "Yes")
            {
                excluir = new Excluir(numeroProcessualAtual);
                this.Close();
            }
        }

        //inicializa as informações dos comboBox (Situação e tipo de acordo) com dados do banco
        private void alimentaComboBox()
        {
            RetornaDados lerDados1 = new RetornaDados();
            RetornaDados lerDados2 = new RetornaDados();

            cbxSituacao.DataSource = lerDados1.SituacoesPossiveis("cadastrar");
            cbxTipoDeAcordo.DataSource = lerDados2.tiposDeAcordo("cadastrar");
        }

    }
}
