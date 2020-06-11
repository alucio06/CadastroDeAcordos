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
    public partial class frmCadastroUsuario : Form
    {
        Validacao validacao = new Validacao();

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        //valida o email digitado
        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            validacao.emailEValido(txtEmail);
        }

        //verifica se nome de usuario é válido
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validacao.nomeUsuarioEValido(txtUsuario);
        }

        //verifica se senha é válida
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            Validacao validacao1 = new Validacao();
            validacao1.senhaEValida(txtSenha);
        }

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            Validacao validacao1 = new Validacao();
            validacao1.senhaEValida(txtSenha);
        }



        //botao para cadastrar novo usuario
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
