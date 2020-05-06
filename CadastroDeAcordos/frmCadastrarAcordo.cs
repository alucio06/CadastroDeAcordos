using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroDeAcordos
{
    public partial class frmCadastrarAcordo : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        public frmCadastrarAcordo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Data Source=DESKTOP-KVLIDHN;Initial Catalog=CadastroDeAcordos;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

                strSQL = "INSERT INTO CAD_ACORDO (numeroProcessual, nome, numeroTelefone) VALUES (@NUMEROPROCESSUAL, @NOME, @NUMEROTELEFONE)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NUMEROPROCESSUAL", txtNome.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@NUMEROTELEFONE", txtTelefone.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }
    }
}
