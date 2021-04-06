using System;
using System.Windows.Forms;
using TESTENET.Formularios;

namespace TESTENET
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void aRQUIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.IsMdiContainer = true;
                if (Funcoes.Validacoes.FormularioAtivo != null)
                    Funcoes.Validacoes.FormularioAtivo.Close();
                if (Funcoes.Validacoes.FormularioAtivo2 != null)
                    Funcoes.Validacoes.FormularioAtivo2.Close();


                //FrmConsultaContas novoForm = new FrmConsultaContas();

                //Funcoes.Validacoes.FormularioAtivo2 = novoForm;
                //painelPrincipal.BringToFront();
                //// painelPrincipal.Size = new Size(1028, 499);
                //novoForm.MdiParent = this;
                //painelPrincipal.Controls.Add(novoForm);
                //novoForm.Dock = DockStyle.Fill;
                //Funcoes.Validacoes.CarregaouTelaBalanca = false;
                //novoForm.BringToFront();
                //novoForm.Show();


            }
            catch
            {
                MessageBox.Show("Erro o carregar a tela por favor verifique se existe camera instalada", "AVISO");
            }
        }

        private void toolStripMenuEmissoras_Click(object sender, EventArgs e)
        {
            try
            {
                this.IsMdiContainer = true;
                if (Funcoes.Validacoes.FormularioAtivo != null)
                    Funcoes.Validacoes.FormularioAtivo.Close();
                if (Funcoes.Validacoes.FormularioAtivo2 != null)
                    Funcoes.Validacoes.FormularioAtivo2.Close();


                FrmConsultaEmissoras novoForm = new FrmConsultaEmissoras();

                Funcoes.Validacoes.FormularioAtivo2 = novoForm;
                painelPrincipal.BringToFront();
                // painelPrincipal.Size = new Size(1028, 499);
                novoForm.MdiParent = this;
                painelPrincipal.Controls.Add(novoForm);
                novoForm.Dock = DockStyle.Fill;
                Funcoes.Validacoes.CarregaouTelaBalanca = false;
                novoForm.BringToFront();
                novoForm.Show();


            }
            catch
            {
                MessageBox.Show("Erro o carregar a tela por favor verifique se existe camera instalada", "AVISO");
            }
        }

        private void aUDIENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.IsMdiContainer = true;
                if (Funcoes.Validacoes.FormularioAtivo != null)
                    Funcoes.Validacoes.FormularioAtivo.Close();
                if (Funcoes.Validacoes.FormularioAtivo2 != null)
                    Funcoes.Validacoes.FormularioAtivo2.Close();


                FrmConsultaAudiencia novoForm = new FrmConsultaAudiencia();

                Funcoes.Validacoes.FormularioAtivo2 = novoForm;
                painelPrincipal.BringToFront();
                // painelPrincipal.Size = new Size(1028, 499);
                novoForm.MdiParent = this;
                painelPrincipal.Controls.Add(novoForm);
                novoForm.Dock = DockStyle.Fill;
                Funcoes.Validacoes.CarregaouTelaBalanca = false;
                novoForm.BringToFront();
                novoForm.Show();


            }
            catch
            {
                MessageBox.Show("Erro o carregar a tela por favor verifique se existe camera instalada", "AVISO");
            }
        }

        private void ausdienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (Funcoes.Validacoes.FormularioAtivo != null)
            {
                Funcoes.Validacoes.FormularioAtivo.Close();
                if (Funcoes.Validacoes.FormularioAtivo2 != null)
                    Funcoes.Validacoes.FormularioAtivo2.Close();
            }
            FrmRelAudiencia novoForm = new FrmRelAudiencia();
            Funcoes.Validacoes.FormularioAtivo2 = novoForm;
            novoForm.MdiParent = this;
            painelPrincipal.Controls.Add(novoForm);
            novoForm.Dock = DockStyle.Fill;
            Funcoes.Validacoes.CarregaouTelaBalanca = false;
            novoForm.Show();
        }
    }
    
}
