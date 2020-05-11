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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtvListaAcordos = new System.Windows.Forms.DataGridView();
            this.acordossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDeAcordosDataSet = new CadastroDeAcordos.CadastroDeAcordosDataSet();
            this.acordossTableAdapter = new CadastroDeAcordos.CadastroDeAcordosDataSetTableAdapters.AcordossTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numeroProcessualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAcordoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instituicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPublicacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interessadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUltStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoAcordo = new FontAwesome.Sharp.IconButton();
            this.btnAtualizarLista = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvListaAcordos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acordossBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(766, 45);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(318, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visualizar Acordos";
            // 
            // dtvListaAcordos
            // 
            this.dtvListaAcordos.AllowUserToAddRows = false;
            this.dtvListaAcordos.AllowUserToDeleteRows = false;
            this.dtvListaAcordos.AutoGenerateColumns = false;
            this.dtvListaAcordos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtvListaAcordos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvListaAcordos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvListaAcordos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtvListaAcordos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtvListaAcordos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvListaAcordos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroProcessualDataGridViewTextBoxColumn,
            this.tipoAcordoDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.continenteDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.instituicaoDataGridViewTextBoxColumn,
            this.dataPublicacaoDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFinalDataGridViewTextBoxColumn,
            this.interessadoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dataUltStatusDataGridViewTextBoxColumn});
            this.dtvListaAcordos.DataSource = this.acordossBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtvListaAcordos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvListaAcordos.EnableHeadersVisualStyles = false;
            this.dtvListaAcordos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtvListaAcordos.Location = new System.Drawing.Point(0, 0);
            this.dtvListaAcordos.Name = "dtvListaAcordos";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtvListaAcordos.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.NullValue = "            - ";
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtvListaAcordos.RowTemplate.Height = 28;
            this.dtvListaAcordos.RowTemplate.ReadOnly = true;
            this.dtvListaAcordos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvListaAcordos.Size = new System.Drawing.Size(692, 399);
            this.dtvListaAcordos.TabIndex = 21;
            this.dtvListaAcordos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvListaAcordos_CellContentClick);
            // 
            // acordossBindingSource
            // 
            this.acordossBindingSource.DataMember = "Acordoss";
            this.acordossBindingSource.DataSource = this.cadastroDeAcordosDataSet;
            // 
            // cadastroDeAcordosDataSet
            // 
            this.cadastroDeAcordosDataSet.DataSetName = "CadastroDeAcordosDataSet";
            this.cadastroDeAcordosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acordossTableAdapter
            // 
            this.acordossTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtvListaAcordos);
            this.panel2.Location = new System.Drawing.Point(15, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 399);
            this.panel2.TabIndex = 22;
            // 
            // numeroProcessualDataGridViewTextBoxColumn
            // 
            this.numeroProcessualDataGridViewTextBoxColumn.DataPropertyName = "numeroProcessual";
            this.numeroProcessualDataGridViewTextBoxColumn.HeaderText = "Número Processual";
            this.numeroProcessualDataGridViewTextBoxColumn.Name = "numeroProcessualDataGridViewTextBoxColumn";
            this.numeroProcessualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoAcordoDataGridViewTextBoxColumn
            // 
            this.tipoAcordoDataGridViewTextBoxColumn.DataPropertyName = "tipoAcordo";
            this.tipoAcordoDataGridViewTextBoxColumn.HeaderText = "Tipo de Acordo";
            this.tipoAcordoDataGridViewTextBoxColumn.Name = "tipoAcordoDataGridViewTextBoxColumn";
            this.tipoAcordoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // continenteDataGridViewTextBoxColumn
            // 
            this.continenteDataGridViewTextBoxColumn.DataPropertyName = "continente";
            this.continenteDataGridViewTextBoxColumn.HeaderText = "Continente";
            this.continenteDataGridViewTextBoxColumn.Name = "continenteDataGridViewTextBoxColumn";
            this.continenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "País";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // instituicaoDataGridViewTextBoxColumn
            // 
            this.instituicaoDataGridViewTextBoxColumn.DataPropertyName = "instituicao";
            this.instituicaoDataGridViewTextBoxColumn.HeaderText = "Instituição";
            this.instituicaoDataGridViewTextBoxColumn.Name = "instituicaoDataGridViewTextBoxColumn";
            this.instituicaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPublicacaoDataGridViewTextBoxColumn
            // 
            this.dataPublicacaoDataGridViewTextBoxColumn.DataPropertyName = "dataPublicacao";
            this.dataPublicacaoDataGridViewTextBoxColumn.HeaderText = "Data de Publicação";
            this.dataPublicacaoDataGridViewTextBoxColumn.Name = "dataPublicacaoDataGridViewTextBoxColumn";
            this.dataPublicacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "dataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "Data de Início";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            this.dataInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFinalDataGridViewTextBoxColumn
            // 
            this.dataFinalDataGridViewTextBoxColumn.DataPropertyName = "dataFinal";
            this.dataFinalDataGridViewTextBoxColumn.HeaderText = "Data Final";
            this.dataFinalDataGridViewTextBoxColumn.Name = "dataFinalDataGridViewTextBoxColumn";
            this.dataFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interessadoDataGridViewTextBoxColumn
            // 
            this.interessadoDataGridViewTextBoxColumn.DataPropertyName = "interessado";
            this.interessadoDataGridViewTextBoxColumn.HeaderText = "Interessado";
            this.interessadoDataGridViewTextBoxColumn.Name = "interessadoDataGridViewTextBoxColumn";
            this.interessadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 300;
            // 
            // dataUltStatusDataGridViewTextBoxColumn
            // 
            this.dataUltStatusDataGridViewTextBoxColumn.DataPropertyName = "dataUltStatus";
            this.dataUltStatusDataGridViewTextBoxColumn.HeaderText = "Última atualização";
            this.dataUltStatusDataGridViewTextBoxColumn.Name = "dataUltStatusDataGridViewTextBoxColumn";
            this.dataUltStatusDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.btnNovoAcordo.Location = new System.Drawing.Point(548, 86);
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
            this.btnAtualizarLista.Location = new System.Drawing.Point(503, 86);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Padding = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.btnAtualizarLista.Rotation = 0D;
            this.btnAtualizarLista.Size = new System.Drawing.Size(39, 36);
            this.btnAtualizarLista.TabIndex = 24;
            this.btnAtualizarLista.UseVisualStyleBackColor = false;
            // 
            // frmVisualizarAcordos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(766, 539);
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
            ((System.ComponentModel.ISupportInitialize)(this.acordossBindingSource)).EndInit();
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
        private CadastroDeAcordosDataSet cadastroDeAcordosDataSet;
        private System.Windows.Forms.BindingSource acordossBindingSource;
        private CadastroDeAcordosDataSetTableAdapters.AcordossTableAdapter acordossTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroProcessualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAcordoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn continenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instituicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPublicacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interessadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUltStatusDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton btnNovoAcordo;
        private FontAwesome.Sharp.IconButton btnAtualizarLista;
    }
}