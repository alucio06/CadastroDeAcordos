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
        List<Control> camposObrigatorios = new List<Control>();
        Validacao isValid = new Validacao();

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
                if (cbxSituacao.Text == "Concluído")
                {
                    dtpDataPublicacao.Checked = true;
                    dtpDataInicio.Checked = true;
                    dtpDataFinal.Checked = true;
                    cad = new Cadastro(txtNumeroProcessual.Text.Replace(',', '.'), cbxTipoDeAcordo.Text, cbxContinente.Text, cbxPais.Text, txtNomeInstituicao.Text, dtpDataPublicacao.Value, dtpDataInicio.Value, dtpDataFinal.Value, cbxSituacao.Text, txtNomeInteressado.Text, txtEmail.Text, txtTelefone.Text, txtCelular.Text, txtDescricao.Text, txtStatus.Text, DateTime.Now.Date, DateTime.Now);
                }
                else
                {
                    dtpDataPublicacao.Checked = false;
                    dtpDataInicio.Checked = false;
                    dtpDataFinal.Checked = false;
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

        //Marca as datas como obrigatórias caso a situacao do acordo seja "Concluído"
        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSituacao.Text == "Concluído")
            {
                dtpDataPublicacao.Checked = true;
                dtpDataInicio.Checked = true;
                dtpDataFinal.Checked = true;
            } else
            {
                dtpDataPublicacao.Checked = false;
                dtpDataInicio.Checked = false;
                dtpDataFinal.Checked = false;
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
            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control panel in control.Controls)
                    {
                        if(panel is Panel)
                        {
                            foreach (Control campo in panel.Controls)
                            {
                                if ((string)campo.Tag == "campoObrigatorio")
                                {
                                    camposObrigatorios.Add(campo);
                                }
                            }
                        }
                    }
                }
            }
            if (cbxSituacao.Text == "Concluído")
            {
                camposObrigatorios.Add(dtpDataFinal);
                camposObrigatorios.Add(dtpDataInicio);
                camposObrigatorios.Add(dtpDataPublicacao);
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

        }



        /*SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;*/

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

    }
}
