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
            this.btnAcordosVigentes = new FontAwesome.Sharp.IconButton();
            this.btnListaDeAcordos = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(104)))), ((int)(((byte)(189)))));
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.btnAcordosVigentes);
            this.panelMenu.Controls.Add(this.btnListaDeAcordos);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(182, 749);
            this.panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 692);
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
            this.panel3.Location = new System.Drawing.Point(0, 705);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 44);
            this.panel3.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // btnAcordosVigentes
            // 
            this.btnAcordosVigentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcordosVigentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcordosVigentes.FlatAppearance.BorderSize = 0;
            this.btnAcordosVigentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcordosVigentes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAcordosVigentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcordosVigentes.ForeColor = System.Drawing.Color.White;
            this.btnAcordosVigentes.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnAcordosVigentes.IconColor = System.Drawing.Color.White;
            this.btnAcordosVigentes.IconSize = 24;
            this.btnAcordosVigentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcordosVigentes.Location = new System.Drawing.Point(0, 143);
            this.btnAcordosVigentes.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAcordosVigentes.Name = "btnAcordosVigentes";
            this.btnAcordosVigentes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAcordosVigentes.Rotation = 0D;
            this.btnAcordosVigentes.Size = new System.Drawing.Size(182, 49);
            this.btnAcordosVigentes.TabIndex = 4;
            this.btnAcordosVigentes.Text = "Acordos Vigentes";
            this.btnAcordosVigentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcordosVigentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcordosVigentes.UseVisualStyleBackColor = true;
            this.btnAcordosVigentes.Click += new System.EventHandler(this.btnAtualizarStatus_Click);
            // 
            // btnListaDeAcordos
            // 
            this.btnListaDeAcordos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaDeAcordos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaDeAcordos.FlatAppearance.BorderSize = 0;
            this.btnListaDeAcordos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDeAcordos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListaDeAcordos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaDeAcordos.ForeColor = System.Drawing.Color.White;
            this.btnListaDeAcordos.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnListaDeAcordos.IconColor = System.Drawing.Color.White;
            this.btnListaDeAcordos.IconSize = 24;
            this.btnListaDeAcordos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaDeAcordos.Location = new System.Drawing.Point(0, 94);
            this.btnListaDeAcordos.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnListaDeAcordos.Name = "btnListaDeAcordos";
            this.btnListaDeAcordos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnListaDeAcordos.Rotation = 0D;
            this.btnListaDeAcordos.Size = new System.Drawing.Size(182, 49);
            this.btnListaDeAcordos.TabIndex = 3;
            this.btnListaDeAcordos.Text = "Lista de Acordos";
            this.btnListaDeAcordos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaDeAcordos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaDeAcordos.UseVisualStyleBackColor = true;
            this.btnListaDeAcordos.Click += new System.EventHandler(this.btnListaDeAcordos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconSize = 24;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 45);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.Rotation = 0D;
            this.btnDashboard.Size = new System.Drawing.Size(182, 49);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.lblNomeUsuario);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 45);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(152)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(10, 9);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 33);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblNomeUsuario.Location = new System.Drawing.Point(42, 16);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(92, 15);
            this.lblNomeUsuario.TabIndex = 1;
            this.lblNomeUsuario.Text = "Anderson Lúcio";
            this.lblNomeUsuario.Click += new System.EventHandler(this.lblNomeUsuario_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Gainsboro;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(182, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1082, 749);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::CadastroDeAcordos.Properties.Resources.Logo_PROINTER___Transparente;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmTelaInicial";
            this.Text = "Acordos Internacionais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTelaInicial_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnSair;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnListaDeAcordos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnAcordosVigentes;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblNomeUsuario;
    }
}

