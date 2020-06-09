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
        }

        private void frmAtualizarStatus_Load(object sender, EventArgs e)
        {
        }

        private void GraficoAcordosPorPais()
        {
            chartAcordosPorPais.DataSource = retornaDados.QuantAcordosPorPais();
            chartAcordosPorPais.Series["Series1"].XValueMember = "País";
            chartAcordosPorPais.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartAcordosPorPais.Series["Series1"].YValueMembers = "Quantidade de acordos";
            chartAcordosPorPais.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void GraficoAcordosPorTipo()
        {
            chartAcordosPorTipo.DataSource = retornaDados.QuantAcordosPorTipo();
            chartAcordosPorTipo.Series["Series1"].XValueMember = "Tipo de acordo";
            chartAcordosPorTipo.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartAcordosPorTipo.Series["Series1"].YValueMembers = "Quantidade de acordos";
            chartAcordosPorTipo.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void GraficoAcordosPorAno()
        {
            chartAcordosPorAno.DataSource = retornaDados.QuantAcordosPorAno();
            chartAcordosPorAno.Series["Series1"].XValueMember = "Data publicação";
            chartAcordosPorAno.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartAcordosPorAno.Series["Series1"].YValueMembers = "Quantidade de acordos";
            chartAcordosPorAno.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

    }

}
