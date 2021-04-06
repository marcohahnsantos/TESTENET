
namespace TESTENET.Formularios
{
    partial class FrmCadastroEmissoras
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
            this.GrupoMenu = new System.Windows.Forms.MenuStrip();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtCodMedico = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblValorCodigo = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblOperacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.GrupoMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoMenu
            // 
            this.GrupoMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GrupoMenu.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gravarToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.GrupoMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.GrupoMenu.Location = new System.Drawing.Point(0, 0);
            this.GrupoMenu.Name = "GrupoMenu";
            this.GrupoMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.GrupoMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.GrupoMenu.Size = new System.Drawing.Size(495, 24);
            this.GrupoMenu.TabIndex = 88;
            this.GrupoMenu.Text = "menuStrip1";
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gravarToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.gravarToolStripMenuItem.Text = "Gravar";
            this.gravarToolStripMenuItem.Click += new System.EventHandler(this.gravarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sairToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.sairToolStripMenuItem1.Tag = "Sair";
            this.sairToolStripMenuItem1.Text = "Sair ou {Esc}";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.TxtCodMedico);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.LblValorCodigo);
            this.panel3.Controls.Add(this.LblCodigo);
            this.panel3.Controls.Add(this.LblOperacao);
            this.panel3.Controls.Add(this.lblNome);
            this.panel3.Controls.Add(this.TxtNome);
            this.panel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 81);
            this.panel3.TabIndex = 93;
            // 
            // TxtCodMedico
            // 
            this.TxtCodMedico.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodMedico.Location = new System.Drawing.Point(430, 47);
            this.TxtCodMedico.Name = "TxtCodMedico";
            this.TxtCodMedico.Size = new System.Drawing.Size(49, 21);
            this.TxtCodMedico.TabIndex = 102;
            this.TxtCodMedico.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // LblValorCodigo
            // 
            this.LblValorCodigo.AutoSize = true;
            this.LblValorCodigo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorCodigo.ForeColor = System.Drawing.Color.Black;
            this.LblValorCodigo.Location = new System.Drawing.Point(318, 14);
            this.LblValorCodigo.Name = "LblValorCodigo";
            this.LblValorCodigo.Size = new System.Drawing.Size(99, 18);
            this.LblValorCodigo.TabIndex = 7;
            this.LblValorCodigo.Text = "Valor Codigo";
            this.LblValorCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblValorCodigo.Visible = false;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Black;
            this.LblCodigo.Location = new System.Drawing.Point(246, 14);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(66, 18);
            this.LblCodigo.TabIndex = 5;
            this.LblCodigo.Text = "Código :";
            this.LblCodigo.Visible = false;
            // 
            // LblOperacao
            // 
            this.LblOperacao.AutoSize = true;
            this.LblOperacao.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperacao.ForeColor = System.Drawing.Color.Black;
            this.LblOperacao.Location = new System.Drawing.Point(53, 14);
            this.LblOperacao.Name = "LblOperacao";
            this.LblOperacao.Size = new System.Drawing.Size(187, 18);
            this.LblOperacao.TabIndex = 6;
            this.LblOperacao.Text = "Operação com Registros";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(7, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 13);
            this.lblNome.TabIndex = 88;
            this.lblNome.Text = "Emissora";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.SystemColors.Info;
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(99, 47);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(318, 21);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // FrmCadastroEmissoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 107);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GrupoMenu);
            this.Name = "FrmCadastroEmissoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Emissoras";
            this.GrupoMenu.ResumeLayout(false);
            this.GrupoMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GrupoMenu;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox TxtCodMedico;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LblValorCodigo;
        public System.Windows.Forms.Label LblCodigo;
        public System.Windows.Forms.Label LblOperacao;
        private System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.TextBox TxtNome;
    }
}