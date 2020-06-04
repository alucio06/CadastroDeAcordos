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
using ClosedXML.Excel;

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
            limparFiltros();
            RetornaDados lerDados1 = new RetornaDados();
            RetornaDados lerDados2 = new RetornaDados();
            dataGriedViewAcordosVigentes.DataSource = lerDados1.RetornaAcordosVigentes();
            tabAuxiliar = lerDados2.RetornaAcordosVigentes();
        }

        private void frmAcordosVigentes_Load(object sender, EventArgs e)
        {
            alimentaComboBox();
            limparFiltros();
            
            RetornaDados lerDados1 = new RetornaDados();
            dataGriedViewAcordosVigentes.DataSource = lerDados.RetornaAcordosVigentes();
            tabAuxiliar = lerDados1.RetornaAcordosVigentes();

            formataDataGridView();
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
                    dataGriedViewAcordosVigentes.DataSource = tabAuxiliar;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foram encontrados valores com o filtro desejado");
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
                    dataGriedViewAcordosVigentes.DataSource = tabAuxiliar;
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
                    dataGriedViewAcordosVigentes.DataSource = tabAuxiliar;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foram encontrados valores com o filtro desejado.");
            }
        }

        //limpar filtros
        public void limparFiltros()
        {
            cbTipoDeAcordo.SelectedItem = "Todos";
            cbContinente.SelectedItem = "Todos";
            cbPais.SelectedItem = "Todos";
        }

        public void ExportarDados(DataGridView listaAcordosVigentes)
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
                ws.Cell("J3").Value = "Interessado";
                ws.Cell("K3").Value = "Descrição";

                // Corpo do relatório
                var linha = 4;

                for (int i=1; i < dataGriedViewAcordosVigentes.Rows.Count; i++)
                {
                    ws.Cell($"B{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[0].Value.ToString();
                    ws.Cell($"C{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[1].Value.ToString();
                    ws.Cell($"D{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[2].Value.ToString();
                    ws.Cell($"E{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[3].Value.ToString();
                    ws.Cell($"F{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[4].Value.ToString();
                    ws.Cell($"G{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[5].Value.ToString();
                    ws.Cell($"H{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[6].Value.ToString();
                    ws.Cell($"I{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[7].Value.ToString();
                    ws.Cell($"J{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[8].Value.ToString();
                    ws.Cell($"K{linha}").Value = dataGriedViewAcordosVigentes.Rows[i-1].Cells[9].Value.ToString();
                    linha++;
                }

                // ajusta a numeração da linha
                linha--;

                // cria uma tabela para ativar os Filtros
                range = ws.Range("B3:K" + linha.ToString());
                range.CreateTable();

                // ajusta o tamanho da coluna de acordo com o seu conteúdo
                ws.Columns("2-11").AdjustToContents();

                // salvar o arquivo em disco
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" };

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs($@"{sfd.FileName}");
                    MessageBox.Show("Relatório salvo com sucesso.");
                }
                else
                {
                    MessageBox.Show("Não foi possível salvar o relatório.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar o relatório.");
            }
        }

        //alimenta o combobox tipo de acordos com os tipos de acordos cadastrados no banco
        private void alimentaComboBox()
        {
            RetornaDados lerDados1 = new RetornaDados();
            cbTipoDeAcordo.DataSource = lerDados1.tiposDeAcordo("visualizar");
        }

        //formata o datagridview
        private void formataDataGridView()
        {
            dataGriedViewAcordosVigentes.RowTemplate.Height = 60;
            dataGriedViewAcordosVigentes.Columns["Número Processual"].Width = 140;
            dataGriedViewAcordosVigentes.Columns["Tipo de Acordo"].Width = 100;
            dataGriedViewAcordosVigentes.Columns["Continente"].Width = 140;
            dataGriedViewAcordosVigentes.Columns["País"].Width = 140;
            dataGriedViewAcordosVigentes.Columns["Instituição"].Width = 140;
            dataGriedViewAcordosVigentes.Columns["Data de Publicação"].Width = 100;
            dataGriedViewAcordosVigentes.Columns["Data de Início"].Width = 100;
            dataGriedViewAcordosVigentes.Columns["Data Final"].Width = 100;
            dataGriedViewAcordosVigentes.Columns["Interessado"].Width = 140;
            dataGriedViewAcordosVigentes.Columns["Descrição"].Width = 250;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ExportarDados(dataGriedViewAcordosVigentes);
        }
    }
}
