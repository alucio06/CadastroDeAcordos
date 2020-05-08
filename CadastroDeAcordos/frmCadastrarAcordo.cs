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

                comando.Parameters.AddWithValue("@NUMEROPROCESSUAL", txtNumeroProcessual.Text);
                comando.Parameters.AddWithValue("@NOME", txtNomeInstituicao.Text);
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
                conexao = null;
                comando = null;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Data Source=DESKTOP-KVLIDHN;Initial Catalog=CadastroDeAcordos;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

                strSQL = "SELECT * FROM CAD_ACORDO";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Data Source=DESKTOP-KVLIDHN;Initial Catalog=CadastroDeAcordos;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

                strSQL = "SELECT * FROM CAD_ACORDO WHERE numeroProcessual = @NUMEROPROCESSUAL";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NUMEROPROCESSUAL", txtNumeroProcessual.Text);
               
                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNomeInstituicao.Text = (string)dr["nome"];
                    txtTelefone.Text = (string)(dr["numero"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Data Source=DESKTOP-KVLIDHN;Initial Catalog=CadastroDeAcordos;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

                strSQL = "UPDATE CAD_ACORDO SET nome = @NOME, numeroTelefone = @NUMEROTELEFONE WHERE numeroProcessual = @NUMEROPROCESSUAL)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NUMEROPROCESSUAL", txtNumeroProcessual.Text);
                comando.Parameters.AddWithValue("@NOME", txtNomeInstituicao.Text);
                comando.Parameters.AddWithValue("@NUMEROTELEFONE", txtTelefone.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Data Source=DESKTOP-KVLIDHN;Initial Catalog=CadastroDeAcordos;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");

                strSQL = "DELETE CAD_ACORDO WHERE numeroProcessual = @NUMEROPROCESSUAL";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NUMEROPROCESSUAL", txtNumeroProcessual.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
