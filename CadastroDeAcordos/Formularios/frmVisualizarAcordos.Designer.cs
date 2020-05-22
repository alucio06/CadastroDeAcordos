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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGriedViewListaAcordos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovoAcordo = new FontAwesome.Sharp.IconButton();
            this.btnAtualizarLista = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNumeroProcessual = new System.Windows.Forms.RadioButton();
            this.rbInstituicao = new System.Windows.Forms.RadioButton();
            this.rbInteressado = new System.Windows.Forms.RadioButton();
            this.txtCampoDeBusca = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoDeAcordo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbContinente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
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
            this.dataGriedViewListaAcordos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGriedViewListaAcordos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGriedViewListaAcordos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGriedViewListaAcordos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGriedViewListaAcordos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGriedViewListaAcordos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGriedViewListaAcordos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGriedViewListaAcordos.EnableHeadersVisualStyles = false;
            this.dataGriedViewListaAcordos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGriedViewListaAcordos.Location = new System.Drawing.Point(0, 0);
            this.dataGriedViewListaAcordos.Name = "dataGriedViewListaAcordos";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGriedViewListaAcordos.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.NullValue = "            - ";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGriedViewListaAcordos.RowTemplate.Height = 28;
            this.dataGriedViewListaAcordos.RowTemplate.ReadOnly = true;
            this.dataGriedViewListaAcordos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedViewListaAcordos.Size = new System.Drawing.Size(848, 524);
            this.dataGriedViewListaAcordos.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGriedViewListaAcordos);
            this.panel2.Location = new System.Drawing.Point(175, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 524);
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
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(578, 130);
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
            this.label3.Location = new System.Drawing.Point(172, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Buscar por:";
            // 
            // rbNumeroProcessual
            // 
            this.rbNumeroProcessual.AutoSize = true;
            this.rbNumeroProcessual.Location = new System.Drawing.Point(175, 107);
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
            this.rbInstituicao.Location = new System.Drawing.Point(298, 107);
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
            this.rbInteressado.Location = new System.Drawing.Point(377, 107);
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
            this.txtCampoDeBusca.Location = new System.Drawing.Point(175, 130);
            this.txtCampoDeBusca.Name = "txtCampoDeBusca";
            this.txtCampoDeBusca.Size = new System.Drawing.Size(397, 26);
            this.txtCampoDeBusca.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Filtrar por:";
            // 
            // cbTipoDeAcordo
            // 
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
            this.cbTipoDeAcordo.Location = new System.Drawing.Point(12, 192);
            this.cbTipoDeAcordo.Name = "cbTipoDeAcordo";
            this.cbTipoDeAcordo.Size = new System.Drawing.Size(150, 21);
            this.cbTipoDeAcordo.TabIndex = 34;
            this.cbTipoDeAcordo.SelectedIndexChanged += new System.EventHandler(this.cbTipoDeAcordo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tipo de Acordo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Situação";
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacao.ForeColor = System.Drawing.Color.Gray;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Todos",
            "Acordo Geral",
            "Cotutela",
            "Consórcio",
            "Mobilidade",
            "Memorando de Entendimento",
            "Outros"});
            this.cbSituacao.Location = new System.Drawing.Point(12, 243);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(150, 21);
            this.cbSituacao.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Continente";
            // 
            // cbContinente
            // 
            this.cbContinente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContinente.ForeColor = System.Drawing.Color.Gray;
            this.cbContinente.FormattingEnabled = true;
            this.cbContinente.Items.AddRange(new object[] {
            "Todos",
            "Acordo Geral",
            "Cotutela",
            "Consórcio",
            "Mobilidade",
            "Memorando de Entendimento",
            "Outros"});
            this.cbContinente.Location = new System.Drawing.Point(12, 293);
            this.cbContinente.Name = "cbContinente";
            this.cbContinente.Size = new System.Drawing.Size(150, 21);
            this.cbContinente.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "País";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPais.ForeColor = System.Drawing.Color.Gray;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "Todos",
            "Acordo Geral",
            "Cotutela",
            "Consórcio",
            "Mobilidade",
            "Memorando de Entendimento",
            "Outros"});
            this.cbPais.Location = new System.Drawing.Point(12, 341);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(150, 21);
            this.cbPais.TabIndex = 40;
            // 
            // frmVisualizarAcordos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 749);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbContinente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipoDeAcordo);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoDeAcordo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbContinente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPais;
    }
}