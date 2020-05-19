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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtvListaAcordos = new System.Windows.Forms.DataGridView();
            this.numeroProcessualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAcordoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instituicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interessadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPublicacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUltStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAcordos = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDeAcordosDataSet = new CadastroDeAcordos.CadastroDeAcordosDataSet3();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovoAcordo = new FontAwesome.Sharp.IconButton();
            this.btnAtualizarLista = new FontAwesome.Sharp.IconButton();
            this.btnTeste = new System.Windows.Forms.Button();
            this.adapterAcordos = new CadastroDeAcordos.CadastroDeAcordosDataSet3TableAdapters.AcordossTableAdapter();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNumeroProcessual = new System.Windows.Forms.RadioButton();
            this.rbInstituicao = new System.Windows.Forms.RadioButton();
            this.rbInteressado = new System.Windows.Forms.RadioButton();
            this.txtCampoDeBusca = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvListaAcordos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcordos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDeAcordosDataSet)).BeginInit();
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
            // dtvListaAcordos
            // 
            this.dtvListaAcordos.AllowUserToOrderColumns = true;
            this.dtvListaAcordos.AutoGenerateColumns = false;
            this.dtvListaAcordos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtvListaAcordos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvListaAcordos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvListaAcordos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtvListaAcordos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvListaAcordos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvListaAcordos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroProcessualDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.tipoAcordoDataGridViewTextBoxColumn,
            this.continenteDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.instituicaoDataGridViewTextBoxColumn,
            this.interessadoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.dataCadastro,
            this.dataPublicacaoDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFinalDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.dataUltStatusDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn});
            this.dtvListaAcordos.DataSource = this.bsAcordos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtvListaAcordos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvListaAcordos.EnableHeadersVisualStyles = false;
            this.dtvListaAcordos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtvListaAcordos.Location = new System.Drawing.Point(0, 0);
            this.dtvListaAcordos.Name = "dtvListaAcordos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtvListaAcordos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = "            - ";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtvListaAcordos.RowTemplate.Height = 28;
            this.dtvListaAcordos.RowTemplate.ReadOnly = true;
            this.dtvListaAcordos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.Size = new System.Drawing.Size(1008, 524);
            this.dtvListaAcordos.TabIndex = 21;
            // 
            // numeroProcessualDataGridViewTextBoxColumn
            // 
            this.numeroProcessualDataGridViewTextBoxColumn.DataPropertyName = "numeroProcessual";
            this.numeroProcessualDataGridViewTextBoxColumn.HeaderText = "Número Processual";
            this.numeroProcessualDataGridViewTextBoxColumn.Name = "numeroProcessualDataGridViewTextBoxColumn";
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            // 
            // tipoAcordoDataGridViewTextBoxColumn
            // 
            this.tipoAcordoDataGridViewTextBoxColumn.DataPropertyName = "tipoAcordo";
            this.tipoAcordoDataGridViewTextBoxColumn.HeaderText = "Tipo de Acordo";
            this.tipoAcordoDataGridViewTextBoxColumn.Name = "tipoAcordoDataGridViewTextBoxColumn";
            // 
            // continenteDataGridViewTextBoxColumn
            // 
            this.continenteDataGridViewTextBoxColumn.DataPropertyName = "continente";
            this.continenteDataGridViewTextBoxColumn.HeaderText = "Continente";
            this.continenteDataGridViewTextBoxColumn.Name = "continenteDataGridViewTextBoxColumn";
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "País";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            // 
            // instituicaoDataGridViewTextBoxColumn
            // 
            this.instituicaoDataGridViewTextBoxColumn.DataPropertyName = "instituicao";
            this.instituicaoDataGridViewTextBoxColumn.HeaderText = "Instituição";
            this.instituicaoDataGridViewTextBoxColumn.Name = "instituicaoDataGridViewTextBoxColumn";
            // 
            // interessadoDataGridViewTextBoxColumn
            // 
            this.interessadoDataGridViewTextBoxColumn.DataPropertyName = "interessado";
            this.interessadoDataGridViewTextBoxColumn.HeaderText = "Interessado";
            this.interessadoDataGridViewTextBoxColumn.Name = "interessadoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastro
            // 
            this.dataCadastro.DataPropertyName = "dataCadastro";
            this.dataCadastro.HeaderText = "Data de Cadastro";
            this.dataCadastro.Name = "dataCadastro";
            // 
            // dataPublicacaoDataGridViewTextBoxColumn
            // 
            this.dataPublicacaoDataGridViewTextBoxColumn.DataPropertyName = "dataPublicacao";
            this.dataPublicacaoDataGridViewTextBoxColumn.HeaderText = "Data de Publicação";
            this.dataPublicacaoDataGridViewTextBoxColumn.Name = "dataPublicacaoDataGridViewTextBoxColumn";
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "dataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "Data de Início";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            // 
            // dataFinalDataGridViewTextBoxColumn
            // 
            this.dataFinalDataGridViewTextBoxColumn.DataPropertyName = "dataFinal";
            this.dataFinalDataGridViewTextBoxColumn.HeaderText = "Data Final";
            this.dataFinalDataGridViewTextBoxColumn.Name = "dataFinalDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn1
            // 
            this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
            this.descricaoDataGridViewTextBoxColumn1.Width = 300;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 300;
            // 
            // dataUltStatusDataGridViewTextBoxColumn
            // 
            this.dataUltStatusDataGridViewTextBoxColumn.DataPropertyName = "dataUltStatus";
            this.dataUltStatusDataGridViewTextBoxColumn.HeaderText = "Última Atualização";
            this.dataUltStatusDataGridViewTextBoxColumn.Name = "dataUltStatusDataGridViewTextBoxColumn";
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "Cadastrado em";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            // 
            // bsAcordos
            // 
            this.bsAcordos.DataMember = "Acordoss";
            this.bsAcordos.DataSource = this.cadastroDeAcordosDataSet;
            // 
            // cadastroDeAcordosDataSet
            // 
            this.cadastroDeAcordosDataSet.DataSetName = "cadastroDeAcordosDataSet";
            this.cadastroDeAcordosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtvListaAcordos);
            this.panel2.Location = new System.Drawing.Point(15, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 524);
            this.panel2.TabIndex = 22;
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
            this.btnNovoAcordo.Location = new System.Drawing.Point(867, 127);
            this.btnNovoAcordo.Name = "btnNovoAcordo";
            this.btnNovoAcordo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnNovoAcordo.Rotation = 0D;
            this.btnNovoAcordo.Size = new System.Drawing.Size(143, 36);
            this.btnNovoAcordo.TabIndex = 23;
            this.btnNovoAcordo.Text = "NOVO ACORDO";
            this.btnNovoAcordo.UseVisualStyleBackColor = false;
            this.btnNovoAcordo.Click += new System.EventHandler(this.btnNovoAcordo_Click);
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
            this.btnAtualizarLista.Location = new System.Drawing.Point(822, 127);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Padding = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.btnAtualizarLista.Rotation = 0D;
            this.btnAtualizarLista.Size = new System.Drawing.Size(39, 36);
            this.btnAtualizarLista.TabIndex = 24;
            this.btnAtualizarLista.UseVisualStyleBackColor = false;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(679, 51);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 25;
            this.btnTeste.Text = "teste";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // adapterAcordos
            // 
            this.adapterAcordos.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(395, 99);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(72, 26);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Buscar por:";
            // 
            // rbNumeroProcessual
            // 
            this.rbNumeroProcessual.AutoSize = true;
            this.rbNumeroProcessual.Location = new System.Drawing.Point(15, 79);
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
            this.rbInstituicao.Location = new System.Drawing.Point(138, 79);
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
            this.rbInteressado.Location = new System.Drawing.Point(217, 79);
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
            this.txtCampoDeBusca.Location = new System.Drawing.Point(15, 99);
            this.txtCampoDeBusca.Name = "txtCampoDeBusca";
            this.txtCampoDeBusca.Size = new System.Drawing.Size(374, 26);
            this.txtCampoDeBusca.TabIndex = 32;
            // 
            // frmVisualizarAcordos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 749);
            this.Controls.Add(this.txtCampoDeBusca);
            this.Controls.Add(this.rbInteressado);
            this.Controls.Add(this.rbInstituicao);
            this.Controls.Add(this.rbNumeroProcessual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnTeste);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtvListaAcordos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcordos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDeAcordosDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtvListaAcordos;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnNovoAcordo;
        private FontAwesome.Sharp.IconButton btnAtualizarLista;
        private CadastroDeAcordosDataSet3 cadastroDeAcordosDataSet;
        private System.Windows.Forms.BindingSource bsAcordos;
        private CadastroDeAcordosDataSet3TableAdapters.AcordossTableAdapter adapterAcordos;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroProcessualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAcordoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn continenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instituicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interessadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPublicacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUltStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNumeroProcessual;
        private System.Windows.Forms.RadioButton rbInstituicao;
        private System.Windows.Forms.RadioButton rbInteressado;
        private System.Windows.Forms.MaskedTextBox txtCampoDeBusca;
    }
}