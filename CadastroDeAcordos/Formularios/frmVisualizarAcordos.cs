﻿using System;
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
using CadastroDeAcordos.Formularios;

namespace CadastroDeAcordos
{
    public partial class frmVisualizarAcordos : Form
    {
        RetornaDados lerDados = new RetornaDados();
        DataTable tabAuxiliar = new DataTable();

        public frmVisualizarAcordos()
        {
            InitializeComponent();
        }

        //alimenta a tabela com dados do banco
        public void frmVisualizarAcordos_Load(object sender, EventArgs e)
        {
            RetornaDados lerDados1 = new RetornaDados();
            dataGriedViewListaAcordos.DataSource = lerDados.MostrarDados();
            tabAuxiliar = lerDados1.MostrarDados();
        }

        //botao cadastrar acordo abre a tela de cadastro
        private void btnNovoAcordo_Click(object sender, EventArgs e)
        {
            new frmCadastrarAcordo().Show();
        }

        //botao para atualizar a lista da tabela
        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            RetornaDados lerDados1 = new RetornaDados();
            RetornaDados lerDados2 = new RetornaDados();
            dataGriedViewListaAcordos.DataSource = lerDados1.MostrarDados();
            tabAuxiliar = lerDados2.MostrarDados();
            limparFiltros();
        }

        //formata o campo de busca para a máscara de número de processo quando botao do numeroProcessual é criado
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

        //botao buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //se busca for feita pelo número processual
            if (rbNumeroProcessual.Checked == true)
            {
                try
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    tabAuxiliar = lerDados1.BuscarPorNumeroProcessual(txtCampoDeBusca.Text, tabAuxiliar);
                    dataGriedViewListaAcordos.DataSource = tabAuxiliar;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //se busca for feita pela instituição
            if (rbInstituicao.Checked == true)
            {
                try
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    tabAuxiliar = lerDados1.BuscarPorInstituicao(txtCampoDeBusca.Text, tabAuxiliar);
                    dataGriedViewListaAcordos.DataSource = tabAuxiliar;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //se busca for feita pelo nome do interessado
            if (rbInteressado.Checked == true)
            {
                try
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    tabAuxiliar = lerDados1.BuscarPorInteressado(txtCampoDeBusca.Text, tabAuxiliar);
                    dataGriedViewListaAcordos.DataSource = tabAuxiliar;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //limpar todos os filtros
        private void limparFiltros()
        {
            rbNumeroProcessual.Checked = false;
            rbInstituicao.Checked = false;
            rbInteressado.Checked = false;
            txtCampoDeBusca.Mask = null;
            txtCampoDeBusca.Text = "";
            cbTipoDeAcordo.SelectedItem = "Todos";
            cbSituacao.SelectedItem = "Todos";
            cbContinente.SelectedItem = "Todos";
            cbPais.SelectedItem = "Todos";
        }

        //executa o filtro por tipo de acordo
        private void cbTipoDeAcordo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTipoDeAcordo.Text != "Todos")
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    tabAuxiliar = lerDados1.FiltrarPorTipoDeAcordo(cbTipoDeAcordo.Text, tabAuxiliar);
                    dataGriedViewListaAcordos.DataSource = tabAuxiliar;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foram encontrados valores com o filtro desejado.");
            }
        }

        //executa o filtro por situação
        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSituacao.Text != "Todos")
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    tabAuxiliar = lerDados1.FiltrarPorSituacao(cbSituacao.Text, tabAuxiliar);
                    dataGriedViewListaAcordos.DataSource = tabAuxiliar;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foram encontrados valores com o filtro desejado.");
            }
        }

        //executa o filtro por continente
        private void cbContinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbContinente.Text != "Todos")
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    tabAuxiliar = lerDados1.FiltrarPorContinente(cbContinente.Text, tabAuxiliar);
                    dataGriedViewListaAcordos.DataSource = tabAuxiliar;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foram encontrados valores com o filtro desejado.");
            }
        }

        //executa o filtro por país
        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPais.Text != "Todos")
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    tabAuxiliar = lerDados1.FiltrarPorPais(cbPais.Text, tabAuxiliar);
                    dataGriedViewListaAcordos.DataSource = tabAuxiliar;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foram encontrados valores com o filtro desejado.");
            }
        }

        //botao limpar filtro
        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            limparFiltros();
            RetornaDados lerDados1 = new RetornaDados();
            RetornaDados lerDados2 = new RetornaDados();
            dataGriedViewListaAcordos.DataSource = lerDados1.MostrarDados();
            tabAuxiliar = lerDados2.MostrarDados();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dataGriedViewListaAcordos.RowCount > 0)
            {
                frmEditarAcordo editarAcordo = new frmEditarAcordo();
                editarAcordo.preencherCampos(
                    dataGriedViewListaAcordos.CurrentRow.Cells["Número Processual"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Tipo de Acordo"].Value.ToString(), 
                    dataGriedViewListaAcordos.CurrentRow.Cells["Continente"].Value.ToString(), 
                    dataGriedViewListaAcordos.CurrentRow.Cells["País"].Value.ToString(), 
                    dataGriedViewListaAcordos.CurrentRow.Cells["Instituição"].Value.ToString(),
                    Convert.ToDateTime(dataGriedViewListaAcordos.CurrentRow.Cells["Data de Publicação"].Value),
                    Convert.ToDateTime(dataGriedViewListaAcordos.CurrentRow.Cells["Data de Início"].Value),
                    Convert.ToDateTime(dataGriedViewListaAcordos.CurrentRow.Cells["Data Final"].Value), 
                    dataGriedViewListaAcordos.CurrentRow.Cells["Situação"].Value.ToString(), 
                    dataGriedViewListaAcordos.CurrentRow.Cells["Interessado"].Value.ToString(), 
                    dataGriedViewListaAcordos.CurrentRow.Cells["Email"].Value.ToString(), 
                    dataGriedViewListaAcordos.CurrentRow.Cells["Telefone"].Value.ToString(), 
                    dataGriedViewListaAcordos.CurrentRow.Cells["Celular"].Value.ToString(), 
                    dataGriedViewListaAcordos.CurrentRow.Cells["Descrição"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Status"].Value.ToString()
                    );
                editarAcordo.Show();
            }
        }
    }
}
