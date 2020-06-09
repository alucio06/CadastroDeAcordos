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
using CadastroDeAcordos.Formularios;
using System.Threading;
using ClosedXML.Excel;

namespace CadastroDeAcordos
{
    public partial class frmVisualizarAcordos : Form
    {
        RetornaDados lerDados = new RetornaDados();
        DataTable tabAuxiliar = new DataTable();
        Excluir excluir = new Excluir();

        public frmVisualizarAcordos()
        {
            InitializeComponent();
        }

        //alimenta a tabela com dados do banco
        public void frmVisualizarAcordos_Load(object sender, EventArgs e)
        {
            alimentaComboBox();
            limparFiltros();
            RetornaDados lerDados1 = new RetornaDados();
            dataGriedViewListaAcordos.DataSource = lerDados.MostrarDados();
            tabAuxiliar = lerDados1.MostrarDados();

            atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());
            formataDataGridView();
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
            atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());
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
                    atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());

                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi encontrado nenhum acordo com o número de processo digitado.");
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
                    atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi encontrado nenhum dado com o nome da instituição digitado.");
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
                    atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi encontado nenhum dado com o nome do interessado digitado.");
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
                    atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());
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
                    atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());
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
                    atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());
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
                    atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());
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
            atualizaQuantidadeAcordos(dataGriedViewListaAcordos.Rows.Count.ToString());
        }

        // chama tela para editar acordo passando as informações da linha selecionada
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
                    dataGriedViewListaAcordos.CurrentRow.Cells["Data de Publicação"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Data de Início"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Data Final"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Situação"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Interessado"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Email"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Telefone"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Celular"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Descrição"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Status"].Value.ToString(),
                    dataGriedViewListaAcordos.CurrentRow.Cells["Data Último Status"].Value.ToString()
                    );
                editarAcordo.Show();
            }
        }

        //botão para excluir acordo da tabela
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show($"Você realmente deseja excluir o acordo {dataGriedViewListaAcordos.CurrentRow.Cells["Número Processual"].Value.ToString()}?", "Confirmar Exclusão", MessageBoxButtons.YesNoCancel);

            if (resultado.ToString() == "Yes")
            {
                excluir = new Excluir(dataGriedViewListaAcordos.CurrentRow.Cells["Número Processual"].Value.ToString());
            }
        }

        //formata dataGriedView
        private void formataDataGridView()
        {
            dataGriedViewListaAcordos.RowTemplate.Height = 80;
            dataGriedViewListaAcordos.Columns["Número Processual"].Width = 140;
            dataGriedViewListaAcordos.Columns["Tipo de Acordo"].Width = 100;
            dataGriedViewListaAcordos.Columns["Continente"].Width = 140;
            dataGriedViewListaAcordos.Columns["País"].Width = 100;
            dataGriedViewListaAcordos.Columns["Instituição"].Width = 140;
            dataGriedViewListaAcordos.Columns["Data de Publicação"].Width = 100;
            dataGriedViewListaAcordos.Columns["Data de Início"].Width = 100;
            dataGriedViewListaAcordos.Columns["Data Final"].Width = 100;
            dataGriedViewListaAcordos.Columns["Situação"].Width = 100;
            dataGriedViewListaAcordos.Columns["Interessado"].Width = 100;
            dataGriedViewListaAcordos.Columns["Email"].Width = 140;
            dataGriedViewListaAcordos.Columns["Telefone"].Width = 100;
            dataGriedViewListaAcordos.Columns["Celular"].Width = 100;
            dataGriedViewListaAcordos.Columns["Descrição"].Width = 250;
            dataGriedViewListaAcordos.Columns["Status"].Width = 250;
            dataGriedViewListaAcordos.Columns["Data Último Status"].Width = 100;
            dataGriedViewListaAcordos.Columns["Data de Cadastro"].Width = 100;
        }

        //inicializa as informações dos comboBox (Situação e tipo de acordo) com dados do banco
        private void alimentaComboBox()
        {
            RetornaDados lerDados1 = new RetornaDados();
            RetornaDados lerDados2 = new RetornaDados();

            cbSituacao.DataSource = lerDados1.SituacoesPossiveis("visualizar");
            cbTipoDeAcordo.DataSource = lerDados2.tiposDeAcordo("visualizar");
        }

        // exporta dados para uma planilha excel
        public void ExportarDados()
        {
            try
            {
                string promptValue = InputBox.ShowDialog("Título do relatório:", "Salvando");

                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Planilha 1");

                //título do relatório
                ws.Cell("B2").Value = $"{promptValue}";
                var range = ws.Range("B2:K2");
                range.Merge().Style.Font.SetBold().Font.FontSize = 20;

                //Cabeçalhos do relatório
                ws.Cell("B3").Value = "Número Processual";
                ws.Cell("C3").Value = "Tipo de Acordo";
                ws.Cell("D3").Value = "Continente";
                ws.Cell("E3").Value = "País";
                ws.Cell("F3").Value = "Instituição";
                ws.Cell("G3").Value = "Data de Publicação";
                ws.Cell("H3").Value = "Data de Início";
                ws.Cell("I3").Value = "Data Final";
                ws.Cell("J3").Value = "Situação";
                ws.Cell("K3").Value = "Interessado";
                ws.Cell("L3").Value = "Email";
                ws.Cell("M3").Value = "Telefone";
                ws.Cell("N3").Value = "Celular";
                ws.Cell("O3").Value = "Descrição";
                ws.Cell("P3").Value = "Status";
                ws.Cell("Q3").Value = "Data Último Status";
                ws.Cell("R3").Value = "Data de Cadastro";

                // Corpo do relatório
                var linha = 4;

                for (int i = 1; i < dataGriedViewListaAcordos.Rows.Count; i++)
                {
                    ws.Cell($"B{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[0].Value.ToString();
                    ws.Cell($"C{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[1].Value.ToString();
                    ws.Cell($"D{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[2].Value.ToString();
                    ws.Cell($"E{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[3].Value.ToString();
                    ws.Cell($"F{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[4].Value.ToString();
                    ws.Cell($"G{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[5].Value.ToString();
                    ws.Cell($"H{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[6].Value.ToString();
                    ws.Cell($"I{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[7].Value.ToString();
                    ws.Cell($"J{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[8].Value.ToString();
                    ws.Cell($"K{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[9].Value.ToString();
                    ws.Cell($"L{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[10].Value.ToString();
                    ws.Cell($"M{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[11].Value.ToString();
                    ws.Cell($"N{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[12].Value.ToString();
                    ws.Cell($"O{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[13].Value.ToString();
                    ws.Cell($"P{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[14].Value.ToString();
                    ws.Cell($"Q{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[15].Value.ToString();
                    ws.Cell($"R{linha}").Value = dataGriedViewListaAcordos.Rows[i - 1].Cells[16].Value.ToString();
                    linha++;
                }

                // ajusta a numeração da linha
                linha--;

                // cria uma tabela para ativar os Filtros
                range = ws.Range("B3:R" + linha.ToString());
                range.CreateTable();

                // ajusta o tamanho da coluna de acordo com o seu conteúdo
                ws.Columns("2-18").AdjustToContents();

                // salvar o arquivo em disco
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs($@"{sfd.FileName}");
                    MessageBox.Show("Relatório salvo com sucesso.");
                }
                else
                {
                    MessageBox.Show("Não foi possível salvar o relatório.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível salvar o relatório.");
            }
        }

        private void dataGriedViewListaAcordos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //botao gerar relatorio
        private void btnGerarRelatório_Click(object sender, EventArgs e)
        {
            ExportarDados();
        }

        //atualiza a label com a quantidade de acordos que está visivel na tabela
        private void atualizaQuantidadeAcordos(string quant)
        {
            quant = (int.Parse(quant) - 1).ToString();
            lblQuantidadeAcordos.Text = quant;
        }

    }
}
