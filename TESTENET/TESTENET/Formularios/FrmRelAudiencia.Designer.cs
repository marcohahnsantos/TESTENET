
namespace TESTENET.Formularios
{
    partial class FrmRelAudiencia
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtFinallData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtInicialData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sPRRELAUDIENCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TESTENET.Dados.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPR_REL_AUDIENCIATableAdapter = new TESTENET.Dados.DataSet1TableAdapters.SPR_REL_AUDIENCIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPRRELAUDIENCIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFinallData
            // 
            this.dtFinallData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinallData.Location = new System.Drawing.Point(195, 81);
            this.dtFinallData.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtFinallData.Name = "dtFinallData";
            this.dtFinallData.Size = new System.Drawing.Size(389, 26);
            this.dtFinallData.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Período Final";
            // 
            // dtInicialData
            // 
            this.dtInicialData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicialData.Location = new System.Drawing.Point(195, 35);
            this.dtInicialData.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtInicialData.Name = "dtInicialData";
            this.dtInicialData.Size = new System.Drawing.Size(389, 26);
            this.dtInicialData.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Período Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tipo Relatório";
            // 
            // ComboTipo
            // 
            this.ComboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "SOMATÓRIO DIA",
            "MÉDIA DE AUDIENCIA DIA"});
            this.ComboTipo.Location = new System.Drawing.Point(195, 126);
            this.ComboTipo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(389, 28);
            this.ComboTipo.TabIndex = 49;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPRRELAUDIENCIABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TESTENET.Report.RelatorioAudiencia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 165);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1018, 461);
            this.reportViewer1.TabIndex = 50;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisar.Location = new System.Drawing.Point(696, 96);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(156, 58);
            this.BtnPesquisar.TabIndex = 84;
            this.BtnPesquisar.Tag = "Pesquisar";
            this.BtnPesquisar.Text = "Imprimir";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(908, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 58);
            this.button1.TabIndex = 85;
            this.button1.Tag = "Pesquisar";
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sPRRELAUDIENCIABindingSource
            // 
            this.sPRRELAUDIENCIABindingSource.DataMember = "SPR_REL_AUDIENCIA";
            this.sPRRELAUDIENCIABindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // sPR_REL_AUDIENCIATableAdapter
            // 
            this.sPR_REL_AUDIENCIATableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelAudiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFinallData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtInicialData);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmRelAudiencia";
            this.Text = "FrmRelAudiencia";
            this.Load += new System.EventHandler(this.FrmRelAudiencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPRRELAUDIENCIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFinallData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtInicialData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboTipo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPRRELAUDIENCIABindingSource;
        private Dados.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private Dados.DataSet1TableAdapters.SPR_REL_AUDIENCIATableAdapter sPR_REL_AUDIENCIATableAdapter;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button button1;
    }
}