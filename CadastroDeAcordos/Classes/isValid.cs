using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAcordos.Classes
{
    //Classe para validar informações repassadas nos formulários
    public class isValid
    {
        //verifica se textBox contém apenas letras 
        public Control textBoxTemApenasLetras(Control TextBox)
        { 
            foreach (char letra in TextBox.Text)
            {
                if (!char.IsLetter(letra)) //se caractere não é letra
                {
                    MessageBox.Show("A caixa de texto aceita apenas letras");
                    TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
                    TextBox.Select();
                }
            }
            return TextBox;
        }

        //verifica se email é válido
        public Control emailEValido(Control textBox)
        {
            bool validacao = textBox.Text.Contains("@") && (textBox.Text.Contains(".com") || textBox.Text.Contains(".COM"));
            if (textBox.Text != "" && validacao == false)
            {
                MessageBox.Show("Email Inválido ! Por favor, digite um email válido.");
                textBox.Select();
            }
            return textBox;
        }

        //verifica se o campo está vazio
        public bool campoEstaPreenchido(Control textBox)
        {
            bool validacao = true;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                validacao = false;
            }
            return validacao;
        }

        //verifica se numeroProcessual é válido
        public bool numProcessualEValido(Control textBox)
        {
            bool validacao = true;

            foreach (char num in textBox.Text) {
                if (textBox.Text.IndexOf(num) < 19 && num != ',' && num != '/' && num != '-')
                {
                    if (!char.IsNumber(num))
                    {
                        validacao = false;
                        break;
                    }
                }
            }
            return validacao;
        }

        //verifica se todos os campos obrigatórios estão preenchidos
        public bool camposObrigatoriosSaoValidos(List<Control> camposObrigatorios)
        {
            bool validacao = true;

            foreach(Control campo in camposObrigatorios)
            {
                if (campo.Name != "txtNumeroProcessual" && !campoEstaPreenchido(campo))
                    validacao = false;
                else if (campo.Name == "txtNumeroProcessual" && !numProcessualEValido(campo))
                    validacao = false;
            }
            return validacao;
        }

        //retorna campos obrigatórios não preenchidos
        public string camposObrigatoriosNaoPreenchidos(List<Control> camposObrigatorios)
        {
            string camposNaoPreenchidos = "";

            foreach (Control campo in camposObrigatorios)
            {
                if(campo.Name != "txtNumeroProcessual" && !campoEstaPreenchido(campo))
                    camposNaoPreenchidos += $"\n- {(string)campo.Name.Substring(3)}";
                else if (campo.Name == "txtNumeroProcessual" && !numProcessualEValido(campo))
                    camposNaoPreenchidos += $"\n- {(string)campo.Name.Substring(3)}";
            }
            return camposNaoPreenchidos;
        }
    }
}
