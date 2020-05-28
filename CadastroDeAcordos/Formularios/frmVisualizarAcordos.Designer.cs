namespace CadastroDeAcordos
{
    partial class frmVisualizarAcordos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGriedViewListaAcordos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNumeroProcessual = new System.Windows.Forms.RadioButton();
            this.rbInstituicao = new System.Windows.Forms.RadioButton();
            this.rbInteressado = new System.Windows.Forms.RadioButton();
            this.txtCampoDeBusca = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoDeAcordo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbContinente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnLimparFiltros = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnAtualizarLista = new FontAwesome.Sharp.IconButton();
            this.btnNovoAcordo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedViewListaAcordos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizar Acordos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 45);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(476, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visualizar Acordos";
            // 
            // dataGriedViewListaAcordos
            // 
            this.dataGriedViewListaAcordos.AllowUserToOrderColumns = true;
            this.dataGriedViewListaAcordos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGriedViewListaAcordos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGriedViewListaAcordos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGriedViewListaAcordos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGriedViewListaAcordos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGriedViewListaAcordos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGriedViewListaAcordos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGriedViewListaAcordos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGriedViewListaAcordos.EnableHeadersVisualStyles = false;
            this.dataGriedViewListaAcordos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGriedViewListaAcordos.Location = new System.Drawing.Point(0, 0);
            this.dataGriedViewListaAcordos.Name = "dataGriedViewListaAcordos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGriedViewListaAcordos.RowHeadersWidth = 25;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = "            - ";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGriedViewListaAcordos.RowTemplate.Height = 28;
            this.dataGriedViewListaAcordos.RowTemplate.ReadOnly = true;
            this.dataGriedViewListaAcordos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.Size = new System.Drawing.Size(900, 487);
            this.dataGriedViewListaAcordos.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGriedViewListaAcordos);
            this.panel2.Location = new System.Drawing.Point(153, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 487);
            this.panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Buscar por:";
            // 
            // rbNumeroProcessual
            // 
            this.rbNumeroProcessual.AutoSize = true;
            this.rbNumeroProcessual.Location = new System.Drawing.Point(152, 87);
            this.rbNumeroProcessual.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.rbNumeroProcessual.Name = "rbNumeroProcessual";
            this.rbNumeroProcessual.Size = new System.Drawing.Size(117, 17);
            this.rbNumeroProcessual.TabIndex = 29;
            this.rbNumeroProcessual.Text = "Número Processual";
            this.rbNumeroProcessual.UseVisualStyleBackColor = true;
            this.rbNumeroProcessual.CheckedChanged += new System.EventHandler(this.rbNumeroProcessual_CheckedChanged);
            // 
            // rbInstituicao
            // 
            this.rbInstituicao.AutoSize = true;
            this.rbInstituicao.Location = new System.Drawing.Point(275, 87);
            this.rbInstituicao.Name = "rbInstituicao";
            this.rbInstituicao.Size = new System.Drawing.Size(73, 17);
            this.rbInstituicao.TabIndex = 30;
            this.rbInstituicao.Text = "Instituição";
            this.rbInstituicao.UseVisualStyleBackColor = true;
            this.rbInstituicao.CheckedChanged += new System.EventHandler(this.rbInstituicao_CheckedChanged);
            // 
            // rbInteressado
            // 
            this.rbInteressado.AutoSize = true;
            this.rbInteressado.Location = new System.Drawing.Point(354, 87);
            this.rbInteressado.Name = "rbInteressado";
            this.rbInteressado.Size = new System.Drawing.Size(80, 17);
            this.rbInteressado.TabIndex = 31;
            this.rbInteressado.Text = "Interessado";
            this.rbInteressado.UseVisualStyleBackColor = true;
            this.rbInteressado.CheckedChanged += new System.EventHandler(this.rbInteressado_CheckedChanged);
            // 
            // txtCampoDeBusca
            // 
            this.txtCampoDeBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampoDeBusca.Location = new System.Drawing.Point(153, 110);
            this.txtCampoDeBusca.Name = "txtCampoDeBusca";
            this.txtCampoDeBusca.Size = new System.Drawing.Size(401, 26);
            this.txtCampoDeBusca.TabIndex = 32;
            // 
            // cbTipoDeAcordo
            // 
            this.cbTipoDeAcordo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoDeAcordo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDeAcordo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDeAcordo.ForeColor = System.Drawing.Color.Gray;
            this.cbTipoDeAcordo.FormattingEnabled = true;
            this.cbTipoDeAcordo.Items.AddRange(new object[] {
            "Todos",
            "Acordo Geral",
            "Cotutela",
            "Consórcio",
            "Mobilidade",
            "Memorando de Entendimento",
            "Outros"});
            this.cbTipoDeAcordo.Location = new System.Drawing.Point(15, 172);
            this.cbTipoDeAcordo.Name = "cbTipoDeAcordo";
            this.cbTipoDeAcordo.Size = new System.Drawing.Size(132, 21);
            this.cbTipoDeAcordo.TabIndex = 34;
            this.cbTipoDeAcordo.SelectedIndexChanged += new System.EventHandler(this.cbTipoDeAcordo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tipo de Acordo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Situação";
            // 
            // cbSituacao
            // 
            this.cbSituacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacao.ForeColor = System.Drawing.Color.Gray;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Todos",
            "Aguardando",
            "Em análise",
            "Concluído"});
            this.cbSituacao.Location = new System.Drawing.Point(15, 259);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(132, 21);
            this.cbSituacao.TabIndex = 36;
            this.cbSituacao.SelectedIndexChanged += new System.EventHandler(this.cbSituacao_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Continente";
            // 
            // cbContinente
            // 
            this.cbContinente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbContinente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContinente.ForeColor = System.Drawing.Color.Gray;
            this.cbContinente.FormattingEnabled = true;
            this.cbContinente.Items.AddRange(new object[] {
            "Todos",
            "África",
            "América Central",
            "América do Norte",
            "América do Sul",
            "Ásia",
            "Europa",
            "Oceania"});
            this.cbContinente.Location = new System.Drawing.Point(15, 216);
            this.cbContinente.Name = "cbContinente";
            this.cbContinente.Size = new System.Drawing.Size(132, 21);
            this.cbContinente.TabIndex = 38;
            this.cbContinente.SelectedIndexChanged += new System.EventHandler(this.cbContinente_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "País";
            // 
            // cbPais
            // 
            this.cbPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPais.ForeColor = System.Drawing.Color.Gray;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "Todos",
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
            this.cbPais.Location = new System.Drawing.Point(15, 300);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(132, 21);
            this.cbPais.TabIndex = 40;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExcluir.IconColor = System.Drawing.Color.Black;
            this.btnExcluir.IconSize = 16;
            this.btnExcluir.Location = new System.Drawing.Point(967, 633);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Rotation = 0D;
            this.btnExcluir.Size = new System.Drawing.Size(69, 36);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconSize = 16;
            this.btnEditar.Location = new System.Drawing.Point(847, 633);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Rotation = 0D;
            this.btnEditar.Size = new System.Drawing.Size(114, 36);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "EDITAR ACORDO";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparFiltros.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLimparFiltros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimparFiltros.IconColor = System.Drawing.Color.Black;
            this.btnLimparFiltros.IconSize = 1;
            this.btnLimparFiltros.Location = new System.Drawing.Point(33, 336);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Rotation = 0D;
            this.btnLimparFiltros.Size = new System.Drawing.Size(96, 29);
            this.btnLimparFiltros.TabIndex = 42;
            this.btnLimparFiltros.Text = "Limpar Filtros";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(560, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(72, 26);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizarLista.AutoSize = true;
            this.btnAtualizarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            this.btnAtualizarLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarLista.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAtualizarLista.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarLista.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarLista.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnAtualizarLista.IconColor = System.Drawing.Color.White;
            this.btnAtualizarLista.IconSize = 22;
            this.btnAtualizarLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarLista.Location = new System.Drawing.Point(848, 98);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Padding = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.btnAtualizarLista.Rotation = 0D;
            this.btnAtualizarLista.Size = new System.Drawing.Size(39, 36);
            this.btnAtualizarLista.TabIndex = 24;
            this.btnAtualizarLista.UseVisualStyleBackColor = false;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // btnNovoAcordo
            // 
            this.btnNovoAcordo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoAcordo.AutoSize = true;
            this.btnNovoAcordo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            this.btnNovoAcordo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovoAcordo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoAcordo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoAcordo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNovoAcordo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAcordo.ForeColor = System.Drawing.Color.White;
            this.btnNovoAcordo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNovoAcordo.IconColor = System.Drawing.Color.White;
            this.btnNovoAcordo.IconSize = 16;
            this.btnNovoAcordo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoAcordo.Location = new System.Drawing.Point(893, 98);
            this.btnNovoAcordo.Name = "btnNovoAcordo";
            this.btnNovoAcordo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNovoAcordo.Rotation = 0D;
            this.btnNovoAcordo.Size = new System.Drawing.Size(143, 36);
            this.btnNovoAcordo.TabIndex = 23;
            this.btnNovoAcordo.Text = "NOVO ACORDO";
            this.btnNovoAcordo.UseVisualStyleBackColor = false;
            this.btnNovoAcordo.Click += new System.EventHandler(this.btnNovoAcordo_Click);
            // 
            // frmVisualizarAcordos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 749);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimparFiltros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbContinente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipoDeAcordo);
            this.Controls.Add(this.txtCampoDeBusca);
            this.Controls.Add(this.rbInteressado);
            this.Controls.Add(this.rbInstituicao);
            this.Controls.Add(this.rbNumeroProcessual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.btnNovoAcordo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVisualizarAcordos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmVisualizarAcordos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedViewListaAcordos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGriedViewListaAcordos;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnNovoAcordo;
        private FontAwesome.Sharp.IconButton btnAtualizarLista;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNumeroProcessual;
        private System.Windows.Forms.RadioButton rbInstituicao;
        private System.Windows.Forms.RadioButton rbInteressado;
        private System.Windows.Forms.MaskedTextBox txtCampoDeBusca;
        private System.Windows.Forms.ComboBox cbTipoDeAcordo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbContinente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPais;
        private FontAwesome.Sharp.IconButton btnLimparFiltros;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnExcluir;
    }
}