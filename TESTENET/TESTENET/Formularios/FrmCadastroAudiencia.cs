using System;
using System.Collections;
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
    public partial class FrmCadastroAudiencia : Form
    {
        public Color cor = new Color();
        ToolTip tip = new ToolTip();
        FrmPrincipal form = new FrmPrincipal();
       
        public FrmCadastroAudiencia()
        {
            InitializeComponent();
            
        }

        private void Carrega_ComboEmissoras()
        {
            ArrayList arr1 = new ArrayList();
            arr1 = Funcoes.Operacoes.CarregaCombo(1, "EMISSORAS", "ID,UPPER(NOME)", "");
            ComboEmissoras.DataSource = arr1;
            ComboEmissoras.DisplayMember = "nome";
            ComboEmissoras.ValueMember = "valor";
        }

        private void FrmCadastroAudiencia_Load(object sender, EventArgs e)
        {
            Carrega_ComboEmissoras();
            cor = TxtPontos.BackColor;
            ComboEmissoras.SelectedIndex = 0;
            int Id_emissora = 0;
            if (LblOperacao.Text == "ALTERAÇÃO DE REGISTRO")
            {
                ComboEmissoras.Text = Funcoes.Validacoes.ComboEmissora;
            }
          this.TxtHorInicio.Text = "00:00";
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtHorInicio_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectionStart = 0;
            ((TextBox)sender).SelectionLength = 1;
            Funcoes.Operacoes.TrocaTABporEnter(TxtHorInicio);
        }

        private void TxtHorInicio_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtHorInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Essa linha serve para impedir o evento de ocorrer como normalmente ocorreria. É como dizer ao compilador que o evento já foi tratado. Isso serve, nesse caso, como uma garantia de que a função de determinadas teclas não seja executada.*/
            e.Handled = true;

            /*Determina o número de caracteres selecionados na TextBox, isso evita que o usuário selecione e substitua mais de um caracter, o que poderia remover a máscara da TextBox.*/
            ((TextBox)sender).SelectionLength = 1;

            /*A propriedade SelectionStart indica a posição do cursor. A partir dela podemos limitar as condições de cada caracter.*/
            switch (((TextBox)sender).SelectionStart)
            {
                case 0:
                    /*Cursor na posição zero. Significa que o caracter a ser substituído é o primeiro.*/
                    switch (e.KeyChar)
                    {
                        /*Limitado para aceitar de 0 a 2.*/
                        case '0':
                        case '1':
                        case '2':
                            /*Substitui o caracter selecionado pelo digitado.*/
                            ((TextBox)sender).SelectedText = e.KeyChar.ToString();
                            /*Uma vez executada essa instrução a propriedade SelectionStart terá sido incrementada, o que significa que o cursor já está em posição para substituir o próximo caracter.*/
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    /*Cursor na posição um. Significa que o caracter a ser substituído é o segundo.*/
                    if (((TextBox)sender).Text[0] == '2')
                        switch (e.KeyChar)
                        {
                            /*No caso de o primeiro caracter ser '2', limitados o segundo entre 0 e 3.*/
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                                ((TextBox)sender).SelectedText = e.KeyChar.ToString();
                                /*Aqui é necessário incrementar a SelectionStart, pois o cursor está em frente ao ':' da máscara, o que faria com que ele fosse o substituído na próxima digitação, e isto não deve acontecer.*/
                                ((TextBox)sender).SelectionStart++;
                                break;
                            default:
                                break;
                        }
                    /*Se o primeiro caracter for diferente de '2' vai para default, que é para inserir caracteres de 0 a 9. Muitas pessoas me trucidariam por causa do 'goto'. Vou escrever um pouco sobre isso depois.*/
                    else goto default;
                    break;
                case 3:
                    switch (e.KeyChar)
                    {
                        /*Limitado para aceitar de 0 a 5.*/
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                            ((TextBox)sender).SelectedText = e.KeyChar.ToString();
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    /*Se o usuário por acaso colocar o cursor na última posição da TextBox, o caracter substituído será o primeiro.*/
                    ((TextBox)sender).SelectionStart = 0;
                    ((TextBox)sender).SelectionLength = 1;
                    goto case 0;
                default:
                    switch (e.KeyChar)
                    {
                        /*Por default a TextBox aceitará caracteres de 0 a 9. Isso acontecerá no segundo caracter, quando ele for diferente de dois, e no quinto caracter. Resolvi deixar essa parte no default, já que outras posições não deverão existir na TextBox com máscara.*/
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            ((TextBox)sender).SelectedText = e.KeyChar.ToString();
                            /*Se a SelectionStart for igual a 2 significa que o cursor está na frente do ':', por isso ela deve ser incrementada, impedindo que o ':' seja substituído. Se ela for igual a 5, significa que chegou no final da máscara, então ela volta para o começo.*/
                            if (((TextBox)sender).SelectionStart == 2)
                                ((TextBox)sender).SelectionStart++;
                            else if (((TextBox)sender).SelectionStart == 5)
                                ((TextBox)sender).SelectionStart = 0;
                            break;
                        default:
                            break;
                    }
                    break;
            }
            /*Aqui é uma questão visual. Pode parecer repetitivo executar essa instrução no início e no fim do evento, mas lá no início ela era uma questão de segurança. Aqui o que ela fará é deixar o próximo caracter selecionado, deixando o usuário saber qual o caracter que ele está prestes a substituir na próxima digitação.*/
            ((TextBox)sender).SelectionLength = 1;

        }

        private void TxtPontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.Validacoes.SoNumero(TxtPontos.Text, e);
        }

        private void TxtPontos_Enter(object sender, EventArgs e)
        {
            Funcoes.Operacoes.TrocaTABporEnter(TxtPontos);
        }

        private void TxtPontos_Leave(object sender, EventArgs e)
        {
            this.TxtPontos.BackColor = cor;
        }

        private void TxtHorInicio_Leave(object sender, EventArgs e)
        {
            this.TxtHorInicio.BackColor = cor;
        }

        private void gravarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtHorInicio.Text == "")
                {
                    MessageBox.Show("Campo de Preechimento Obrigatório", "AVISO");
                    TxtHorInicio.Focus();
                    return;
                }
                if (TxtPontos.Text == "")
                {
                    MessageBox.Show("Campo de Preechimento Obrigatório", "AVISO");
                    TxtPontos.Focus();
                    return;
                }

                if (LblOperacao.Text == "NOVO REGISTRO")
                {
                    tip.Dispose();
                    string Swhere = $"ID_EMISSORA_AUDIENCIA={ComboEmissoras.SelectedValue} AND "+
                                    $"DATA_HORA_AUDIENCIA='{DtData.Value.ToShortDateString()} {TxtHorInicio.Text}'";
                    string Existe = Funcoes.Operacoes.CapturaCampoTabela(5, "AUDIENCIA", "ID", Swhere.ToString(), "");
                    if (Existe != "")
                    {
                        MessageBox.Show("Já existe uma emissora  cadastrada com este data ", "AVISO");
                        ComboEmissoras.Focus();
                        return;
                    }
                    string NomeCampos = @"ID_EMISSORA_AUDIENCIA,DATA_HORA_AUDIENCIA,PONTOS_AUDIENCIA";
                    string ValuesCampos = $"{ComboEmissoras.SelectedValue},'{DtData.Value.ToShortDateString()} {TxtHorInicio.Text}',{TxtPontos.Text.Replace(",",".")}";
                    bool RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "AUDIENCIA", "ID", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");
                    if (RetornoGravacao == true)
                        Close();
                }
                if (LblOperacao.Text == "ALTERAÇÃO DE REGISTRO")
                {
                    string ValorSet = @" PONTOS_AUDIENCIA=" + TxtPontos.Text.Replace(",",".");
                    bool RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(2, "AUDIENCIA", "ID", ValorSet.ToString(), "", LblValorCodigo.Text, "SPR_GRAVA_REGISTRO");
                    if (RetornoGravacao == true)
                        this.Close();
                }
            }
            catch (Exception ERRO)
            {
                string Error = ERRO.ToString();
            }
        }
    }
}
