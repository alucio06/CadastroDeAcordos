namespace CadastroDeAcordos
{
    partial class frmTelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicial));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAtualizarStatus = new FontAwesome.Sharp.IconButton();
            this.btnCadastrarAcordo = new FontAwesome.Sharp.IconButton();
            this.btnVisualizarAcordos = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.btnAtualizarStatus);
            this.panelMenu.Controls.Add(this.btnCadastrarAcordo);
            this.panelMenu.Controls.Add(this.btnVisualizarAcordos);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(182, 429);
            this.panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "____________________________";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 44);
            this.panel3.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSair.IconColor = System.Drawing.Color.White;
            this.btnSair.IconSize = 18;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(105, 0);
            this.btnSair.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Rotation = 0D;
            this.btnSair.Size = new System.Drawing.Size(77, 44);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 44);
            this.panel4.TabIndex = 6;
            // 
            // btnAtualizarStatus
            // 
            this.btnAtualizarStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizarStatus.FlatAppearance.BorderSize = 0;
            this.btnAtualizarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAtualizarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarStatus.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarStatus.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnAtualizarStatus.IconColor = System.Drawing.Color.White;
            this.btnAtualizarStatus.IconSize = 22;
            this.btnAtualizarStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarStatus.Location = new System.Drawing.Point(0, 152);
            this.btnAtualizarStatus.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAtualizarStatus.Name = "btnAtualizarStatus";
            this.btnAtualizarStatus.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAtualizarStatus.Rotation = 0D;
            this.btnAtualizarStatus.Size = new System.Drawing.Size(182, 49);
            this.btnAtualizarStatus.TabIndex = 4;
            this.btnAtualizarStatus.Text = "Atualizar Status";
            this.btnAtualizarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizarStatus.UseVisualStyleBackColor = true;
            this.btnAtualizarStatus.Click += new System.EventHandler(this.btnAtualizarStatus_Click);
            // 
            // btnCadastrarAcordo
            // 
            this.btnCadastrarAcordo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrarAcordo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAcordo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAcordo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCadastrarAcordo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAcordo.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarAcordo.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnCadastrarAcordo.IconColor = System.Drawing.Color.White;
            this.btnCadastrarAcordo.IconSize = 22;
            this.btnCadastrarAcordo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarAcordo.Location = new System.Drawing.Point(0, 103);
            this.btnCadastrarAcordo.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnCadastrarAcordo.Name = "btnCadastrarAcordo";
            this.btnCadastrarAcordo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastrarAcordo.Rotation = 0D;
            this.btnCadastrarAcordo.Size = new System.Drawing.Size(182, 49);
            this.btnCadastrarAcordo.TabIndex = 3;
            this.btnCadastrarAcordo.Text = "Cadastrar Acordo";
            this.btnCadastrarAcordo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarAcordo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarAcordo.UseVisualStyleBackColor = true;
            this.btnCadastrarAcordo.Click += new System.EventHandler(this.btnCadastrarAcordo_Click);
            // 
            // btnVisualizarAcordos
            // 
            this.btnVisualizarAcordos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisualizarAcordos.FlatAppearance.BorderSize = 0;
            this.btnVisualizarAcordos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarAcordos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVisualizarAcordos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarAcordos.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarAcordos.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnVisualizarAcordos.IconColor = System.Drawing.Color.White;
            this.btnVisualizarAcordos.IconSize = 22;
            this.btnVisualizarAcordos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarAcordos.Location = new System.Drawing.Point(0, 54);
            this.btnVisualizarAcordos.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnVisualizarAcordos.Name = "btnVisualizarAcordos";
            this.btnVisualizarAcordos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnVisualizarAcordos.Rotation = 0D;
            this.btnVisualizarAcordos.Size = new System.Drawing.Size(182, 49);
            this.btnVisualizarAcordos.TabIndex = 2;
            this.btnVisualizarAcordos.Text = "Visualizar Acordos";
            this.btnVisualizarAcordos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarAcordos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisualizarAcordos.UseVisualStyleBackColor = true;
            this.btnVisualizarAcordos.Click += new System.EventHandler(this.btnVisualizarAcordos_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 54);
            this.panel2.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Gainsboro;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(182, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(589, 429);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 429);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTelaInicial";
            this.Text = "Acordos Internacionais";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnVisualizarAcordos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnSair;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnAtualizarStatus;
        private FontAwesome.Sharp.IconButton btnCadastrarAcordo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

