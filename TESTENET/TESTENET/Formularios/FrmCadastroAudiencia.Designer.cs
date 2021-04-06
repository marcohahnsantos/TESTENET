
namespace TESTENET.Formularios
{
    partial class FrmCadastroAudiencia
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblValorCodigo = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblOperacao = new System.Windows.Forms.Label();
            this.ComboEmissoras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtHorInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPontos = new System.Windows.Forms.TextBox();
            this.GrupoMenu.SuspendLayout();
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
            this.GrupoMenu.Size = new System.Drawing.Size(693, 24);
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
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // LblValorCodigo
            // 
            this.LblValorCodigo.AutoSize = true;
            this.LblValorCodigo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorCodigo.ForeColor = System.Drawing.Color.Black;
            this.LblValorCodigo.Location = new System.Drawing.Point(306, 38);
            this.LblValorCodigo.Name = "LblValorCodigo";
            this.LblValorCodigo.Size = new System.Drawing.Size(99, 18);
            this.LblValorCodigo.TabIndex = 91;
            this.LblValorCodigo.Text = "Valor Codigo";
            this.LblValorCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblValorCodigo.Visible = false;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Black;
            this.LblCodigo.Location = new System.Drawing.Point(234, 38);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(66, 18);
            this.LblCodigo.TabIndex = 89;
            this.LblCodigo.Text = "Código :";
            this.LblCodigo.Visible = false;
            // 
            // LblOperacao
            // 
            this.LblOperacao.AutoSize = true;
            this.LblOperacao.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperacao.ForeColor = System.Drawing.Color.Black;
            this.LblOperacao.Location = new System.Drawing.Point(41, 38);
            this.LblOperacao.Name = "LblOperacao";
            this.LblOperacao.Size = new System.Drawing.Size(187, 18);
            this.LblOperacao.TabIndex = 90;
            this.LblOperacao.Text = "Operação com Registros";
            // 
            // ComboEmissoras
            // 
            this.ComboEmissoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboEmissoras.FormattingEnabled = true;
            this.ComboEmissoras.Items.AddRange(new object[] {
            "RECEITA",
            "DESPESA"});
            this.ComboEmissoras.Location = new System.Drawing.Point(119, 72);
            this.ComboEmissoras.Name = "ComboEmissoras";
            this.ComboEmissoras.Size = new System.Drawing.Size(353, 28);
            this.ComboEmissoras.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 104;
            this.label1.Text = "Emissoras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 106;
            this.label2.Text = "Data ";
            // 
            // DtData
            // 
            this.DtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtData.Location = new System.Drawing.Point(119, 113);
            this.DtData.Name = "DtData";
            this.DtData.Size = new System.Drawing.Size(353, 26);
            this.DtData.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 108;
            this.label3.Text = "Horário";
            // 
            // TxtHorInicio
            // 
            this.TxtHorInicio.BackColor = System.Drawing.SystemColors.Info;
            this.TxtHorInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHorInicio.ForeColor = System.Drawing.Color.Black;
            this.TxtHorInicio.Location = new System.Drawing.Point(580, 113);
            this.TxtHorInicio.Name = "TxtHorInicio";
            this.TxtHorInicio.ReadOnly = true;
            this.TxtHorInicio.Size = new System.Drawing.Size(101, 26);
            this.TxtHorInicio.TabIndex = 109;
            this.TxtHorInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtHorInicio.Enter += new System.EventHandler(this.TxtHorInicio_Enter);
            this.TxtHorInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHorInicio_KeyDown);
            this.TxtHorInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHorInicio_KeyPress);
            this.TxtHorInicio.Leave += new System.EventHandler(this.TxtHorInicio_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 110;
            this.label4.Text = "Pontos";
            // 
            // TxtPontos
            // 
            this.TxtPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPontos.Location = new System.Drawing.Point(119, 152);
            this.TxtPontos.MaxLength = 5;
            this.TxtPontos.Name = "TxtPontos";
            this.TxtPontos.Size = new System.Drawing.Size(121, 26);
            this.TxtPontos.TabIndex = 111;
            this.TxtPontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPontos.Enter += new System.EventHandler(this.TxtPontos_Enter);
            this.TxtPontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPontos_KeyPress);
            this.TxtPontos.Leave += new System.EventHandler(this.TxtPontos_Leave);
            // 
            // FrmCadastroAudiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 192);
            this.Controls.Add(this.TxtPontos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtHorInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboEmissoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblValorCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.LblOperacao);
            this.Controls.Add(this.GrupoMenu);
            this.Name = "FrmCadastroAudiencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Audiência";
            this.Load += new System.EventHandler(this.FrmCadastroAudiencia_Load);
            this.GrupoMenu.ResumeLayout(false);
            this.GrupoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GrupoMenu;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LblValorCodigo;
        public System.Windows.Forms.Label LblCodigo;
        public System.Windows.Forms.Label LblOperacao;
        public System.Windows.Forms.ComboBox ComboEmissoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtHorInicio;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker DtData;
        public System.Windows.Forms.TextBox TxtPontos;
    }
}