using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using db = System.Data.OleDb;
using System.Data.SqlClient;
using System.Net;
//using System.Data.OleDb;
using System.Data.Odbc;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading;
using System.Drawing.Imaging;
using System.Collections;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace TESTENET.Funcoes
{
    public class Validacoes
    {
    
        
        protected static string nomeUsuario;
        protected static string nomeComputador;
        protected static string Codigotxt;
        protected static string Descricaotxt;
        protected static string Tabela;
        protected static string Join;
        protected static string valortxt;
        protected static string Mes1;
        protected static string Mes2;
        protected static string Mes3;
        protected static string Mes4;
        protected static string Mes5;
        protected static string Mes6;
        protected static string Mes7;
        protected static string Mes8;
        protected static string Mes9;
        protected static string Mes10;
        protected static string Mes11;
        protected static string Mes12;

        protected static string Meta1;
        protected static string Meta2;
        protected static string Meta3;
        protected static string Meta4;
        protected static string Meta5;
        protected static string Meta6;
        protected static string Meta7;
        protected static string Meta8;
        protected static string Meta9;
        protected static string Meta10;
        protected static string Meta11;
        protected static string Meta12;

        protected static string CodigoFormula1;
        protected static string CodigoFormula2;
        protected static string CodigoFormula3;
        protected static string CodigoFormula4;
        protected static string CodigoFormula5;
        protected static string CodigoFormula6;
        protected static string CodigoFormula7;
        protected static string CodigoFormula8;
        protected static string CodigoFormula9;
        protected static string CodigoFormula10;
        protected static string CodigoFormula11;
        protected static string CodigoFormula12;

        protected static string ValorMeta1;
        protected static string ValorMeta2;
        protected static string ValorMeta3;
        protected static string ValorMeta4;
        protected static string ValorMeta5;
        protected static string ValorMeta6;
        protected static string ValorMeta7;
        protected static string ValorMeta8;
        protected static string ValorMeta9;
        protected static string ValorMeta10;
        protected static string ValorMeta11;
        protected static string ValorMeta12;

        protected static string Perfil;
        protected static string NomePerfil;
        protected static string CaminhoArquivo;
        protected static string LinguagemPadrao;
        protected static string TipoBanco;
        protected static string CaminhoDados;
        protected static string NomeBanco;

        protected static string NomeBalanca;
        protected static string NumeroBalanca;
        protected static SerialPort PortaSerial;
        protected static Boolean VerificaCaractere;
        protected static string ValorCodigoPesquisa;
        protected static string ValorDescricaoPesquisa;
        protected static int ValorNrsCameras;
        protected static string ValorDescricaoCamera1;
        protected static string ValorDescricaoCamera2;
        protected static string ValorDescricaoCamera3;
        protected static string ValorPerfilAlterPesagem;
        protected static string ValorUsuarioAlterPesagem;
        protected static string NomePontoControle;
        protected static string CodigoPontoControle;
        protected static string OrdemPontoControle;
        protected static string ValorTag;
        protected static string ValorPlaca;
        protected static string ValorTipoMov;
        protected static string ValorTicket;
        protected static string UsuarioConexao;
        protected static string SenhaConexao;
        protected static string ConnStr;
        protected static string nomeServidor;
        protected static string nomeBancoDados;
        protected static string mensagemAviso;
        protected static bool gravadoRegistro;
        protected static Form formularioAtivo;
        protected static String valorPesoBalanca;
        protected static String valorCorLabelBalanca;
        protected static Form formularioAtivo2;
        protected static Form formularioAtivo3;
        protected static Image imagemFotoCelulaA;
        protected static Image imagemFotoCelulaB;
        protected static bool fotoCelularLadoBAberta;
        protected static String sentidoBalanca;
        protected static String iDBalanca;
        protected static String iDBalanca1;
        protected static bool pesquisaTransportadora;
        protected static String codigoTransportador;
        protected static String descricaoTransportador;
        protected static bool pesquisaCliente;
        protected static String codigoCliente;
        protected static String descricaoCliente;
        protected static bool pesquisaProduto;
        protected static String codigoProduto;
        protected static String descricaoProduto;
        protected static String continuaPesagem;
        protected static String posicaoTop;
        protected static String posicaoLeft;
        protected static bool pesquisaPesagem;
        protected static String codigoPesagem;
        protected static String tipoPesquisa;
        protected static String tipoRelatorio;
        protected static String tipoComnunicacao;
        protected static String valorEnderecoIP;
        protected static int valorPorta;
        protected static Boolean VerificaCaractereNumerico;
        protected static ArrayList arr1;
        protected static int tempoEntreLeituras;
        protected static string tipoOperacaoPesagem;
        protected static string continuaGravacaoPesagem;
        protected static string empresaCadastrada;
        protected static string cnpjEmpresaCadastrada;
        protected static string enderecoEmpresaCadastrada;
        protected static string comSBR;
        protected static string tipoOperacaoPesagem1;
        protected static Boolean carregaouTelaBalanca;
        protected static String fotoCelulaPosicaoAAtiva;
        protected static String fotoCelulaPosicaoBAtiva;
        protected static String semafaroAAtivo;
        protected static String semafaroBAtivo;
        protected static String fotoCelulaAproximacaoAAtiva;
        protected static String fotoCelulaAproximacaoBAtiva;
        protected static String tipoDispositivo;
        protected static String ipCA;
        protected static String portaCa;
        protected static String ipBalanca;
        protected static String portaBalanca;
        protected static String tipoComuinicacaoCA;
        protected static String tipoComuinicacaoBalanca;
        protected static Boolean carregaouFormularioBalanca;
        protected static String tipoPesagem;



        protected static ListView lista;
        public static ListView Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        protected static String comboEmissora;
        public static String ComboEmissora
        {
            get { return comboEmissora; }
            set { comboEmissora = value; }
        }


        protected static String comboCentroCusto;
        public static String ComboCentroCusto
        {
            get { return comboCentroCusto; }
            set { comboCentroCusto = value; }
        }

        protected static String comboFormaPagto;
        public static String ComboFormaPagto
        {
            get { return comboFormaPagto; }
            set { comboFormaPagto = value; }
        }

        protected static String tipoReceitaDespesa;
        public static String TipoReceitaDespesa
        {
            get { return tipoReceitaDespesa; }
            set { tipoReceitaDespesa = value; }
        }

        protected static String grupRel;
        public static String GrupRel
        {
            get { return grupRel; }
            set { grupRel = value; }
        }

        protected static int tipoRel;
        public static int TipoRel
        {
            get { return tipoRel; }
            set { tipoRel = value; }
        }

        protected static String filtroRel;
        public static String FiltroRel
        {
            get { return filtroRel; }
            set { filtroRel = value; }
        }



        protected static DateTime dataPesquisaIni;
        public static DateTime DataPesquisaIni
        {
            get { return dataPesquisaIni; }
            set { dataPesquisaIni = value; }
        }

        protected static DateTime dataPesquisaFim;
        public static DateTime DataPesquisaFim
        {
            get { return dataPesquisaFim; }
            set { dataPesquisaFim = value; }
        }


        protected static String preAgendamento;
        public static String PreAgendamento
        {
            get { return preAgendamento; }
            set { preAgendamento = value; }
        }
        
        protected static String codigoDiasPosTara;
        public static String CodigoDiasPosTara
        {
            get { return codigoDiasPosTara; }
            set { codigoDiasPosTara = value; }
        }
        
        protected static String descricaoDiasPosTara;
        public static String DescricaoDiasPosTara
        {
            get { return descricaoDiasPosTara; }
            set { descricaoDiasPosTara = value; }
        }
        
        protected static String codigoConfTara;
        public static String CodigoConfTara
        {
            get { return codigoConfTara; }
            set { codigoConfTara = value; }
        }


        protected static Boolean pesquisaDiasAvisoTara;
        public static Boolean PesquisaDiasAvisoTara
        {
            get { return pesquisaDiasAvisoTara; }
            set { pesquisaDiasAvisoTara = value; }
        }
        
        protected static string usaCA;
        public static string UsaCa
        {
            get { return usaCA; }
            set { usaCA = value; }
        }

        protected static string descTurno;
        public static string DescTurno
        {
            get { return descTurno; }
            set { descTurno = value; }
        }

        protected static string formatoData;
        public static string FormatoData
        {
            get { return formatoData; }
            set { formatoData = value; }
        }

        protected static string pesoMinimo;
        public static string PesoMinimo
        {
            get { return pesoMinimo; }
            set { pesoMinimo = value; }
        }

        
        protected static string Id_clienteCustomizado;
        public static string Id_ClienteCustomizado
        {
            get { return Id_clienteCustomizado; }
            set { Id_clienteCustomizado = value; }
        }

        protected static double somaPesoLista;
        public static double SomaPesoLista
        {
            get { return somaPesoLista; }
            set { somaPesoLista = value; }
        }

        protected static Boolean usandoFormularioBalanca;
        public static Boolean UsandoFormularioBalanca
        {
            get { return usandoFormularioBalanca; }
            set { usandoFormularioBalanca = value; }
        }


        protected static String idPontoControle;
        public static string IdPontoControle
        {
            get { return idPontoControle; }
            set { idPontoControle = value; }
        }

        protected static String usaPontoControle;
        public static string UsaPontoControle
        {
            get { return usaPontoControle; }
            set { usaPontoControle = value; }
        }
        
        
        protected static int codigoEmpresaGeral;
        public static int CodigoEmpresaGeral
        {
            get { return codigoEmpresaGeral; }
            set { codigoEmpresaGeral = value; }
        }

        protected static String nomeEmpresaGeral;
        public static string NomeEmpresaGeral
        {
            get { return nomeEmpresaGeral; }
            set { nomeEmpresaGeral = value; }
        }

        protected static String enderecoEmpresaGeral;
        public static string EnderecoEmpresaGeral
        {
            get { return enderecoEmpresaGeral; }
            set { enderecoEmpresaGeral = value; }
        }

        protected static String cidadeEmpresaGeral;
        public static string CidadeEmpresaGeral
        {
            get { return cidadeEmpresaGeral; }
            set { cidadeEmpresaGeral = value; }
        }

        protected static String emailEmpresaGeral;
        public static string EmailEmpresaGeral
        {
            get { return emailEmpresaGeral; }
            set { emailEmpresaGeral = value; }
        }


        protected static String exigeFoto;
        public static string ExigeFoto
        {
            get { return exigeFoto; }
            set { exigeFoto = value; }
        }
        
        protected static String fotoMedicoEmpresaGeral;
        public static string FotoMedicoEmpresaGeral
        {
            get { return fotoMedicoEmpresaGeral; }
            set { fotoMedicoEmpresaGeral = value; }
        }

        protected static String fotoPecienteEmpresaGeral;
        public static string FotoPacienteEmpresaGeral
        {
            get { return fotoPecienteEmpresaGeral; }
            set { fotoPecienteEmpresaGeral = value; }
        }

        protected static String ufEmpresaGeral;
        public static string UfEmpresaGeral
        {
            get { return ufEmpresaGeral; }
            set { ufEmpresaGeral = value; }
        }

        
        public static String TipoPesagem
        {
            get { return tipoPesagem; }
            set { tipoPesagem = value; }
        }

        protected static int numeroBanco;
        public static int NumeroBanco
        {
            get { return numeroBanco; }
            set { numeroBanco = value; }
        }

        protected static String mensagemdeErro;
        public static String MensagemdeErro
        {
            get { return mensagemdeErro; }
            set { mensagemdeErro = value; }
        }
        
        protected static SerialPort serialPorta;
        public static SerialPort SerialPorta
        {
            get { return serialPorta; }
            set { serialPorta = value; }
        }


        public static Boolean eixoCarregado;
        public static Boolean EixoCarregado
        {
            get { return eixoCarregado; }
            set { eixoCarregado = value; }
        }
        
        public static Boolean carregaModal;
        public static Boolean CarregaModal
        {
            get { return carregaModal; }
            set { carregaModal = value; }
        }

        protected static String valorCodMovimentacaoAnt;
        public static string ValorCodMovimentacaoAnt
        {
            get { return valorCodMovimentacaoAnt; }
            set { valorCodMovimentacaoAnt = value; }
        }

        protected static String valorDescMovimentacaoAnt;
        public static string ValorDescMovimentacaoAnt
        {
            get { return valorDescMovimentacaoAnt; }
            set { valorDescMovimentacaoAnt = value; }
        }

        public static Boolean CarregaouFormularioBalanca
        {
            get { return carregaouFormularioBalanca; }
            set { carregaouFormularioBalanca = value; }
        }


        public static String TipoComuinicacaoBalanca
        {
            get { return tipoComuinicacaoBalanca; }
            set { tipoComuinicacaoBalanca = value; }
        }

        public static String TipoComuinicacaoCA
        {
            get { return tipoComuinicacaoCA; }
            set { tipoComuinicacaoCA = value; }
        }

        public static String PortaBalanca
        {
            get { return portaBalanca; }
            set { portaBalanca = value; }
        }
        
        public static String IpBalanca
        {
            get { return ipBalanca; }
            set { ipBalanca = value; }
        }

        public static String PortaCa
        {
            get { return portaCa; }
            set { portaCa = value; }
        }

        public static String IpCa
        {
            get { return ipCA; }
            set { ipCA = value; }
        }


        public static String TipoDispositivo
        {
            get { return tipoDispositivo; }
            set { tipoDispositivo = value; }
        }



        public static String FotoCelulaAproximacaoBAtiva
        {
            get { return fotoCelulaAproximacaoBAtiva; }
            set { fotoCelulaAproximacaoBAtiva = value; }
        }

        public static String FotoCelulaAproximacaoAAtiva
        {
            get { return fotoCelulaAproximacaoAAtiva; }
            set { fotoCelulaAproximacaoAAtiva = value; }
        }

        public static String SemafaroBAtivo
        {
            get { return semafaroBAtivo; }
            set { semafaroBAtivo = value; }
        }

        public static String SemafaroAAtivo
        {
            get { return semafaroAAtivo; }
            set { semafaroAAtivo = value; }
        }
        public static String FotoCelulaPosicaoBAtiva
        {
            get { return fotoCelulaPosicaoBAtiva; }
            set { fotoCelulaPosicaoBAtiva = value; }
        }
        public static String FotoCelulaPosicaoAAtiva
        {
            get { return fotoCelulaPosicaoAAtiva; }
            set { fotoCelulaPosicaoAAtiva = value; }
        }
        public static Boolean CarregaouTelaBalanca
        {
            get { return carregaouTelaBalanca; }
            set { carregaouTelaBalanca = value; }
        }

        public static String TipoOperacaoPesagem1
        {
            get { return tipoOperacaoPesagem1; }
            set { tipoOperacaoPesagem1 = value; }
        }

        protected static string habiltaBotoesPesagens;
        public static string HabiltaBotoesPesagens
        {
            get { return habiltaBotoesPesagens; }
            set { habiltaBotoesPesagens = value; }
        }
        public static string ComSBR
        {
            get { return comSBR; }
            set { comSBR = value; }
        }
        
        protected static string comCSCF;
        public static string ComCSCF
        {
            get { return comCSCF; }
            set { comCSCF = value; }
        }


        protected static SerialPort serial;

        public static SerialPort Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        protected static string agendamento;

        public static string Agendamento
        {
            get { return agendamento; }
            set { agendamento = value; }
        }

        protected static string webservice;
        public static string Webservice
        {
            get { return webservice; }
            set { webservice = value; }
        }


        protected static string codigoBalancaTicket;
        public static string CodigoBalancaTicket
        {
            get { return codigoBalancaTicket; }
            set { codigoBalancaTicket = value; }
        }
        protected static string descricaoBalancaTicket;
        public static string DescricaoBalancaTicket
        {
            get { return descricaoBalancaTicket; }
            set { descricaoBalancaTicket = value; }
        }



        protected static string codigoMina;
        public static string CodigoMina
        {
            get { return codigoMina; }
            set { codigoMina = value; }
        }

        protected static string descricaoMina;
        public static string DescricaoMina
        {
            get { return descricaoMina; }
            set { descricaoMina = value; }
        }



        protected static string dispositivoAcessorioBal1;
        public static string DispositivoAcessorioBal1
        {
            get { return dispositivoAcessorioBal1; }
            set { dispositivoAcessorioBal1 = value; }
        }

        protected static bool pesquisaEixo;
        public static bool PesquisaEixo
        {
            get { return pesquisaEixo; }
            set { pesquisaEixo = value; }
        }



        protected static bool pesquisaMina;
        public static bool PesquisaMina
        {
            get { return pesquisaMina; }
            set { pesquisaMina = value; }
        }
        protected static bool pesquisaBalancaTicket;
        public static bool PesquisaBalancaTicket
        {
            get { return pesquisaBalancaTicket; }
            set { pesquisaBalancaTicket = value; }
        }

        protected static bool pesquisaMotorista;
        public static bool PesquisaMotorista
        {
            get { return pesquisaMotorista; }
            set { pesquisaMotorista = value; }
        }



        public static string EnderecoEmpresaCadastrada
        {
            get { return enderecoEmpresaCadastrada; }
            set { enderecoEmpresaCadastrada = value; }
        }

        public static string CnpjEmpresaCadastrada
        {
            get { return cnpjEmpresaCadastrada; }
            set { cnpjEmpresaCadastrada = value; }
        }

        public static string EmpresaCadastrada
        {
            get { return empresaCadastrada; }
            set { empresaCadastrada = value; }
        }

        public static string ContinuaGravacaoPesagem
        {
            get { return continuaGravacaoPesagem; }
            set { continuaGravacaoPesagem = value; }
        }
       
        protected static string painel;
        public static string Painel
        {
            get { return painel; }
            set { painel = value; }
        }



        protected static string caixadeTexto;
        public static string CaixadeTexto
        {
            get { return caixadeTexto; }
            set { caixadeTexto = value; }
        }

        protected static string botaoEixo;
        public static string BotaoEixo
        {
            get { return botaoEixo; }
            set { botaoEixo = value; }
        }
        
        protected static string valorPesoEntrada;

        public static String ValorPesoEntrada
        {
            get { return valorPesoEntrada; }
            set { valorPesoEntrada = value; }
        }

        public static String TipoOperacaoPesagem
        {
            get { return tipoOperacaoPesagem; }
            set { tipoOperacaoPesagem = value; }
        }

        protected static int nrEixos;
        public static int NrEixos
        {
            get { return nrEixos; }
            set { nrEixos = value; }
        }


        protected static string codigoVeiculo;
        public static String CodigoVeiculo
        {
            get { return codigoVeiculo; }
            set { codigoVeiculo = value; }
        }

        protected static string nomeVeiculo;
        public static String NomeVeiculo
        {
            get { return nomeVeiculo; }
            set { nomeVeiculo = value; }
        }
        protected static string tipoDispositivoComunicacao;
        public static String TipoDispositivoComunicacao
        {
            get { return tipoDispositivoComunicacao; }
            set { tipoDispositivoComunicacao = value; }
        }

        protected static string cnpjEmpresa;
        public static string CnpjEmpresa
        {
            get { return cnpjEmpresa; }
            set { cnpjEmpresa = value; }
        }


        protected static string codigoPesqBalanca;
        public static string CodigoPesqBalanca
        {
            get { return codigoPesqBalanca; }
            set { codigoPesqBalanca = value; }
        }

        protected static string codigoPesqBalancaTicket;
        public static string CodigoPesqBalancaTicket
        {
            get { return codigoPesqBalancaTicket; }
            set { codigoPesqBalancaTicket = value; }
        }

        protected static string descricaoPesqBalanca;
        public static string DescricaoPesqBalanca
        {
            get { return descricaoPesqBalanca; }
            set { descricaoPesqBalanca = value; }
        }

        protected static string codigoBalanca;
        public static string CodigoBalanca
        {
            get { return codigoBalanca; }
            set { codigoBalanca = value; }
        }

        protected static Boolean pesquisaBalanca;
        public static Boolean PesquisaBalanca
        {
            get { return pesquisaBalanca; }
            set { pesquisaBalanca = value; }
        }

        protected static Boolean pesquisaOrigem;
        public static Boolean PesquisaOrigem
        {
            get { return pesquisaOrigem; }
            set { pesquisaOrigem = value; }
        }

        protected static Boolean pesquisaDestino;
        public static Boolean PesquisaDestino
        {
            get { return pesquisaDestino; }
            set { pesquisaDestino = value; }
        }

        protected static String codigoMotorista;
        public static String CodigoMotorista
        {
            get { return codigoMotorista; }
            set { codigoMotorista = value; }
        }

        protected static String descricaoMotorista;
        public static String DescricaoMotorista
        {
            get { return descricaoMotorista; }
            set { descricaoMotorista = value; }
        }



        protected static String codigoOrigem;
        public static String CodigoOrigem
        {
            get { return codigoOrigem; }
            set { codigoOrigem = value; }
        }

        protected static String descricaoOrigem;
        public static String DescricaoOrigem
        {
            get { return descricaoOrigem; }
            set { descricaoOrigem = value; }
        }

        protected static String codigoDestino;
        public static String CodigoDestino
        {
            get { return codigoDestino; }
            set { codigoDestino = value; }
        }

        protected static String descricaoDestino;
        public static String DescricaoDestino
        {
            get { return descricaoDestino; }
            set { descricaoDestino = value; }
        }


        protected static String codigoMovimentacao;
        public static String CodigoMovimentacao
        {
            get { return codigoMovimentacao; }
            set { codigoMovimentacao = value; }
        }

        protected static String descricaoMovimentacao;
        public static String DescricaoMovimentacao
        {
            get { return descricaoMovimentacao; }
            set { descricaoMovimentacao = value; }
        }

        protected static String pontoApoio;
        public static String PontoApoio
        {
            get { return pontoApoio; }
            set { pontoApoio = value; }
        }

        protected static Boolean pesquisaMedico;
        public static Boolean PesquisaMedico
        {
            get { return pesquisaMedico; }
            set { pesquisaMedico = value; }
        }


        protected static String numeroMina;
        public static String NumeroMina
        {
            get { return numeroMina; }
            set { numeroMina = value; }
        }

        protected static Boolean pesquisaMovimentacao;
        public static Boolean PesquisaMovimentacao
        {
            get { return pesquisaMovimentacao; }
            set { pesquisaMovimentacao = value; }
        }

        public static Double SomaContaCorrente;
        public static Double somaContaCorrente
        {
            get { return SomaContaCorrente; }
            set { SomaContaCorrente = value; }
        }

        public static Double SomaAdiantamento;
        public static Double somaAdiantamento
        {
            get { return SomaAdiantamento; }
            set { SomaAdiantamento = value; }
        }

        public static String Cnpj_Cliente;
        public static String cnpj_Cliente
        {
            get { return Cnpj_Cliente; }
            set { Cnpj_Cliente = value; }
        }
        public static String CodigoConvenio;
        public static String codigoConvenio
        {
            get { return codigoConvenio; }
            set { codigoConvenio = value; }
        }
        public static String NomeConvenio;
        public static String nomeConvenio
        {
            get { return nomeConvenio; }
            set { nomeConvenio = value; }
        }


        public static String CodigoPaciente;
        public static String codigoPaciente
        {
            get { return codigoPaciente; }
            set { codigoPaciente = value; }
        }
        public static String NomePaciente;
        public static String nomePaciente
        {
            get { return nomePaciente; }
            set { nomePaciente = value; }
        }


        public static String CodigoMedico;
        public static String codigoMedico
        {
            get { return codigoMedico; }
            set { codigoMedico = value; }
        }

        public static String NomeMedico;
        public static String nomeMedico
        {
            get { return nomeMedico; }
            set { nomeMedico = value; }
        }




        public static String Registro_Tabela_Sap;
        public static String registro_Tabela_Sap
        {
            get { return Registro_Tabela_Sap; }
            set { Registro_Tabela_Sap = value; }
        }
        public static Boolean Pesquisa_Convenio;
        public static Boolean pesquisa_Convenio
        {
            get { return Pesquisa_Convenio; }
            set { Pesquisa_Convenio = value; }
        }

        public static string Id_Paciente;
        public static string id_Paciente
        {
            get { return Id_Paciente; }
            set { Id_Paciente = value; }
        }

       


        public static string Id_Prontuario;
        public static string id_Prontuario
        {
            get { return Id_Prontuario; }
            set { Id_Prontuario = value; }
        }
        public static string Id_Agenda;
        public static string id_Agenda
        {
            get { return Id_Agenda; }
            set { Id_Agenda = value; }
        }


        /* Setando Varivaies de controle para pegar valores convenios */
        public static Boolean Pesquisa_Convenio_Agenda;
        public static Boolean pesquisa_Convenio_Agenda
        {
            get { return Pesquisa_Convenio_Agenda; }
            set { Pesquisa_Convenio_Agenda = value; }
        }

        public static int TempoEntreLeituras
        {
            get { return tempoEntreLeituras; }
            set { tempoEntreLeituras = value; }
        }

        public static ArrayList Arr1
        {
            get { return arr1; }
            set { arr1 = value; }
        }

        public static Boolean verificacaractereNumerico
        {
            get { return VerificaCaractereNumerico; }
            set { VerificaCaractereNumerico = value; }
        }

        public static int ValorPorta
        {
            get { return valorPorta; }
            set { valorPorta = value; }
        }
        public static String ValorEnderecoIP
        {
            get { return valorEnderecoIP; }
            set { valorEnderecoIP = value; }
        }
        public static String TipoComnunicacao
        {
            get { return tipoComnunicacao; }
            set { tipoComnunicacao = value; }
        }

        public static String TipoRelatorio
        {
            get { return tipoRelatorio; }
            set { tipoRelatorio = value; }
        }

        public static String TipoPesquisa
        {
            get { return tipoPesquisa; }
            set { tipoPesquisa = value; }
        }

        public static String CodigoPesagem
        {
            get { return codigoPesagem; }
            set { codigoPesagem = value; }
        }
        public static bool PesquisaPesagem
        {
            get { return pesquisaPesagem; }
            set { pesquisaPesagem = value; }
        }
        
        public static String PosicaoLeft
        {
            get { return posicaoLeft; }
            set { posicaoLeft= value; }
        }

        public static String PosicaoTop
        {
            get { return posicaoTop; }
            set { posicaoTop = value; }
        }

        public static String ContinuaPesagem
        {
            get { return continuaPesagem; }
            set { continuaPesagem = value; }
        }


        public static String DescricaoProduto
        {
            get { return descricaoProduto; }
            set { descricaoProduto = value; }
        }

        public static String CodigoProduto
        {
            get { return codigoProduto; }
            set { codigoProduto = value; }
        }
        public static bool PesquisaProduto
        {
            get { return pesquisaProduto; }
            set { pesquisaProduto = value; }
        }

        public static String DescricaoClientee
        {
            get { return descricaoCliente; }
            set { descricaoCliente = value; }
        }

        public static String CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

        public static bool PesquisaCliente
        {
            get { return pesquisaCliente; }
            set { pesquisaCliente = value; }
        }

      
        public static String CodigoTransportador
        {
            get { return codigoTransportador; }
            set { codigoTransportador = value; }
        }
        public static String DescricaoTransportador
        {
            get { return descricaoTransportador; }
            set { descricaoTransportador = value; }
        }
        
        public static bool PesquisaTransportadora
        {
            get { return pesquisaTransportadora; }
            set { pesquisaTransportadora = value; }
        }
        public static String IdBalanca
        {
            get { return iDBalanca; }
            set { iDBalanca = value; }
        }

        public static String IdBalanca1
        {
            get { return iDBalanca1; }
            set { iDBalanca1 = value; }
        }


        public static String SentidoBalanca
        {
            get { return sentidoBalanca; }
            set { sentidoBalanca = value; }
        }
        

        public static bool FotoCelularLadoBAberta
        {
            get { return fotoCelularLadoBAberta; }
            set { fotoCelularLadoBAberta = value; }
        }
        
        protected static bool fotoCelularLadoAAberta;

        public static bool FotoCelularLadoAAberta
        {
            get { return fotoCelularLadoAAberta; }
            set { fotoCelularLadoAAberta = value; }
        }

        protected static string tipoImpressao;

        public static string TipoImpressao
        {
            get { return tipoImpressao; }
            set { tipoImpressao = value; }
        }

        public static Image ImagemFotoCelulaB
        {
            get { return imagemFotoCelulaB; }
            set { imagemFotoCelulaB= value; }
        }
        public static Image ImagemFotoCelulaA
        {
            get { return imagemFotoCelulaA; }
            set { imagemFotoCelulaA = value; }
        }

        public static Form FormularioAtivo3
        {
            get { return formularioAtivo3; }
            set { formularioAtivo3 = value; }
        }
        
        public static Form FormularioAtivo2
        {
            get { return formularioAtivo2; }
            set { formularioAtivo2 = value; }
        }
        
        public static String ValorCorLabelBalanca
        {
            get { return valorCorLabelBalanca; }
            set { valorCorLabelBalanca = value; }
        }

        public static String ValorPesoBalanca
        {
            get { return valorPesoBalanca; }
            set { valorPesoBalanca = value; }
        }

        public static Form FormularioAtivo
        {
            get { return formularioAtivo; }
            set { formularioAtivo = value; }
        }


        public static bool GravadoRegistro
        {
            get { return gravadoRegistro; }
            set { gravadoRegistro = value; }
        }



        public static string MensagemAviso
        {
            get { return mensagemAviso; }
            set { mensagemAviso = value; }
        }
        
        public static string NomeBancoDados
        {
            get { return nomeBancoDados; }
            set { nomeBancoDados = value; }
        }


        public static string NomeServidor
        {
            get { return nomeServidor; }
            set { nomeServidor = value; }
        }

        public static string connStr
        {
            get { return ConnStr; }
            set { ConnStr = value; }
        }

        public static string senhaConexao
        {
            get { return SenhaConexao; }
            set { SenhaConexao = value; }
        }

        public static string usuarioConexao
        {
            get { return UsuarioConexao; }
            set { UsuarioConexao = value; }
        }

        public static string nomeBanco
        {
            get { return NomeBanco; }
            set { NomeBanco = value; }
        }
        public static string valorTicket
        {
            get { return ValorTicket; }
            set { ValorTicket = value; }
        }

        public static string valorTipoMov
        {
            get { return ValorTipoMov; }
            set { ValorTipoMov = value; }
        }

        public static string valorPlaca
        {
            get { return ValorPlaca; }
            set { ValorPlaca = value; }
        }

        public static string valorTag
        {
            get { return ValorTag; }
            set { ValorTag = value; }
        }

        public static string ordemPontoControle
        {
            get { return OrdemPontoControle; }
            set { OrdemPontoControle = value; }
        }


        public static string codigoPontoControle
        {
            get { return CodigoPontoControle; }
            set { CodigoPontoControle = value; }
        }

        public static string nomePontoControle
        {
            get { return NomePontoControle; }
            set { NomePontoControle = value; }
        }

        public static string valorUsuarioAlterPesagem
        {
            get { return ValorUsuarioAlterPesagem; }
            set { ValorUsuarioAlterPesagem = value; }
        }

        public static string valorPerfilAlterPesagem
        {
            get { return ValorPerfilAlterPesagem; }
            set { ValorPerfilAlterPesagem = value; }
        }

        public static string valorDescricaoCamera1
        {
            get { return ValorDescricaoCamera1; }
            set { ValorDescricaoCamera1 = value; }
        }
        public static string valorDescricaoCamera2
        {
            get { return ValorDescricaoCamera2; }
            set { ValorDescricaoCamera2 = value; }
        }
        public static string valorDescricaoCamera3
        {
            get { return ValorDescricaoCamera3; }
            set { ValorDescricaoCamera3 = value; }
        }
        public static int valorNrscameras
        {
            get { return ValorNrsCameras; }
            set { ValorNrsCameras = value; }
        }


        public static string valordescricaopesquisa
        {
            get { return ValorDescricaoPesquisa; }
            set { ValorDescricaoPesquisa = value; }
        }

        public static string valorcodigopesquisa
        {
            get { return ValorCodigoPesquisa; }
            set { ValorCodigoPesquisa = value; }
        }

        public static Boolean verificacaractere
        {
            get { return VerificaCaractere; }
            set { VerificaCaractere = value; }
        }

        public static SerialPort portaserial
        {
            get { return PortaSerial; }
            set { PortaSerial = value; }
        }

        public static string numerobalanca
        {
            get { return NumeroBalanca; }
            set { NumeroBalanca = value; }
        }

        public static string nomebalanca
        {
            get { return NomeBalanca; }
            set { NomeBalanca = value; }
        }


        public static string caminhodados
        {
            get { return CaminhoDados; }
            set { CaminhoDados = value; }
        }

        public static string tipobanco
        {
            get { return TipoBanco; }
            set { TipoBanco = value; }
        }

        public static string linguagempadrao
        {
            get { return LinguagemPadrao; }
            set { LinguagemPadrao = value; }
        }


        public static string caminhoarquivo
        {
            get { return CaminhoArquivo; }
            set { CaminhoArquivo = value; }
        }

        public static string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        public static string NomeComputador
        {
            get { return nomeComputador; }
            set { nomeComputador = value; }
        }
        public static string CodigoTextBox
        {
            get { return Codigotxt; }
            set { Codigotxt = value; }
        }
        public static string DescricaoTextBox
        {
            get { return Descricaotxt; }
            set { Descricaotxt = value; }
        }
        public static string TABELAFORM
        {
            get { return Tabela; }
            set { Tabela = value; }
        }
        public static string ValorTextBox
        {
            get { return valortxt; }
            set { valortxt = value; }
        }
        public static string JOIN
        {
            get { return Join; }
            set { Join = value; }
        }
        public static string MesJaneiro
        {
            get { return Mes1; }
            set { Mes1 = value; }
        }
        public static string MesFevereiro
        {
            get { return Mes2; }
            set { Mes2 = value; }
        }
        public static string MesMarco
        {
            get { return Mes3; }
            set { Mes3 = value; }
        }
        public static string MesAbril
        {
            get { return Mes4; }
            set { Mes4 = value; }
        }
        public static string MesMaio
        {
            get { return Mes5; }
            set { Mes5 = value; }
        }
        public static string MesJunho
        {
            get { return Mes6; }
            set { Mes6 = value; }
        }
        public static string MesJulho
        {
            get { return Mes7; }
            set { Mes7 = value; }
        }
        public static string MesAgosto
        {
            get { return Mes8; }
            set { Mes8 = value; }
        }
        public static string MesSetembro
        {
            get { return Mes9; }
            set { Mes9 = value; }
        }
        public static string MesOutubro
        {
            get { return Mes10; }
            set { Mes10 = value; }
        }
        public static string MesNovembro
        {
            get { return Mes11; }
            set { Mes11 = value; }
        }
        public static string MesDezembro
        {
            get { return Mes12; }
            set { Mes12 = value; }
        }
        // --------------------------------------------------------//
        //  VARIAVEIS PARA GRAVAR O TIPO DE META
        // --------------------------------------------------------//
        public static string CodFormula1
        {
            get { return CodigoFormula1; }
            set { CodigoFormula1 = value; }
        }
        public static string CodFormula2
        {
            get { return CodigoFormula2; }
            set { CodigoFormula2 = value; }
        }
        public static string CodFormula3
        {
            get { return CodigoFormula3; }
            set { CodigoFormula3 = value; }
        }
        public static string CodFormula4
        {
            get { return CodigoFormula4; }
            set { CodigoFormula4 = value; }
        }
        public static string CodFormula5
        {
            get { return CodigoFormula5; }
            set { CodigoFormula5 = value; }
        }
        public static string CodFormula6
        {
            get { return CodigoFormula6; }
            set { CodigoFormula6 = value; }
        }
        public static string CodFormula7
        {
            get { return CodigoFormula7; }
            set { CodigoFormula7 = value; }
        }
        public static string CodFormula8
        {
            get { return CodigoFormula8; }
            set { CodigoFormula8 = value; }
        }
        public static string CodFormula9
        {
            get { return CodigoFormula9; }
            set { CodigoFormula9 = value; }
        }
        public static string CodFormula10
        {
            get { return CodigoFormula10; }
            set { CodigoFormula10 = value; }
        }
        public static string CodFormula11
        {
            get { return CodigoFormula11; }
            set { CodigoFormula11 = value; }
        }
        public static string CodFormula12
        {
            get { return CodigoFormula12; }
            set { CodigoFormula12 = value; }
        }
        // --------------------------------------------------------//
        //  VARIAVEIS PARA GRAVAR O TIPO DE FORMULA DA META
        // --------------------------------------------------------//
        public static string TipoMetaJaneiro
        {
            get { return Meta1; }
            set { Meta1 = value; }
        }
        public static string TipoMetaFevereiro
        {
            get { return Meta2; }
            set { Meta2 = value; }
        }
        public static string TipoMetaMarco
        {
            get { return Meta3; }
            set { Meta3 = value; }
        }
        public static string TipoMetaAbril
        {
            get { return Meta4; }
            set { Meta4 = value; }
        }
        public static string TipoMetaMaio
        {
            get { return Meta5; }
            set { Meta5 = value; }
        }
        public static string TipoMetaJunho
        {
            get { return Meta6; }
            set { Meta6 = value; }
        }
        public static string TipoMetaJulho
        {
            get { return Meta7; }
            set { Meta7 = value; }
        }
        public static string TipoMetaAgosto
        {
            get { return Meta8; }
            set { Meta8 = value; }
        }
        public static string TipoMetaSetembro
        {
            get { return Meta9; }
            set { Meta9 = value; }
        }
        public static string TipoMetaOutubro
        {
            get { return Meta10; }
            set { Meta10 = value; }
        }
        public static string TipoMetaNovembro
        {
            get { return Meta11; }
            set { Meta11 = value; }
        }
        public static string TipoMetaDezembro
        {
            get { return Meta12; }
            set { Meta12 = value; }
        }

        // --------------------------------------------------------//
        //  VARIAVEIS PARA GRAVAR O VALOR DE FORMULA DA META
        // --------------------------------------------------------//
        public static string ValorMetaJaneiro
        {
            get { return ValorMeta1; }
            set { ValorMeta1 = value; }
        }
        public static string ValorMetaFevereiro
        {
            get { return ValorMeta2; }
            set { ValorMeta2 = value; }
        }
        public static string ValorValorMarco
        {
            get { return ValorMeta3; }
            set { ValorMeta3 = value; }
        }
        public static string ValorMetaAbril
        {
            get { return ValorMeta4; }
            set { ValorMeta4 = value; }
        }
        public static string ValorMetaMaio
        {
            get { return ValorMeta5; }
            set { ValorMeta5 = value; }
        }
        public static string ValorMetaJunho
        {
            get { return ValorMeta6; }
            set { ValorMeta6 = value; }
        }
        public static string ValorMetaJulho
        {
            get { return ValorMeta7; }
            set { ValorMeta7 = value; }
        }
        public static string ValorMetaAgosto
        {
            get { return ValorMeta8; }
            set { ValorMeta8 = value; }
        }
        public static string ValorMetaSetembro
        {
            get { return Meta9; }
            set { ValorMeta9 = value; }
        }
        public static string ValorMetaOutubro
        {
            get { return ValorMeta10; }
            set { ValorMeta10 = value; }
        }
        public static string ValorMetaNovembro
        {
            get { return ValorMeta11; }
            set { ValorMeta11 = value; }
        }
        public static string ValorMetaDezembro
        {
            get { return ValorMeta12; }
            set { ValorMeta12 = value; }
        }

        //----------------------------------------------//
        //           PERFIL                             //
        //----------------------------------------------//
        public static string PerfilUsuario
        {
            get { return Perfil; }
            set { Perfil = value; }
        }
        public static string NomePerfilUsuario
        {
            get { return NomePerfil; }
            set { NomePerfil = value; }
        }



        public static string SoNumero(string pgNumero, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44
                && e.KeyChar != (char)127 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            return pgNumero;
        }
        public static string SoNumeroSemVirgula(string pgNumero, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            return pgNumero;
        }



        protected static string Sair;
        public static string SairSistema
        {
            get { return Sair; }
            set { Sair = value; }
        }

        public static bool Verifica_Placa(String Placa)
        {
            //Se a quantidade de dígitos do cep for igual a 8
            if (Placa.Length < 7)
            {
                DialogResult opcaoSelecionada;
                opcaoSelecionada = MessageBox.Show("Tamanho de digitado Menor que o padrão !                                         CONFIRMA (SIM) CANCELA (NAO)","ATENCAO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.No))
                {
                    return false;
                } 
             }
            return true;
        }

        public static string ValorDataAGravar()
        {
            string ValorDia = System.DateTime.Now.Day.ToString().PadLeft(2, '0');
            string ValorMes = System.DateTime.Now.Month.ToString().PadLeft(2, '0');
            string ValorAno = System.DateTime.Now.Year.ToString();
            string ValorHora = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
            string ValorMinuto = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
            string ValorSegundo = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
            string ValorMileSegundo = System.DateTime.Now.Millisecond.ToString().PadLeft(3, '0');
            string ValorDataHora = ValorDia.ToString() + "/" +
                               ValorMes.ToString() + "/" +
                               ValorAno.ToString() + " " +
                               ValorHora.ToString() + ":" +
                               ValorMinuto.ToString() + ":" +
                               ValorSegundo.ToString() + "." +
                               ValorMileSegundo.ToString();

            return ValorDataHora.ToString();

        }
        public static bool ValorDataValida(String Data)
        {
            DateTime resultado = DateTime.MinValue; //Retorna se a data é válida

            if (DateTime.TryParse(Data, out resultado)) //Testa a data em questão     
                return true; //Caso seja válida    
            return false;
        }
        
        public static void Mensagems(string mensagem,string Cabecario)
        {
            MessageBox.Show(mensagem,Cabecario);
        }

        public static string ConverteValorDataAGravar(DateTime ValorDataHoraRecebido)
        {
            
            string ValorDia = ValorDataHoraRecebido.Day.ToString().PadLeft(2, '0');
            string ValorMes = ValorDataHoraRecebido.Month.ToString().PadLeft(2, '0');
            string ValorAno = ValorDataHoraRecebido.Year.ToString();
            string ValorHora = ValorDataHoraRecebido.Hour.ToString().PadLeft(2, '0');
            string ValorMinuto = ValorDataHoraRecebido.Minute.ToString().PadLeft(2, '0');
            string ValorSegundo = ValorDataHoraRecebido.Second.ToString().PadLeft(2, '0');
            string ValorMileSegundo = ValorDataHoraRecebido.Millisecond.ToString().PadLeft(3, '0');
            string ValorDataHora = ValorDia.ToString() + "/" +
                               ValorMes.ToString() + "/" +
                               ValorAno.ToString() + " " +
                               ValorHora.ToString() + ":" +
                               ValorMinuto.ToString() + ":" +
                               ValorSegundo.ToString() + "." +
                               ValorMileSegundo.ToString();

            return ValorDataHora.ToString();

        }
        public static string ConverteValorDataAGravar1(DateTime ValorDataHoraRecebido)
        {

            string ValorDia = ValorDataHoraRecebido.Day.ToString().PadLeft(2, '0');
            string ValorMes = ValorDataHoraRecebido.Month.ToString().PadLeft(2, '0');
            string ValorAno = ValorDataHoraRecebido.Year.ToString();
            string ValorHora = ValorDataHoraRecebido.Hour.ToString().PadLeft(2, '0');
            string ValorMinuto = ValorDataHoraRecebido.Minute.ToString().PadLeft(2, '0');
            string ValorSegundo = ValorDataHoraRecebido.Second.ToString().PadLeft(2, '0');
            string ValorMileSegundo = ValorDataHoraRecebido.Millisecond.ToString().PadLeft(3, '0');
            string ValorDataHora = ValorMes.ToString() + "/" +
                               ValorDia.ToString() + "/" +
                               ValorAno.ToString() + " " +
                               ValorHora.ToString() + ":" +
                               ValorMinuto.ToString() + ":" +
                               ValorSegundo.ToString() + "." +
                               ValorMileSegundo.ToString();

            return ValorDataHora.ToString();

        }
        
        public static bool ValidaCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");
            if (valor.Length != 11)
                return false;
            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;
            if (igual || valor == "12345678909")
                return false;
            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                  valor[i].ToString());
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];
            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];
            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                    return false;
            return true;
        }
        public static bool ValidaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);   
        }

        public static bool VerificaControleAtivo(Form f, Control c)
        {   
            if (f != null)  
            {
                if (c.HasChildren == true)
                {
                    return true;
                }
            }    
            return false;
        }

        public static Boolean CleanInput(char strIn)
        {
         
            if (strIn == 48 || strIn == 49 || strIn == 50 ||
              strIn == 51 || strIn == 52 || strIn == 53 ||
               strIn == 54 || strIn == 55 || strIn == 56 ||
               strIn == 57 || strIn == 46 || strIn == 8)
            {
                return true;
            }
            return false;
        }
    
    
    }
    
    
}
