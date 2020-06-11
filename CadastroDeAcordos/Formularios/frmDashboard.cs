using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDeAcordos.Classes;

namespace CadastroDeAcordos
{
    public partial class frmAtualizarStatus : Form
    {
        RetornaDados retornaDados = new RetornaDados();

        public frmAtualizarStatus()
        {
            InitializeComponent();
            GraficoAcordosPorPais();
            GraficoAcordosPorTipo();
            GraficoAcordosPorAno();
            PreencheDadosDashboard();
        }

        private void frmAtualizarStatus_Load(object sender, EventArgs e)
        {
        }

        // preenche informacoes do gráfico de acordos por país
        private void GraficoAcordosPorPais()
        {
            chartAcordosPorPais.DataSource = retornaDados.QuantAcordosPorPais();
            chartAcordosPorPais.Series["Series1"].XValueMember = "País";
            chartAcordosPorPais.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartAcordosPorPais.Series["Series1"].YValueMembers = "Quantidade de acordos";
            chartAcordosPorPais.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        // preenche informações do gráfico de acordos por tipo
        private void GraficoAcordosPorTipo()
        {
            chartAcordosPorTipo.DataSource = retornaDados.QuantAcordosPorTipo();
            chartAcordosPorTipo.Series["Series1"].XValueMember = "Tipo de acordo";
            chartAcordosPorTipo.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartAcordosPorTipo.Series["Series1"].YValueMembers = "Quantidade de acordos";
            chartAcordosPorTipo.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        // preenche informações do gráfico de acordos por ano
        private void GraficoAcordosPorAno()
        {
            chartAcordosPorAno.DataSource = retornaDados.QuantAcordosPorAno();
            chartAcordosPorAno.Series["Series1"].XValueMember = "Data publicação";
            chartAcordosPorAno.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartAcordosPorAno.Series["Series1"].YValueMembers = "Quantidade de acordos";
            chartAcordosPorAno.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        // preenche a quantidade dos valores do dashboard
        private void PreencheDadosDashboard()
        {
            List<string> listaDados = new List<string>();
            RetornaDados retornaDados2 = new RetornaDados();
            DataTable table = retornaDados2.DadosDashboard();

            //preenche lista com os valores da tabela
            foreach (DataRow linha in table.Rows)
            {
                foreach (DataColumn coluna in table.Columns)
                {
                    listaDados.Add(linha[coluna].ToString());
                }
            }

            //armazena cada valor da lista em sua respectiva label
            lblTotalDeAcordos.Text = listaDados[0];
            lblTotalDeAcordosFirmados.Text = listaDados[1];
            lblAcordosVigentes.Text = listaDados[2];
            lblAcordosVigentesUlt3Meses.Text = listaDados[3];
            lblAcordosEmTramitacao.Text = listaDados[4];
            lblAcordosCadastradosUlt3meses.Text = listaDados[5];
            lblAcordosEmExpiracao.Text = listaDados[6];
            lblAcordosExpirados.Text = listaDados[7];
            lblAcordosExpiradosUlt3Meses.Text = listaDados[8];
            lblAcordosComAttRecente.Text = listaDados[9];
            lblAcordosSemAttRecentes.Text = listaDados[10];
        }

        
    }

}
