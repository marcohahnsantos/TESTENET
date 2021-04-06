using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTENET.Formularios
{
    public partial class FrmCadastroEmissoras : Form
    {
        public Color cor = new Color();
        ToolTip tip = new ToolTip();
        FrmPrincipal form = new FrmPrincipal();
        string ValoresAnt = "";
        public FrmCadastroEmissoras()
        {
            InitializeComponent();
            cor = TxtNome.BackColor;
        }

        private void gravarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNome.Text == "")
                {
                    MessageBox.Show("Campo de Preechimento Obrigatório", "AVISO");
                    TxtNome.Focus();
                    return;
                }
                if (LblOperacao.Text == "NOVO REGISTRO")
                {
                    tip.Dispose();
                    string Swhere = $"NOME='{TxtNome.Text}'";
                    string Existe = Funcoes.Operacoes.CapturaCampoTabela(5, "EMISSORAS", "NOME", Swhere.ToString(), "");
                    if (Existe != "")
                    {
                        MessageBox.Show("Já existe uma emissora  cadastrada com este nome ", "AVISO");
                        TxtNome.Focus();
                        return;
                    }
                    string NomeCampos = @"NOME";
                    string ValuesCampos = $"'{TxtNome.Text}'";
                    bool RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "EMISSORAS", "ID", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");
                    if (RetornoGravacao == true)
                        Close();
                }
                if (LblOperacao.Text == "ALTERAÇÃO DE REGISTRO")
                {
                    string ValorSet = @" NOME='" + TxtNome.Text + "'";
                    bool RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(2, "EMISSORAS", "ID", ValorSet.ToString(), "", LblValorCodigo.Text, "SPR_GRAVA_REGISTRO");
                    if (RetornoGravacao==true)
                        this.Close();
                }
            }
            catch (Exception ERRO)
            {
                string Error = ERRO.ToString();
            }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Funcoes.Operacoes.VerificaTeclaProssionada(e);
        }
    }
}
