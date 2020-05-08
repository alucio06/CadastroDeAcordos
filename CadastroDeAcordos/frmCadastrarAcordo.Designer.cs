namespace CadastroDeAcordos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroProcessual = new System.Windows.Forms.Label();
            this.txtNumeroProcessual = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeInstituicao = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTipoDeAcordo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataPublicacao = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbContinente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeInteressado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Acordo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumeroProcessual
            // 
            this.lblNumeroProcessual.AutoSize = true;
            this.lblNumeroProcessual.Location = new System.Drawing.Point(26, 78);
            this.lblNumeroProcessual.Name = "lblNumeroProcessual";
            this.lblNumeroProcessual.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroProcessual.TabIndex = 1;
            this.lblNumeroProcessual.Text = "Numero Processual";
            // 
            // txtNumeroProcessual
            // 
            this.txtNumeroProcessual.Location = new System.Drawing.Point(29, 94);
            this.txtNumeroProcessual.Name = "txtNumeroProcessual";
            this.txtNumeroProcessual.Size = new System.Drawing.Size(190, 20);
            this.txtNumeroProcessual.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(214, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Tipo de Acordo";
            // 
            // txtNomeInstituicao
            // 
            this.txtNomeInstituicao.Location = new System.Drawing.Point(11, 34);
            this.txtNomeInstituicao.Name = "txtNomeInstituicao";
            this.txtNomeInstituicao.Size = new System.Drawing.Size(408, 20);
            this.txtNomeInstituicao.TabIndex = 10;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(487, 77);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(239, 141);
            this.dgvDados.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(17, 477);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(438, 30);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(487, 325);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(487, 389);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(487, 354);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 17;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(487, 291);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 46);
            this.panel1.TabIndex = 19;
            // 
            // cbTipoDeAcordo
            // 
            this.cbTipoDeAcordo.FormattingEnabled = true;
            this.cbTipoDeAcordo.Items.AddRange(new object[] {
            "Acordo Geral",
            "Cotutela",
            "Consórcio",
            "Mobilidade",
            "Memorando de Entendimento",
            "Outros"});
            this.cbTipoDeAcordo.Location = new System.Drawing.Point(217, 25);
            this.cbTipoDeAcordo.Name = "cbTipoDeAcordo";
            this.cbTipoDeAcordo.Size = new System.Drawing.Size(203, 21);
            this.cbTipoDeAcordo.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpDataInicio);
            this.panel2.Controls.Add(this.dtpDataFinal);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dtpDataPublicacao);
            this.panel2.Controls.Add(this.cbTipoDeAcordo);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Cursor = System.Windows.Forms.Cursors.No;
            this.panel2.Location = new System.Drawing.Point(17, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 112);
            this.panel2.TabIndex = 21;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(152, 80);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(126, 20);
            this.dtpDataInicio.TabIndex = 35;
            this.dtpDataInicio.Value = new System.DateTime(2020, 5, 7, 19, 25, 50, 0);
            this.dtpDataInicio.Visible = false;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Location = new System.Drawing.Point(294, 80);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(126, 20);
            this.dtpDataFinal.TabIndex = 34;
            this.dtpDataFinal.Value = new System.DateTime(2020, 5, 7, 19, 25, 50, 0);
            this.dtpDataFinal.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Data Final";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Data Início";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Data de Publicação";
            // 
            // dtpDataPublicacao
            // 
            this.dtpDataPublicacao.Location = new System.Drawing.Point(11, 80);
            this.dtpDataPublicacao.Name = "dtpDataPublicacao";
            this.dtpDataPublicacao.Size = new System.Drawing.Size(126, 20);
            this.dtpDataPublicacao.TabIndex = 31;
            this.dtpDataPublicacao.Value = new System.DateTime(2020, 5, 7, 19, 25, 50, 0);
            this.dtpDataPublicacao.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbPais);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cbContinente);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNomeInstituicao);
            this.panel3.Cursor = System.Windows.Forms.Cursors.No;
            this.panel3.Location = new System.Drawing.Point(17, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 113);
            this.panel3.TabIndex = 22;
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
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
            this.cbPais.Location = new System.Drawing.Point(204, 82);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(215, 21);
            this.cbPais.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "País";
            // 
            // cbContinente
            // 
            this.cbContinente.FormattingEnabled = true;
            this.cbContinente.Items.AddRange(new object[] {
            "África",
            "América Central",
            "América do Norte",
            "América do Sul",
            "Ásia",
            "Europa",
            "Oceania"});
            this.cbContinente.Location = new System.Drawing.Point(11, 82);
            this.cbContinente.Name = "cbContinente";
            this.cbContinente.Size = new System.Drawing.Size(175, 21);
            this.cbContinente.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Continente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Instituição";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.txtTelefone);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtNomeInteressado);
            this.panel4.Cursor = System.Windows.Forms.Cursors.No;
            this.panel4.Location = new System.Drawing.Point(17, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 113);
            this.panel4.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtTelefone
            // 
            this.txtTelefone.AutoSize = true;
            this.txtTelefone.Location = new System.Drawing.Point(260, 66);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(49, 13);
            this.txtTelefone.TabIndex = 26;
            this.txtTelefone.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nome";
            // 
            // txtNomeInteressado
            // 
            this.txtNomeInteressado.Location = new System.Drawing.Point(11, 34);
            this.txtNomeInteressado.Name = "txtNomeInteressado";
            this.txtNomeInteressado.Size = new System.Drawing.Size(409, 20);
            this.txtNomeInteressado.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Interessado";
            // 
            // frmCadastrarAcordo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(766, 539);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtNumeroProcessual);
            this.Controls.Add(this.lblNumeroProcessual);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarAcordo";
            this.Text = "frmCadastrarAcordo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroProcessual;
        private System.Windows.Forms.TextBox txtNumeroProcessual;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeInstituicao;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTipoDeAcordo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbContinente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataPublicacao;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeInteressado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }
}