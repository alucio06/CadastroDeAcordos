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
using CadastroDeAcordos.Classes;

namespace CadastroDeAcordos
{
    public partial class frmCadastrarAcordo : Form
    {
        /*SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;*/

        public frmCadastrarAcordo()
        {
            InitializeComponent();
        }

        //Cadastrando novo acordo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (camposObrigatoriosPreenchidos() == true)
            {
                Cadastro cad = new Cadastro();
                if (cbSituacao.Text == "Concluído")
                {
                    dtpDataPublicacao.Checked = true;
                    dtpDataInicio.Checked = true;
                    dtpDataFinal.Checked = true;
                    cad = new Cadastro(txtNumeroProcessual.Text, cbTipoDeAcordo.Text, cbContinente.Text, cbPais.Text, txtNomeInstituicao.Text, dtpDataPublicacao.Value, dtpDataInicio.Value, dtpDataFinal.Value, cbSituacao.Text, txtNomeInteressado.Text, txtEmail.Text, txtTelefone.Text, txtDescricao.Text, DateTime.Now.Date);
                }
                else
                {
                    dtpDataPublicacao.Checked = false;
                    dtpDataInicio.Checked = false;
                    dtpDataFinal.Checked = false;
                    cad = new Cadastro(txtNumeroProcessual.Text, cbTipoDeAcordo.Text, cbContinente.Text, cbPais.Text, txtNomeInstituicao.Text, cbSituacao.Text, txtNomeInteressado.Text, txtEmail.Text, txtTelefone.Text, txtDescricao.Text, DateTime.Now.Date);
                }

                MessageBox.Show(cad.mensagem);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios");
            }


            /*try
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
            }*/


        }

        /*
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
                    lblTelefone.Text = (string)(dr["numero"]);
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
                comando.Parameters.AddWithValue("@NUMEROTELEFONE", lblTelefone.Text);

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
        */

        //Marca as datas como obrigatórias caso a situacao do acordo seja "Concluído"
        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSituacao.Text == "Concluído")
            {
                dtpDataPublicacao.Checked = true;
                dtpDataInicio.Checked = true;
                dtpDataFinal.Checked = true;
            }
        }

        //Validação de dados
        private void txtNomeInteressado_TextChanged(object sender, EventArgs e)
        {
            isValid isValid = new isValid();
            isValid.textBoxTemApenasLetras(txtNomeInteressado);
        }

        private void txtNomeInstituicao_TextChanged(object sender, EventArgs e)
        {
            isValid isValid = new isValid();
            isValid.textBoxTemApenasLetras(txtNomeInstituicao);
        }

        private void txtEmail_Leaved(object sender, EventArgs e)
        {
            isValid isValid = new isValid();
            isValid.emailEValido(txtEmail);
        }

        private bool camposObrigatoriosPreenchidos()
        {
            List<Control> camposObrigatorios = new List<Control>();
            isValid isValid = new isValid();
            bool validacao = true;

            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control campo in control.Controls)
                    {
                        if ((string)campo.Tag == "campoObrigatorio")
                        {
                            if (campo.Name != "txtNumeroProcessual" && !isValid.campoEstaPreenchido(campo))
                            {
                                camposObrigatorios.Add(campo);
                                validacao = false;
                            }
                            else if (campo.Name == "txtNumeroProcessual" && !isValid.numProcessualEValido(campo))
                            {
                                camposObrigatorios.Add(campo);
                                validacao = false;
                            }
                        }
                    }
                }
            }
            return validacao;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            camposObrigatoriosPreenchidos();
        }
    }
}
