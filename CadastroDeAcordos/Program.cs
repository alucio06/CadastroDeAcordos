using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDeAcordos.Formularios;

namespace CadastroDeAcordos
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin telaLogin = new frmLogin();
            if (telaLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmTelaInicial(telaLogin.txtUsuario.Text));
            }
            
        }
    }
}
