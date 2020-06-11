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

        //botao para cadastrar novo usuario
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(camposSaoValidos())
            {
                CadastrarUsuario cadastrarUsuario = new CadastrarUsuario(txtEmail.Text, txtUsuario.Text, txtSenha.Text);
                MessageBox.Show(cadastrarUsuario.mensagem);
                this.Close();
            }
        }

        //valida as informaçoes dos campos
        private bool camposSaoValidos()
        {
            bool camposValidos = true;
            string mensagem = "";

            //verifica se email está preenchido e é válido
            if(!(txtEmail.Text.Length > 3 && validacao.emailUsuarioEValido(txtEmail.Text)))
            {
                camposValidos = false;
                mensagem += "\n- O Email digitado é inválido;";
            }

            //verifica se nome do usuário está preenchido e é válido
            if (!(validacao.nomeUsuarioEValido(txtUsuario.Text)))
            {
                camposValidos = false;
                mensagem += "\n- O nome de usuário é inválido. O nome deve possuir de 4 até 12 caracteres e conter apenas letras.";
            }

            //verifica se senha é válida
            if (!(validacao.senhaEValida(txtSenha.Text)))
            {
                camposValidos = false;
                mensagem += "\n- A Senha é inválida. Sua senha deve possuir de 6 até 15 caracteres e conter apenas letras ou números.";
            }

            //verifica se confirmação da senha é válida
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                camposValidos = false;
                mensagem += "\n- As senhas digitadas não correspondem.";
            }

            if(mensagem.Length > 1)
            {
                MessageBox.Show("Um ou mais campos foram preenchidos de maneira incorreta.\n" + mensagem);
            }
            
            return camposValidos;
            
        }
        
    }
}
