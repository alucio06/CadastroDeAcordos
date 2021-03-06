﻿namespace CadastroDeAcordos
{
    partial class frmCadastrarAcordo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumeroProcessual = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroProcessual = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbxTipoDeAcordo = new System.Windows.Forms.ComboBox();
            this.lblDataPublicacao = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeInteressado = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxContinente = new System.Windows.Forms.ComboBox();
            this.txtNomeInstituicao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDataPublicacao = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumeroProcessual
            // 
            this.txtNumeroProcessual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroProcessual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroProcessual.Location = new System.Drawing.Point(12, 55);
            this.txtNumeroProcessual.Mask = "00000.000000/0000-0999";
            this.txtNumeroProcessual.Name = "txtNumeroProcessual";
            this.txtNumeroProcessual.PromptChar = ' ';
            this.txtNumeroProcessual.Size = new System.Drawing.Size(163, 20);
            this.txtNumeroProcessual.TabIndex = 32;
            this.txtNumeroProcessual.Tag = "Número Processual*";
            this.txtNumeroProcessual.Text = "23073";
            // 
            // lblNumeroProcessual
            // 
            this.lblNumeroProcessual.AutoSize = true;
            this.lblNumeroProcessual.Location = new System.Drawing.Point(10, 39);
            this.lblNumeroProcessual.Name = "lblNumeroProcessual";
            this.lblNumeroProcessual.Size = new System.Drawing.Size(103, 13);
            this.lblNumeroProcessual.TabIndex = 1;
            this.lblNumeroProcessual.Text = "Numero Processual*";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(201, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Tipo de Acordo*";
            // 
            // cbxTipoDeAcordo
            // 
            this.cbxTipoDeAcordo.BackColor = System.Drawing.SystemColors.Window;
            this.cbxTipoDeAcordo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTipoDeAcordo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDeAcordo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxTipoDeAcordo.FormattingEnabled = true;
            this.cbxTipoDeAcordo.Location = new System.Drawing.Point(204, 54);
            this.cbxTipoDeAcordo.Name = "cbxTipoDeAcordo";
            this.cbxTipoDeAcordo.Size = new System.Drawing.Size(154, 21);
            this.cbxTipoDeAcordo.TabIndex = 20;
            this.cbxTipoDeAcordo.Tag = "Tipo de Acordo*";
            // 
            // lblDataPublicacao
            // 
            this.lblDataPublicacao.AutoSize = true;
            this.lblDataPublicacao.Location = new System.Drawing.Point(184, 79);
            this.lblDataPublicacao.Name = "lblDataPublicacao";
            this.lblDataPublicacao.Size = new System.Drawing.Size(101, 13);
            this.lblDataPublicacao.TabIndex = 30;
            this.lblDataPublicacao.Text = "Data de Publicação";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(291, 78);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(60, 13);
            this.lblDataInicio.TabIndex = 32;
            this.lblDataInicio.Text = "Data Início";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(378, 79);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(55, 13);
            this.lblDataFinal.TabIndex = 33;
            this.lblDataFinal.Text = "Data Final";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Situação*";
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.BackColor = System.Drawing.SystemColors.Window;
            this.cbxSituacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Location = new System.Drawing.Point(12, 94);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(163, 21);
            this.cbxSituacao.TabIndex = 37;
            this.cbxSituacao.Tag = "Situação*";
            this.cbxSituacao.SelectedIndexChanged += new System.EventHandler(this.cbxSituacao_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nome do Interessado*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(263, 270);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(39, 13);
            this.lblTelefone.TabIndex = 26;
            this.lblTelefone.Text = "Celular";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Location = new System.Drawing.Point(12, 286);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 20);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leaved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Telefone";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCelular.Location = new System.Drawing.Point(266, 286);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(184, 20);
            this.txtCelular.TabIndex = 32;
            this.txtCelular.Text = "919";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefone.Location = new System.Drawing.Point(266, 241);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(184, 20);
            this.txtTelefone.TabIndex = 33;
            this.txtTelefone.Text = "91";
            // 
            // txtNomeInteressado
            // 
            this.txtNomeInteressado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeInteressado.Location = new System.Drawing.Point(13, 241);
            this.txtNomeInteressado.Name = "txtNomeInteressado";
            this.txtNomeInteressado.PromptChar = ' ';
            this.txtNomeInteressado.Size = new System.Drawing.Size(246, 20);
            this.txtNomeInteressado.TabIndex = 34;
            this.txtNomeInteressado.Tag = "Nome do Interessado*";
            this.txtNomeInteressado.TextChanged += new System.EventHandler(this.txtNomeInteressado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome da Instituição*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Continente*";
            // 
            // cbxContinente
            // 
            this.cbxContinente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxContinente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContinente.FormattingEnabled = true;
            this.cbxContinente.Items.AddRange(new object[] {
            "África",
            "América Central",
            "América do Norte",
            "América do Sul",
            "Ásia",
            "Europa",
            "Oceania"});
            this.cbxContinente.Location = new System.Drawing.Point(13, 192);
            this.cbxContinente.Name = "cbxContinente";
            this.cbxContinente.Size = new System.Drawing.Size(207, 21);
            this.cbxContinente.TabIndex = 24;
            this.cbxContinente.Tag = "Continente*";
            // 
            // txtNomeInstituicao
            // 
            this.txtNomeInstituicao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeInstituicao.Location = new System.Drawing.Point(13, 144);
            this.txtNomeInstituicao.Name = "txtNomeInstituicao";
            this.txtNomeInstituicao.Size = new System.Drawing.Size(437, 20);
            this.txtNomeInstituicao.TabIndex = 10;
            this.txtNomeInstituicao.Tag = "Nome da Instituição*";
            this.txtNomeInstituicao.TextChanged += new System.EventHandler(this.txtNomeInstituicao_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "País*";
            // 
            // cbxPais
            // 
            this.cbxPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Items.AddRange(new object[] {
            "Afeganistão",
            "África do Sul",
            "Akrotiri",
            "Albânia",
            "Alemanha",
            "Andorra",
            "Angola",
            "Anguila",
            "Antárctida",
            "Antígua e Barbuda",
            "Arábia Saudita",
            "Arctic Ocean",
            "Argélia",
            "Argentina",
            "Arménia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Austrália",
            "Áustria",
            "Azerbaijão",
            "Baamas",
            "Bangladeche",
            "Barbados",
            "Barém",
            "Bélgica",
            "Belize",
            "Benim",
            "Bermudas",
            "Bielorrússia",
            "Birmânia",
            "Bolívia",
            "Bósnia e Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunei",
            "Bulgária",
            "Burquina Faso",
            "Burúndi",
            "Butão",
            "Cabo Verde",
            "Camarões",
            "Camboja",
            "Canadá",
            "Catar",
            "Cazaquistão",
            "Chade",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colômbia",
            "Comores",
            "Congo-Brazzaville",
            "Congo-Kinshasa",
            "Coral Sea Islands",
            "Coreia do Norte",
            "Coreia do Sul",
            "Costa do Marfim",
            "Costa Rica",
            "Croácia",
            "Cuba",
            "Curacao",
            "Dhekelia",
            "Dinamarca",
            "Domínica",
            "Egipto",
            "Emiratos Árabes Unidos",
            "Equador",
            "Eritreia",
            "Eslováquia",
            "Eslovénia",
            "Espanha",
            "Estados Unidos",
            "Estónia",
            "Etiópia",
            "Faroé",
            "Fiji",
            "Filipinas",
            "Finlândia",
            "França",
            "Gabão",
            "Gâmbia",
            "Gana",
            "Gaza Strip",
            "Geórgia",
            "Geórgia do Sul e Sandwich do Sul",
            "Gibraltar",
            "Granada",
            "Grécia",
            "Gronelândia",
            "Guame",
            "Guatemala",
            "Guernsey",
            "Guiana",
            "Guiné",
            "Guiné Equatorial",
            "Guiné-Bissau",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungria",
            "Iémen",
            "Ilha Bouvet",
            "Ilha do Natal",
            "Ilha Norfolk",
            "Ilhas Caimão",
            "Ilhas Cook",
            "Ilhas dos Cocos",
            "Ilhas Falkland",
            "Ilhas Heard e McDonald",
            "Ilhas Marshall",
            "Ilhas Salomão",
            "Ilhas Turcas e Caicos",
            "Ilhas Virgens Americanas",
            "Ilhas Virgens Britânicas",
            "Índia",
            "Indian Ocean",
            "Indonésia",
            "Irão",
            "Iraque",
            "Irlanda",
            "Islândia",
            "Israel",
            "Itália",
            "Jamaica",
            "Jan Mayen",
            "Japão",
            "Jersey",
            "Jibuti",
            "Jordânia",
            "Kosovo",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letónia",
            "Líbano",
            "Libéria",
            "Líbia",
            "Listenstaine",
            "Lituânia",
            "Luxemburgo",
            "Macau",
            "Macedónia",
            "Madagáscar",
            "Malásia",
            "Malávi",
            "Maldivas",
            "Mali",
            "Malta",
            "Man, Isle of",
            "Marianas do Norte",
            "Marrocos",
            "Maurícia",
            "Mauritânia",
            "México",
            "Micronésia",
            "Moçambique",
            "Moldávia",
            "Mónaco",
            "Mongólia",
            "Monserrate",
            "Montenegro",
            "Mundo",
            "Namíbia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicarágua",
            "Níger",
            "Nigéria",
            "Niue",
            "Noruega",
            "Nova Caledónia",
            "Nova Zelândia",
            "Omã",
            "Pacific Ocean",
            "Países Baixos",
            "Palau",
            "Panamá",
            "Papua-Nova Guiné",
            "Paquistão",
            "Paracel Islands",
            "Paraguai",
            "Peru",
            "Pitcairn",
            "Polinésia Francesa",
            "Polónia",
            "Porto Rico",
            "Portugal",
            "Quénia",
            "Quirguizistão",
            "Quiribáti",
            "Reino Unido",
            "República Centro-Africana",
            "República Dominicana",
            "Roménia",
            "Ruanda",
            "Rússia",
            "Salvador",
            "Samoa",
            "Samoa Americana",
            "Santa Helena",
            "Santa Lúcia",
            "São Bartolomeu",
            "São Cristóvão e Neves",
            "São Marinho",
            "São Martinho",
            "São Pedro e Miquelon",
            "São Tomé e Príncipe",
            "São Vicente e Granadinas",
            "Sara Ocidental",
            "Seicheles",
            "Senegal",
            "Serra Leoa",
            "Sérvia",
            "Singapura",
            "Sint Maarten",
            "Síria",
            "Somália",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanca",
            "Suazilândia",
            "Sudão",
            "Sudão do Sul",
            "Suécia",
            "Suíça",
            "Suriname",
            "Svalbard e Jan Mayen",
            "Tailândia",
            "Taiwan",
            "Tajiquistão",
            "Tanzânia",
            "Território Britânico do Oceano Índico",
            "Territórios Austrais Franceses",
            "Timor Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trindade e Tobago",
            "Tunísia",
            "Turquemenistão",
            "Turquia",
            "Tuvalu",
            "Ucrânia",
            "Uganda",
            "União Europeia",
            "Uruguai",
            "Usbequistão",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietname",
            "Wake Island",
            "Wallis e Futuna",
            "West Bank",
            "Zâmbia",
            "Zimbabué"});
            this.cbxPais.Location = new System.Drawing.Point(227, 192);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(223, 21);
            this.cbxPais.TabIndex = 27;
            this.cbxPais.Tag = "País*";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(182, 484);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 35);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "Descrição";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(381, 95);
            this.txtDataFinal.Mask = "00/00/0000";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.PromptChar = ' ';
            this.txtDataFinal.Size = new System.Drawing.Size(67, 20);
            this.txtDataFinal.TabIndex = 40;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(294, 95);
            this.txtDataInicio.Mask = "00/00/0000";
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.PromptChar = ' ';
            this.txtDataInicio.Size = new System.Drawing.Size(64, 20);
            this.txtDataInicio.TabIndex = 39;
            // 
            // txtDataPublicacao
            // 
            this.txtDataPublicacao.Location = new System.Drawing.Point(187, 94);
            this.txtDataPublicacao.Mask = "00/00/0000";
            this.txtDataPublicacao.Name = "txtDataPublicacao";
            this.txtDataPublicacao.PromptChar = ' ';
            this.txtDataPublicacao.Size = new System.Drawing.Size(88, 20);
            this.txtDataPublicacao.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 402);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "Status";
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.Color.DarkRed;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(410, 9);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(40, 37);
            this.iconButton1.TabIndex = 36;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.Location = new System.Drawing.Point(12, 420);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(438, 49);
            this.txtStatus.TabIndex = 36;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Location = new System.Drawing.Point(13, 337);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(437, 62);
            this.txtDescricao.TabIndex = 32;
            // 
            // frmCadastrarAcordo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(473, 540);
            this.Controls.Add(this.txtNomeInteressado);
            this.Controls.Add(this.cbxPais);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbxContinente);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNomeInstituicao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDataPublicacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSituacao);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDataPublicacao);
            this.Controls.Add(this.cbxTipoDeAcordo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNumeroProcessual);
            this.Controls.Add(this.txtNumeroProcessual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarAcordo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Acordo";
            this.Load += new System.EventHandler(this.frmCadastrarAcordo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtNumeroProcessual;
        private System.Windows.Forms.Label lblNumeroProcessual;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbxTipoDeAcordo;
        private System.Windows.Forms.Label lblDataPublicacao;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtNomeInteressado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxContinente;
        private System.Windows.Forms.TextBox txtNomeInstituicao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        private System.Windows.Forms.MaskedTextBox txtDataInicio;
        private System.Windows.Forms.MaskedTextBox txtDataPublicacao;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}