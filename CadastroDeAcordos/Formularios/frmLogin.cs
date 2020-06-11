using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDeAcordos.Classes;

namespace CadastroDeAcordos.Formularios
{
    public partial class frmLogin : Form
    {
        public bool loginValidado = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        //botão para cadastrar usuario
        private void label3_Click(object sender, EventArgs e)
        {
            new frmCadastroUsuario().Show();
        }

        //botão para fazer login
        private void button1_Click(object sender, EventArgs e)
        {
            VerificarLogin verificarLogin = new VerificarLogin();
            if(verificarLogin.usuarioEsenhaEstaoCorretos(txtUsuario.Text, txtSenha.Text) == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente.");
            }
        }

        

    }
}
