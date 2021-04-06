
namespace TESTENET.Formularios
{
    partial class FrmConsultaAudiencia
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
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.ListView();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.ComboPrincipal = new System.Windows.Forms.ComboBox();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.GrupoMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrupoMenu
            // 
            this.GrupoMenu.AllowMerge = false;
            this.GrupoMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GrupoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GrupoMenu.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.GrupoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.GrupoMenu.Location = new System.Drawing.Point(0, 0);
            this.GrupoMenu.Name = "GrupoMenu";
            this.GrupoMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.GrupoMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.GrupoMenu.Size = new System.Drawing.Size(692, 24);
            this.GrupoMenu.TabIndex = 76;
            this.GrupoMenu.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.novoToolStripMenuItem.Tag = "Novo";
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.ToolTipText = "Inserir um Novo Registro";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.alterarToolStripMenuItem.Tag = "Alterar";
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.ToolTipText = "\r\nAlterar cadastro médico ";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.excluirToolStripMenuItem.Tag = "Excluir";
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.sairToolStripMenuItem1.Tag = "Sair";
            this.sairToolStripMenuItem1.Text = "Sair ou {Esc}";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 18);
            this.label1.TabIndex = 92;
            this.label1.Text = "CONSULTA AUDIENCIA";
            // 
            // Lista
            // 
            this.Lista.BackColor = System.Drawing.SystemColors.Window;
            this.Lista.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Lista.FullRowSelect = true;
            this.Lista.GridLines = true;
            this.Lista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Lista.HideSelection = false;
            this.Lista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lista.Location = new System.Drawing.Point(15, 70);
            this.Lista.MultiSelect = false;
            this.Lista.Name = "Lista";
            this.Lista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lista.RightToLeftLayout = true;
            this.Lista.Size = new System.Drawing.Size(658, 418);
            this.Lista.TabIndex = 103;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.View = System.Windows.Forms.View.Details;
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.White;
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(374, 43);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(202, 21);
            this.TxtNome.TabIndex = 102;
            // 
            // ComboPrincipal
            // 
            this.ComboPrincipal.BackColor = System.Drawing.SystemColors.Info;
            this.ComboPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPrincipal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboPrincipal.FormattingEnabled = true;
            this.ComboPrincipal.Items.AddRange(new object[] {
            "Nome",
            "Código"});
            this.ComboPrincipal.Location = new System.Drawing.Point(59, 43);
            this.ComboPrincipal.Name = "ComboPrincipal";
            this.ComboPrincipal.Size = new System.Drawing.Size(241, 21);
            this.ComboPrincipal.TabIndex = 101;
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltro.ForeColor = System.Drawing.Color.Black;
            this.LblFiltro.Location = new System.Drawing.Point(19, 51);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(51, 13);
            this.LblFiltro.TabIndex = 100;
            this.LblFiltro.Tag = "Filtro";
            this.LblFiltro.Text = "Filtro     ";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisar.Location = new System.Drawing.Point(582, 37);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(98, 27);
            this.BtnPesquisar.TabIndex = 99;
            this.BtnPesquisar.Tag = "Pesquisar";
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(306, 51);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 98;
            this.lblDescricao.Tag = "Descricao";
            this.lblDescricao.Text = "Descrição";
            // 
            // FrmConsultaAudiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 504);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.ComboPrincipal);
            this.Controls.Add(this.LblFiltro);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrupoMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaAudiencia";
            this.Text = "FrmAudiencia";
            this.Load += new System.EventHandler(this.FrmConsultaAudiencia_Load);
            this.GrupoMenu.ResumeLayout(false);
            this.GrupoMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GrupoMenu;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.TextBox TxtNome;
        public System.Windows.Forms.ComboBox ComboPrincipal;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label lblDescricao;
    }
}