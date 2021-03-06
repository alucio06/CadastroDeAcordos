﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CadastroDeAcordos.Classes;

namespace CadastroDeAcordos
{
    public partial class frmCadastrarAcordo : Form
    {
        List<Control> camposObrigatorios = new List<Control>();
        Validacao isValid = new Validacao();
        bool mouseClicked;
        Point clickedAt;


        public frmCadastrarAcordo()
        {
            InitializeComponent();
        }

        //Cadastrando novo acordo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (isValid.camposObrigatoriosSaoValidos(retornaCamposObrigatorios()) == true)
            {
                Cadastro cad = new Cadastro();
                if (cbxSituacao.Text == "[CONCLUÍDO] ARQUIVADO")
                {
                    cad = new Cadastro(txtNumeroProcessual.Text.Replace(',', '.'), cbxTipoDeAcordo.Text, cbxContinente.Text, cbxPais.Text, txtNomeInstituicao.Text, DateTime.Parse(txtDataPublicacao.Text), DateTime.Parse(txtDataInicio.Text), DateTime.Parse(txtDataFinal.Text), cbxSituacao.Text, txtNomeInteressado.Text, txtEmail.Text, txtTelefone.Text, txtCelular.Text, txtDescricao.Text, txtStatus.Text, DateTime.Now.Date, DateTime.Now);
                }
                else
                {
                    cad = new Cadastro(txtNumeroProcessual.Text.Replace(',', '.'), cbxTipoDeAcordo.Text, cbxContinente.Text, cbxPais.Text, txtNomeInstituicao.Text, cbxSituacao.Text, txtNomeInteressado.Text, txtEmail.Text, txtTelefone.Text, txtCelular.Text, txtDescricao.Text, txtStatus.Text, DateTime.Now.Date, DateTime.Now);
                }

                MessageBox.Show(cad.mensagem);
                this.Close();
            }
            else
            {
                string camposObrigatoriosNaoPreenchidos = isValid.camposObrigatoriosNaoPreenchidos(retornaCamposObrigatorios());
                MessageBox.Show("Para completar o cadastro é necessário preencher todos os campos obrigatórios.\nPreencha corretamente os seguintes campos: " + camposObrigatoriosNaoPreenchidos);
            }
        }

        //Validação de dados
        private void txtNomeInteressado_TextChanged(object sender, EventArgs e)
        {
            isValid.textBoxTemApenasLetras(txtNomeInteressado);
        }

        private void txtNomeInstituicao_TextChanged(object sender, EventArgs e)
        {
            isValid.textBoxTemApenasLetras(txtNomeInstituicao);
        }

        private void txtEmail_Leaved(object sender, EventArgs e)
        {
            isValid.emailEValido(txtEmail);
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

            if (cbxSituacao.Text == "[CONCLUÍDO] ARQUIVADO")
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

        //botao fechar
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarAcordo_Load(object sender, EventArgs e)
        {
            alimentaComboBox();
        }

        private void cbxSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxSituacao.Text == "[CONCLUÍDO] ARQUIVADO")
            {
                lblDataPublicacao.Text = "Data de Publicação*";
                lblDataInicio.Text = "Data de Início*";
                lblDataFinal.Text = "Data Final*";
            }
        }

        //Comandos para permitir que o usuário arraste a tela com o mouse
        private void form_MouseMove(object sender, MouseEventArgs e)
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
