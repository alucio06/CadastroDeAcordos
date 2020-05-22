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
            dataGriedViewListaAcordos.DataSource = lerDados.MostrarDados();
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
            dataGriedViewListaAcordos.DataSource = lerDados1.MostrarDados();
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
                    dataGriedViewListaAcordos.DataSource = lerDados1.BuscarPorNumeroProcessual(txtCampoDeBusca.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (rbInstituicao.Checked == true)
            {
                try
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    dataGriedViewListaAcordos.DataSource = lerDados1.BuscarPorInstituicao(txtCampoDeBusca.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (rbInteressado.Checked == true)
            {
                try
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    dataGriedViewListaAcordos.DataSource = lerDados1.BuscarPorInteressado(txtCampoDeBusca.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //quando é aplicado filtro por tipo de acordo
        private void cbTipoDeAcordo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipoDeAcordo.Text != "Todos")
            {
                try
                {
                    RetornaDados lerDados1 = new RetornaDados();
                    dataGriedViewListaAcordos.DataSource = lerDados1.FiltrarPorTipoDeAcordo(cbTipoDeAcordo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                RetornaDados lerDados1 = new RetornaDados();
                dataGriedViewListaAcordos.DataSource = lerDados1.MostrarDados();
            }
        }

        //limpar todos os filtros
        private void limparFiltros()
        {
            rbNumeroProcessual.Checked = false;
            rbInstituicao.Checked = false;
            rbInteressado.Checked = false;
            txtCampoDeBusca.Text = "";

        }
    }
}
