namespace TESTENET
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRQUIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEmissoras = new System.Windows.Forms.ToolStripMenuItem();
            this.aUDIENCIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATÓRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.ausdienciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRQUIVOToolStripMenuItem,
            this.cADASTROToolStripMenuItem,
            this.rELATÓRIOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRQUIVOToolStripMenuItem
            // 
            this.aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.aRQUIVOToolStripMenuItem.Image = global::TESTENET.Properties.Resources.Arquivo;
            this.aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            this.aRQUIVOToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.aRQUIVOToolStripMenuItem.Text = "ARQUIVO";
            this.aRQUIVOToolStripMenuItem.Click += new System.EventHandler(this.aRQUIVOToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::TESTENET.Properties.Resources.saida3;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEmissoras,
            this.aUDIENCIAToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Image = global::TESTENET.Properties.Resources.cadastro1;
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            this.cADASTROToolStripMenuItem.Click += new System.EventHandler(this.cADASTROToolStripMenuItem_Click);
            // 
            // toolStripMenuEmissoras
            // 
            this.toolStripMenuEmissoras.Name = "toolStripMenuEmissoras";
            this.toolStripMenuEmissoras.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuEmissoras.Text = "Emissoras";
            this.toolStripMenuEmissoras.Click += new System.EventHandler(this.toolStripMenuEmissoras_Click);
            // 
            // aUDIENCIAToolStripMenuItem
            // 
            this.aUDIENCIAToolStripMenuItem.Name = "aUDIENCIAToolStripMenuItem";
            this.aUDIENCIAToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aUDIENCIAToolStripMenuItem.Text = "Audiencia";
            this.aUDIENCIAToolStripMenuItem.Click += new System.EventHandler(this.aUDIENCIAToolStripMenuItem_Click);
            // 
            // rELATÓRIOSToolStripMenuItem
            // 
            this.rELATÓRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausdienciaToolStripMenuItem});
            this.rELATÓRIOSToolStripMenuItem.Image = global::TESTENET.Properties.Resources.printer__1_;
            this.rELATÓRIOSToolStripMenuItem.Name = "rELATÓRIOSToolStripMenuItem";
            this.rELATÓRIOSToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.rELATÓRIOSToolStripMenuItem.Text = "RELATÓRIOS";
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.BackgroundImage = global::TESTENET.Properties.Resources.Bg;
            this.painelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.painelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(1041, 656);
            this.painelPrincipal.TabIndex = 1;
            // 
            // ausdienciaToolStripMenuItem
            // 
            this.ausdienciaToolStripMenuItem.Name = "ausdienciaToolStripMenuItem";
            this.ausdienciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ausdienciaToolStripMenuItem.Text = "Audiencia";
            this.ausdienciaToolStripMenuItem.Click += new System.EventHandler(this.ausdienciaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 656);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.painelPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TESTENET";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATÓRIOSToolStripMenuItem;
        public System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEmissoras;
        private System.Windows.Forms.ToolStripMenuItem aUDIENCIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausdienciaToolStripMenuItem;
    }
}

