using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTENET.Formularios
{
    public partial class FrmRelAudiencia : Form
    {
        public FrmRelAudiencia()
        {
            InitializeComponent();
        }

        private void FrmRelAudiencia_Load(object sender, EventArgs e)
        {
            ComboTipo.SelectedIndex = 0;



        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            sPR_REL_AUDIENCIATableAdapter.Connection.ConnectionString = conexaoprincipal.StrConexao.ToString();
            string Data1 = dtInicialData.Value.ToString().Substring(0,10);
            DateTime Datafinal = dtFinallData.Value.AddDays(1);
            string Data2 = Datafinal.ToString().Substring(0, 10) + " 00:00";
            string Titulo = "";
            if (ComboTipo.SelectedIndex == 0)
            {
                this.sPR_REL_AUDIENCIATableAdapter.Fill(dataSet1.SPR_REL_AUDIENCIA, 1, Data1, Data2);
                Titulo = "RELATÓRIO DE AUDIÊNCIA POR DIA (SOMATORIO)";
            }
            else
            {
                this.sPR_REL_AUDIENCIATableAdapter.Fill(dataSet1.SPR_REL_AUDIENCIA, 2, Data1, Data2);
                Titulo = "RELATÓRIO DE AUDIÊNCIA POR DIA (MÉDIA)";
            }
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[1];
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("tiporel", Titulo);



            string dirAtual = Directory.GetCurrentDirectory();
            reportViewer1.LocalReport.ReportPath = dirAtual + "\\RelatorioAudiencia.rdlc";
            reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
