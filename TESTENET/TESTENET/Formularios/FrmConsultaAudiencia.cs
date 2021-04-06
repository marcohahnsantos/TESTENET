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
    public partial class FrmConsultaAudiencia : Form
    {
        public Color cor = new Color();

        ToolTip tip = new ToolTip();
        public FrmConsultaAudiencia()
        {
            InitializeComponent();
            FrmPrincipal formpai = new FrmPrincipal();
        }
       
        private void sairToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Carrega_Lista()
        {
            int TipoPesquisa = 0;
            string CampoPesquisa = "";
            if (ComboPrincipal.Text == "Código")
            {
                TipoPesquisa = 0;
                CampoPesquisa = "ID";
            }
            if (ComboPrincipal.Text == "NOME")
            {
                TipoPesquisa = 1;
                CampoPesquisa = "NOME";
            }
            if (TxtNome.Text.Trim() == "")
            {
                TipoPesquisa = 10;
                CampoPesquisa = "";
            }
            Lista.Clear();
            Lista = Funcoes.Operacoes.CarregaGrade(int.Parse($"{TipoPesquisa.ToString()}"), "EMISSORAS", "ID AS [CODIGO  ]," +
            "NOME  AS [EMISSORA                                  ],AUDIENCIA ", $"{CampoPesquisa}", TxtNome.Text, Lista, "SPR_PESQUISA_CAMPOS_TABELA");
            ComboPrincipal.SelectedIndex = 0;
            TxtNome.Focus();
        }

        private void FrmConsultaAudiencia_Load(object sender, EventArgs e)
        {
            Carrega_Lista();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tip.Dispose();
            FrmCadastroAudiencia form = new FrmCadastroAudiencia();
            form.Location = new Point(360, 185);
            form.LblOperacao.Text = "NOVO REGISTRO";
            form.LblCodigo.Visible = false;
            form.LblValorCodigo.Visible = false;
            //270, 190
            form.Location = new Point(Convert.ToInt32(Funcoes.Validacoes.PosicaoLeft) + 170, Convert.ToInt32(Funcoes.Validacoes.PosicaoTop) + 140);
            form.ShowDialog();
            Carrega_Lista();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tip.Dispose();
            if (Lista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Deve ser Selecionado algum item da Lista", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FrmCadastroAudiencia form = new FrmCadastroAudiencia();
                form.Location = new Point(360, 185);
                form.LblOperacao.Text = "ALTERAÇÃO DE REGISTRO";
                form.LblCodigo.Visible = true;
                form.LblValorCodigo.Visible = true;
                form.LblValorCodigo.Text = Lista.SelectedItems[0].Text;
                form.TxtPontos.Text = Lista.SelectedItems[0].SubItems[2].Text;
                Funcoes.Validacoes.ComboEmissora = Lista.SelectedItems[0].SubItems[1].Text;
                
                form.ComboEmissoras.Enabled = false;
                form.Location = new Point(Convert.ToInt32(Funcoes.Validacoes.PosicaoLeft) + 170, Convert.ToInt32(Funcoes.Validacoes.PosicaoTop) + 140);
                form.ShowDialog();
               
                Carrega_Lista();
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tip.Dispose();
            if (Lista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Deve ser Selecionado algum item da Lista", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Deseja excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    bool RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(6, "AUDIENCIA", "ID", "", "", Lista.SelectedItems[0].Text, "SPR_GRAVA_REGISTRO");
                    if (RetornoGravacao == true)
                    {
                        MessageBox.Show("Registro Excluido com Sucesso", "AVISO");
                        Carrega_Lista();
                    }
                    else
                    {
                        MessageBox.Show(Funcoes.Validacoes.MensagemAviso.ToString(), "AVISO");
                    }
                }
                else
                {
                    MessageBox.Show("OPERAÇÃO CANCELADA", "AVISO");
                }
            }
        }
    }
}
