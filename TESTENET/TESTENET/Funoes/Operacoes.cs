using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Globalization;
using System.Net.Sockets;

namespace TESTENET.Funcoes
{
    class Operacoes
    {

       
        public static bool Gravalog(string OPERACAO, string TABELA, string USUARIO, string DADOANTES, string ESTACAO)
        {
            string sProc = "SPR_GRAVAOUALTERA_LOGS";
            using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
            {
                using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                {
                    oCn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.Add("@OPERACAO", SqlDbType.VarChar);
                    oCmd.Parameters["@OPERACAO"].Value = OPERACAO;

                    oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                    oCmd.Parameters["@TABELA"].Value = TABELA;



                    oCmd.Parameters.Add("@USUARIO", SqlDbType.VarChar);
                    oCmd.Parameters["@USUARIO"].Value = USUARIO;

                    oCmd.Parameters.Add("@ESTACAO", SqlDbType.VarChar);
                    oCmd.Parameters["@ESTACAO"].Value = ESTACAO;

                    oCmd.ExecuteNonQuery();
                }
            }
            return true;

        }
        public static bool GeraAgendaMedicaDiaria(int Id_Medico, DateTime PeriodoInicial, DateTime PeriodoFinal, int TempoConsulta)
        {



            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            DateTime Dta_inciial = PeriodoInicial;
            try
            {

                TimeSpan ts = PeriodoFinal - PeriodoInicial;
                int differenceInDays = ts.Days;
               
                /*
                * VERIFICANDO SE HÁ CADATRO DE HORARIOS PARA O MEDICO
                * FAZ UMA PESQUISA DE DIAS DAS SEMANA DE SEGUNDA A DOMINGO
                * PROMEIRO PELO TUUDO DA MANHÃ
                */
                /*
                 * HORARIO DA MANHÃ
                 */
                String Id_Manha;
                String Swhere;
                String H_Inicio_M ;
                String H_Fim_M ;
                DateTime H_Inicio = DateTime.Now;
                DateTime H_Fim = DateTime.Now;
                for (int i = 0; i < (differenceInDays) + 1; i++)
                {
                    /*
                     * Parâmetros de Datas
                     */
                    PeriodoInicial = Dta_inciial.AddDays(i);
                    DateTime DataSemana = new DateTime(PeriodoInicial.Year,
                                                PeriodoInicial.Month,
                                                PeriodoInicial.Day);
                    int ValorDiaSemana = ((int)DataSemana.DayOfWeek);


                    //*Fim*/

                   

                        Swhere = "ID_TURNO=1 AND ID_MEDICO=" + Id_Medico + " AND ID_DIASEMANA=" + ValorDiaSemana;
                        Id_Manha = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "ID_HORARIOMEDICO", Swhere.ToString(), "");
                        if (Id_Manha != "")
                        {
                            /*
                             * PERIODOS
                             */
                            H_Inicio_M = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "HORA_INICIO", Swhere.ToString(), ""); ;
                            H_Fim_M = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "HORA_FIM", Swhere.ToString(), "");
                            H_Inicio = Convert.ToDateTime(H_Inicio_M);
                            while (H_Inicio_M != H_Fim_M)
                            {
                                Swhere = "DIA='" + PeriodoInicial + "' AND HORA='" + H_Inicio.ToShortTimeString() + "' AND ID_MEDICO=" + Id_Medico + "";
                                string ExiteRegistroManha = Funcoes.Operacoes.CapturaCampoTabela(5, "AGENDA_HORARIOS", "DIA", Swhere.ToString(), "");
                                if (ExiteRegistroManha == "")
                                {
                                    string NomeCampos = @"ID_AGENDAHORARIOS," +
                                                    "ID_MEDICO," +
                                                    "DIA," +
                                                    "HORA";

                                    string ValuesCampos = @"," + Id_Medico + ",'" + PeriodoInicial + "','" + H_Inicio + "'";
                                    bool RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "AGENDA_HORARIOS", "ID_AGENDAHORARIOS", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");
                                }
                                H_Inicio = Convert.ToDateTime(H_Inicio_M).AddMinutes(TempoConsulta);
                                H_Inicio_M = H_Inicio.ToShortTimeString();
                            }
                        }
                        Swhere = "ID_TURNO=2 AND ID_MEDICO=" + Id_Medico + " AND ID_DIASEMANA=" + ValorDiaSemana;
                        Id_Manha = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "ID_HORARIOMEDICO", Swhere.ToString(), "");
                        if (Id_Manha != "")
                        {
                            /*
                             * PERIODOS
                             */
                            H_Inicio_M = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "HORA_INICIO", Swhere.ToString(), ""); ;
                            H_Fim_M = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "HORA_FIM", Swhere.ToString(), "");
                            H_Inicio = Convert.ToDateTime(H_Inicio_M);
                            while (H_Inicio_M != H_Fim_M)
                            {
                                Swhere = "DIA='" + PeriodoInicial + "' AND HORA='" + H_Inicio.ToShortTimeString() + "' AND ID_MEDICO=" + Id_Medico + "";
                                string ExiteRegistroManha = Funcoes.Operacoes.CapturaCampoTabela(5, "AGENDA_HORARIOS", "DIA", Swhere.ToString(), "");
                                if (ExiteRegistroManha == "")
                                {
                                    string NomeCampos = @"ID_AGENDAHORARIOS," +
                                                    "ID_MEDICO," +
                                                    "DIA," +
                                                    "HORA";

                                    string ValuesCampos = @"," + Id_Medico + ",'" + PeriodoInicial + "','" + H_Inicio + "'";
                                    bool RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "AGENDA_HORARIOS", "ID_AGENDAHORARIOS", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");
                                }
                                H_Inicio = Convert.ToDateTime(H_Inicio_M).AddMinutes(TempoConsulta);
                                H_Inicio_M = H_Inicio.ToShortTimeString();
                            }
                        }
                        Swhere = "ID_TURNO=3 AND ID_MEDICO=" + Id_Medico + " AND ID_DIASEMANA=" + ValorDiaSemana;
                        Id_Manha = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "ID_HORARIOMEDICO", Swhere.ToString(), "");
                        if (Id_Manha != "")
                        {
                            /*
                             * PERIODOS
                             */
                            H_Inicio_M = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "HORA_INICIO", Swhere.ToString(), ""); ;
                            H_Fim_M = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "HORA_FIM", Swhere.ToString(), "");
                            H_Inicio = Convert.ToDateTime(H_Inicio_M);
                            while (H_Inicio_M != H_Fim_M)
                            {
                                Swhere = "DIA='" + PeriodoInicial + "' AND HORA='" + H_Inicio.ToShortTimeString() + "' AND ID_MEDICO=" + Id_Medico + "";
                                string ExiteRegistroManha = Funcoes.Operacoes.CapturaCampoTabela(5, "AGENDA_HORARIOS", "DIA", Swhere.ToString(), "");
                                if (ExiteRegistroManha == "")
                                {
                                    string NomeCampos = @"ID_AGENDAHORARIOS," +
                                                    "ID_MEDICO," +
                                                    "DIA," +
                                                    "HORA";

                                    string ValuesCampos = @"," + Id_Medico + ",'" + PeriodoInicial + "','" + H_Inicio + "'";
                                    bool RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "AGENDA_HORARIOS", "ID_AGENDAHORARIOS", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");
                                }
                                H_Inicio = Convert.ToDateTime(H_Inicio_M).AddMinutes(TempoConsulta);
                                H_Inicio_M = H_Inicio.ToShortTimeString();
                            }
                        }
                    }
                
                MessageBox.Show("Agenda criada com sucesso ! ", "AVISO");
                return true;
            }
            catch (Exception erro)
            {
                var ERRO = erro;
                return false;
            }

        }

        public static bool GravaNovaFoto(int CODIGO, Image Imagem)
        {
            try
            {

                byte[] imagemDados = null;
                imagemDados = CarregarArquivoImagem();


                string sProc = "SPR_GRAVA_IMAGEM";
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@CODIGO", SqlDbType.Int);
                        oCmd.Parameters["@CODIGO"].Value = CODIGO;
                        oCmd.Parameters.Add("@IMAGEM", SqlDbType.Image, 1200000);
                        oCmd.Parameters["@IMAGEM"].Value = imagemDados;
                        SqlDataReader dr = oCmd.ExecuteReader();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().Contains("chave duplicada"))
                {
                    Funcoes.Validacoes.MensagemAviso = "Registro com o mesmo CGC ou CPF já existente na base de dados";
                    return false;
                }
                return false;
            }
        }
        public static byte[] CarregarArquivoImagem()
        {
            try
            {
                byte[] imagemBytes = null;
                string caminhoCompletoImagem = @"C:\Projetos\GPR-LINE\GPR-LINE\Imagens" + @"\" + "CaminhaoN3JD.BMP";
                FileStream fs = new FileStream(caminhoCompletoImagem, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imagemBytes = br.ReadBytes(1200000);
                return imagemBytes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static bool VerificaEixos(string ID)
        {
            string sProc = "SPR_AJUSTA_PESAGEM_EIXO";
            using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
            {
                using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                {
                    oCn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    oCmd.Parameters.Add("@ID", SqlDbType.Float);
                    oCmd.Parameters["@ID"].Value = ID;

                    oCmd.ExecuteNonQuery();
                }
            }
            return true;

        }


        public static string CapturaCampoTabela(int OPERACAO, string TABELA, string CAMPOSELECAO, string CAMPO, string CODIGO)
        {
            try
            {

                string sProc = "SPR_CAPTURA_CAMPO_TABELA";
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;

                        // OPERAÇÃO A SER EXECUDATA VERIFICAR REGITROS NA PROCEDURE    \\
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Float);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO.ToString();
                        // ------------------------------------------------------------\\
                        // TABELA A SER PESQUISADA                                     \\
                        oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                        oCmd.Parameters["@TABELA"].Value = TABELA.ToString();
                        // ------------------------------------------------------------\\
                        // CAMPO SELEÇÃO                                     \\
                        oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSELECAO.ToString();
                        // ------------------------------------------------------------\\
                        // CAMPO                                      \\
                        oCmd.Parameters.Add("@CAMPO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPO"].Value = CAMPO.ToString();
                        // ------------------------------------------------------------\\
                        // VALOR DA PESQUISA                                           \\
                        oCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar);
                        oCmd.Parameters["@CODIGO"].Value = CODIGO.ToString();
                        // ------------------------------------------------------------\\
                        //oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();
                        //inicia leitura do datareader
                        while (dr.Read())
                        {
                            return dr.GetValue(0).ToString();
                        }
                        return "";
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Atenção");
                return "";
            }
        }
        public static Control DesabilitaControle(Control controle)
        {
            controle.Enabled = false;

            return controle;
        }

        public static ArrayList CarregaCombo(int OPERACAO, string TABELA, string CAMPOSELECAO, String ORDEM)
        {
            try
            {
                ArrayList arr = new ArrayList();
                ImageList drop = new ImageList();
                string sProc = "SPR_CARREGA_COMBO";
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;

                        // OPERAÇÃO A SER EXECUDATA VERIFICAR REGITROS NA PROCEDURE    \\
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Float);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO.ToString();
                        // ------------------------------------------------------------\\
                        // TABELA A SER PESQUISADA                                     \\
                        oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                        oCmd.Parameters["@TABELA"].Value = TABELA.ToString();
                        // ------------------------------------------------------------\\
                        // CAMPO SELEÇÃO                                     \\
                        oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSELECAO.ToString();
                        // ------------------------------------------------------------\\
                        oCmd.Parameters.Add("@ORDEM", SqlDbType.VarChar);
                        oCmd.Parameters["@ORDEM"].Value = ORDEM.ToString();
                        // ------------------------------------------------------------\\
                        //oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();
                        //inicia leitura do datareader
                        //arr.Add(new drop("TODAS", Convert.ToInt64(0)));

                        while (dr.Read())
                        {
                            arr.Add(new drop(@dr.GetValue(1).ToString(), Convert.ToInt64(@dr.GetValue(0).ToString())));
                        }
                        return arr;
                    }
                }
            }
            catch (Exception erro)
            {
                ArrayList arr = new ArrayList();
                MessageBox.Show(erro.ToString(), "Atenção");
                return arr;
            }
        }

        public static ArrayList CarregaCombo1(int OPERACAO, string TABELA, string CAMPOSELECAO, String ORDEM)
        {
            try
            {
                ArrayList arr = new ArrayList();
                ImageList drop = new ImageList();
                string sProc = "SPR_CARREGA_COMBO";
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;

                        // OPERAÇÃO A SER EXECUDATA VERIFICAR REGITROS NA PROCEDURE    \\
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Float);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO.ToString();
                        // ------------------------------------------------------------\\
                        // TABELA A SER PESQUISADA                                     \\
                        oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                        oCmd.Parameters["@TABELA"].Value = TABELA.ToString();
                        // ------------------------------------------------------------\\
                        // CAMPO SELEÇÃO                                     \\
                        oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSELECAO.ToString();
                        // ------------------------------------------------------------\\
                        oCmd.Parameters.Add("@ORDEM", SqlDbType.VarChar);
                        oCmd.Parameters["@ORDEM"].Value = ORDEM.ToString();
                        // ------------------------------------------------------------\\
                        //oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();
                        //inicia leitura do datareader
                    
                        while (dr.Read())
                        {
                            arr.Add(new drop(@dr.GetValue(1).ToString(), Convert.ToInt64(@dr.GetValue(0).ToString())));
                        }
                        return arr;
                    }
                }
            }
            catch (Exception erro)
            {
                ArrayList arr = new ArrayList();
                MessageBox.Show(erro.ToString(), "Atenção");
                return arr;
            }
        }
        public static bool Grava_Prontuario(string Id_Paciente)
        {



            string NomeCampos = @"ID_PRONTUARIO," +
                                 "ID_PACIENTE";
            string ValuesCampos = @"," + Id_Paciente + "";

            bool RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "PRONTUARIOS", "ID_PRONTUARIO", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");
            Int32 CodigoProntuario = Convert.ToInt32(Funcoes.Operacoes.CapturaCampoTabela(6, "PRONTUARIOS", "ID_PRONTUARIO", "", ""));
            if (RetornoGravacao == true)
            {
                Funcoes.Operacoes.GravaArquivoLog(3, "PRONTUARIOS : " + ValuesCampos + "  USUARIO : " + Funcoes.Validacoes.NomeUsuario.ToString());
                MessageBox.Show("Registro Incluido com Sucesso", "AVISO");
            }
            return true;
        }

        public static bool Grava_Prontuario_Consulta(Int32 Id_Prontuario,
                                           Int32 Id_Agenda,
                                           Int32 Id_Medico,
                                           string Id_Operacao
                                            )
        {


            //==================================================================//
            //              VERIFICA SE EXISTE HISTORICO                        //
            //==================================================================//

            string Swhere = "ID_PRONTUARIO=" + Id_Prontuario + " " +
                            "AND ID_AGENDA_HORARIO=" + Id_Agenda+ " AND DELETED='0'";

            string ExisteRegistro =Funcoes.Operacoes.CapturaCampoTabela(5, "HISTORICO_PRONTUARIO", 
                                                                           "ID_HISTORICO", Swhere.ToString(), "");

            string NomeCampos="";
            string ValuesCampos="";
            bool RetornoGravacao = false;


            //-----------------------------------/
            //        NAO EXISTE                 /
            //-----------------------------------/
            if (ExisteRegistro == "")
            {
                NomeCampos = @"ID_HISTORICO," +
                                     "ID_PRONTUARIO," +
                                     "ID_AGENDA_HORARIO," +
                                     "ID_MEDICO," +
                                     "ID_OPERACAO";

                ValuesCampos = @"," +  Id_Prontuario + "," +
                                       Id_Agenda + "," +
                                       Id_Medico + "," +
                                       Id_Operacao + "";


                RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "HISTORICO_PRONTUARIO", "ID_HISTORICO", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");

            

            }
            //--------------------------------/
            //          EXISTE                /
            //--------------------------------/
            else
            {
                string ValorSet = @"ID_OPERACAO="+Id_Operacao+"";
                RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(2, "HISTORICO_PRONTUARIO", "ID_HISTORICO", ValorSet.ToString(), "", ExisteRegistro, "SPR_GRAVA_REGISTRO");

            }
            return true;
        }
        public static bool Grava_Exames_Pronturario(string Id_Prontuario,
                                                    string Id_Agenda,
                                                    string Id_Exame
                                                    )
        {


            //==================================================================//
            //              VERIFICA SE EXISTE HISTORICO                        //
            //==================================================================//

            string Swhere = "ID_EXAME=" + Id_Exame + " " +
                            "AND ID_AGENDA_HORARIO=" + Id_Agenda + " " +
                            "AND ID_PRONTUARIO="+Id_Prontuario + " AND DELETED='0'";

            string ExisteRegistro = Funcoes.Operacoes.CapturaCampoTabela(5, "HISTORICO_EXAME_PRONTUARIO",
                                                                           "ID_EXAME_HISTORICO", Swhere.ToString(), "");

            string NomeCampos = "";
            string ValuesCampos = "";
            bool RetornoGravacao = false;
            //-----------------------------------/
            //        NAO EXISTE                 /
            //-----------------------------------/
            if (ExisteRegistro == "")
            {
                NomeCampos = @"ID_EXAME_HISTORICO," +
                                      "ID_EXAME," +
                                      "ID_PRONTUARIO," +
                                      "ID_AGENDA_HORARIO";
                ValuesCampos = @"," + Id_Exame + "," +
                                       Id_Prontuario + "," +
                                       Id_Agenda + "";
                RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "HISTORICO_EXAME_PRONTUARIO", "ID_EXAME_HISTORICO", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");
            }
            else
            {
                string ValorSet = @" DELETED='1',DATA_DELETED=GETDATE()";
                RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(2, "HISTORICO_EXAME_PRONTUARIO", "ID_EXAME_HISTORICO", ValorSet.ToString(), "", ExisteRegistro, "SPR_GRAVA_REGISTRO");
            }

            return true;
        }

        public static bool Grava_Prontuario_Consulta_Iniciada(string Id_Prontuario,
                                         string Id_Agenda,
                                         string Id_Medico,
                                         string Id_Operacao,
                                         string Id_Doenca,
                                         string ID_CatDoenca,
                                         string Pressao_I,
                                         string Pressao_F,
                                         string Peso,
                                         string DataProxConsulta,
                                         string Descricao,
                                         string Receiturario
                                          )
        {


            //==================================================================//
            //              VERIFICA SE EXISTE HISTORICO                        //
            //==================================================================//

            string Swhere = "ID_PRONTUARIO=" + Id_Prontuario + " " +
                            "AND ID_AGENDA_HORARIO=" + Id_Agenda + " AND DELETED='0'";

            string ExisteRegistro = Funcoes.Operacoes.CapturaCampoTabela(5, "HISTORICO_PRONTUARIO",
                                                                           "ID_HISTORICO", Swhere.ToString(), "");

            string NomeCampos = "";
            string ValuesCampos = "";
            bool RetornoGravacao = false;


            //-----------------------------------/
            //        NAO EXISTE                 /
            //-----------------------------------/
            if (ExisteRegistro == "")
            {
                NomeCampos = @"ID_HISTORICO," +
                                     "ID_PRONTUARIO," +
                                     "ID_AGENDA_HORARIO," +
                                     "ID_MEDICO," +
                                     "ID_OPERACAO," +
                                     "ID_DOENCA,"+
                                     "ID_CATDOENCA,"+
                                     "PRESSAO_1," +
                                     "PRESSAO_2," +
                                     "PESO," +
                                     "PREVISAOPROX_CONSULTA," +
                                     "DESCRICAO," +
                                     "RECEITURARIO";

                ValuesCampos = @"," + Id_Prontuario + "," +
                                       Id_Agenda + "," +
                                       Id_Medico + "," +
                                       Id_Operacao + "," +
                                       Id_Doenca + ","+
                                       ID_CatDoenca +",'"+ 
                                       Pressao_I + "','" +
                                       Pressao_F + "','" +
                                       Peso + "','" +
                                       DataProxConsulta + "','" +
                                       Descricao + "','" +
                                       Receiturario + "'";



                RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "HISTORICO_PRONTUARIO", "ID_HISTORICO", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");



            }
            //--------------------------------/
            //          EXISTE                /
            //--------------------------------/
            else
            {
                string ValorSet = @"ID_PRONTUARIO=" + Id_Prontuario + "," +
                                   "ID_AGENDA_HORARIO=" + Id_Agenda + "," +
                                   "ID_MEDICO=" + Id_Medico + "," +
                                   "ID_OPERACAO =" + Id_Operacao + "," +
                                   "ID_DOENCA=" + Id_Doenca + "," +
                                   "ID_CATDOENCA=" + ID_CatDoenca + "," +
                                   "PRESSAO_1='" + Pressao_I.Replace(",",".") + "'," +
                                   "PRESSAO_2='" + Pressao_F.Replace(",",".") + "'," +
                                   "PESO='" + Peso.Replace(",",".") + "'," +
                                   "PREVISAOPROX_CONSULTA='" + DataProxConsulta + "'," +
                                   "DESCRICAO='" + Descricao + "'," +
                                   "RECEITUARIO='" + Receiturario + "'";




               RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(2, "HISTORICO_PRONTUARIO", "ID_HISTORICO", ValorSet.ToString(), "", ExisteRegistro, "SPR_GRAVA_REGISTRO");

            }
            return true;
        }
        public static ListView MarcaExameCadastrado(ListView ListaExame,Int32 CodProntuario,
                                   Int32 Codagenda)
        {
            ListViewItem item;
         
            item = new ListViewItem();
            for (int i = 0; i < ListaExame.Items.Count; i++)
            {
                string Swhere = "ID_PRONTUARIO=" + CodProntuario + " " +
                                          "AND ID_AGENDA_HORARIO=" + Codagenda +
                                         " AND ID_EXAME=" + ListaExame.Items[i].Text +
                                          " AND DELETED='0'";

                string RegistroMarcado= Funcoes.Operacoes.CapturaCampoTabela(5, "HISTORICO_EXAME_PRONTUARIO",
                                                                               "ID_EXAME_HISTORICO", Swhere.ToString(), "");


                if (RegistroMarcado!="")
                {
                    ListaExame.Items[i].Checked = true;
                }


            }
            return ListaExame;
        }


        public static ArrayList CarregaComboDoenca(int OPERACAO, string TABELA, string CAMPOSELECAO)
        {
            ArrayList arr = new ArrayList();
            ImageList drop = new ImageList();
            string sProc = "SPR_CARREGA_COMBO_DOENCA";
            using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
            {
                using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                {
                    oCn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;

                    // OPERAÇÃO A SER EXECUDATA VERIFICAR REGITROS NA PROCEDURE    \\
                    oCmd.Parameters.Add("@OPERACAO", SqlDbType.Float);
                    oCmd.Parameters["@OPERACAO"].Value = OPERACAO.ToString();
                    // ------------------------------------------------------------\\
                    // TABELA A SER PESQUISADA                                     \\
                    oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                    oCmd.Parameters["@TABELA"].Value = TABELA.ToString();
                    // ------------------------------------------------------------\\
                    // CAMPO SELEÇÃO                                     \\
                    oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                    oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSELECAO.ToString();
                    // ------------------------------------------------------------\\
                    //oCmd.ExecuteNonQuery();
                    SqlDataReader dr = oCmd.ExecuteReader();
                    //inicia leitura do datareader
                    while (dr.Read())
                    {
                        arr.Add(new drop(dr.GetValue(1).ToString(), Convert.ToInt16(dr.GetValue(0).ToString())));
                    }
                    return arr;
                }
            }
        }
        public static ArrayList CarregaComboCatDoenca(int OPERACAO, string TABELA, string CAMPOSELECAO, string CONDICAO)
        {
            ArrayList arr = new ArrayList();
            ImageList drop = new ImageList();
            string sProc = "SPR_CARREGA_CAT_COMBO_DOENCA";
            using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
            {
                using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                {
                    oCn.Open();
                    oCmd.CommandType = CommandType.StoredProcedure;
                    // OPERAÇÃO A SER EXECUDATA VERIFICAR REGITROS NA PROCEDURE    \\
                    oCmd.Parameters.Add("@OPERACAO", SqlDbType.Float);
                    oCmd.Parameters["@OPERACAO"].Value = OPERACAO.ToString();
                    // ------------------------------------------------------------\\
                    // TABELA A SER PESQUISADA                                     \\
                    oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                    oCmd.Parameters["@TABELA"].Value = TABELA.ToString();
                    // ------------------------------------------------------------\\
                    // CAMPO SELEÇÃO                                     \\
                    oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                    oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSELECAO.ToString();
                    // ------------------------------------------------------------\\
                    // CONDICAO                                     \\
                    oCmd.Parameters.Add("@CONDICAO", SqlDbType.VarChar);
                    oCmd.Parameters["@CONDICAO"].Value = @CONDICAO.ToString();
                    // ------------------------------------------------------------\\

                    //oCmd.ExecuteNonQuery();
                    SqlDataReader dr = oCmd.ExecuteReader();
                    //inicia leitura do datareader
                    while (dr.Read())
                    {
                        arr.Add(new drop(dr.GetValue(1).ToString(), Convert.ToInt16(dr.GetValue(0).ToString())));
                    }
                    return arr;
                }
            }
        }

        /*
         # FUNÇÃO PARA GRAVAR LISTAS DE HORÁRIOS MÉDICOS
         */ 
        public static bool GravaTurnos(ListView Lista,
                                      RadioButton Rdn,
                                      string VlrConsulta,
                                      string Turno,
                                      string CodMedico)
        {
            //==============================//
            String HoraIni = "";            //
            String MinIni = "";             //
            String SecIni = "00";           //
            String HoraFim = "";            //
            String MinFim = "";             //
            String Inicio = "";             //
            String Fim = "";                //
            bool RetornoGravacao = false;   //
            //==============================//

            if (Rdn.Checked == true)
            {
                for (Int32 i = 0; i < Lista.Items.Count; i++)
                {
                    //=====================================================//
                    //             VERIFICA  LISTA MANHA                  //
                    //=====================================================//
                    if (Lista.Items[i].SubItems[2].Text != "")
                    {
                        HoraIni = Lista.Items[i].SubItems[2].Text.Substring(0, 2);
                        MinIni = Lista.Items[i].SubItems[2].Text.Substring(3, 2);
                        HoraFim = Lista.Items[i].SubItems[3].Text.Substring(0, 2);
                        MinFim = Lista.Items[i].SubItems[3].Text.Substring(3, 2);

                        TimeSpan VlrInicio = new TimeSpan(Convert.ToInt16(HoraIni)
                            , Convert.ToInt16(MinIni), Convert.ToInt16(SecIni));
                        TimeSpan VlrFim = new TimeSpan(Convert.ToInt16(HoraFim)
                        , Convert.ToInt16(MinFim), Convert.ToInt16(SecIni));
                        String Dif = (VlrFim - VlrInicio).TotalMinutes.ToString();
                        try
                        {
                            double ValorDifMin = Convert.ToDouble(Dif) /
                                Convert.ToDouble(VlrConsulta);
                            int ValorInt = 0;
                            if (int.TryParse(ValorDifMin.ToString(), out ValorInt))
                            {
                                //É um inteiro, pois retornou true!
                            }
                            else
                            {
                                //É um double, pois retornou false. Então vou tentar ver se é um double..
                                //double.TryParse(textBox.Text, out variavel);
                                Funcoes.Validacoes.Mensagems("Erro de divisão de horários !", "AVISO");
                                //TxtValorMinConsultasManha.Focus();
                                return false;
                            }
                            Inicio = Lista.Items[i].SubItems[2].Text;
                            Fim = Lista.Items[i].SubItems[3].Text;
                        }
                        catch
                        {
                            Funcoes.Validacoes.Mensagems("Erro de divisão de horários !", "AVISO");
                            //TxtValorMinConsultasManha.Focus();
                            return false;
                        }
                        //=======================================================================
                        //                      MARCA REGISTRO COMO DELETEDADO                 //
                        //=======================================================================
                        string Swhere = "ID_DIASEMANA=" + Lista.Items[i].Text + " AND ID_MEDICO="
                            + CodMedico + " AND DELETED='0' AND ID_TURNO="+Turno;
                        string Existe = Funcoes.Operacoes.CapturaCampoTabela(5, "HORARIO_MEDICO", "DELETED", Swhere.ToString(), Funcoes.Validacoes.IdBalanca.ToString());

                        if (Existe == "0")
                        {

                            Swhere = "ID_DIASEMANA=" + Lista.Items[i].Text + " AND ID_MEDICO="
                                                            + CodMedico + " AND DELETED='0' " +
                                                            "AND ID_TURNO="+Turno;

                            string ValorSet = @" DELETED='1'," +
                                                "DATA_DELETED='" + System.DateTime.Now + "' ";
                            RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(5, "HORARIO_MEDICO", "ID_HORARIOMEDICO", ValorSet.ToString(), "", Swhere, "SPR_GRAVA_REGISTRO");
                        }

                        string NomeCampos = @"ID_HORARIOMEDICO," +
                                            "ID_MEDICO," +
                                            "ID_DIASEMANA," +
                                            "ID_TURNO," +
                                            "HORA_INICIO," +
                                            "HORA_FIM," +
                                            "TEMPO_CONSULTAS";


                        string ValuesCampos = @"," + CodMedico + "," +
                                                   +(i + 1) + "," +
                                                  Turno+",'" +
                                                  Inicio + "','" +
                                                  Fim + "'," +
                                                  VlrConsulta + "";
                        RetornoGravacao = Funcoes.Operacoes.GravaNovoRegistro(1, "HORARIO_MEDICO", "ID_HORARIOMEDICO", NomeCampos.ToString(), ValuesCampos.ToString(), "", "SPR_GRAVA_REGISTRO");
                    }

                }
            }


            return true;
        }


        public static void TrocaTABporEnter(Control _ctrl)
        {
            _ctrl.BackColor = Color.Aquamarine;

            if (_ctrl.HasChildren)
            {
                foreach (Control _child in _ctrl.Controls)
                {
                    if (_ctrl.HasChildren)
                        TrocaTABporEnter(_child);
                }
            }
            else
            {
                ///Não funciona para Numeric Up Down
                if (_ctrl is TextBox ||
                _ctrl is MaskedTextBox ||
                _ctrl is ListBox ||
                _ctrl is CheckBox ||
                _ctrl is TabPage ||
                _ctrl is ComboBox ||
                _ctrl is DateTimePicker)
                // _ctrl is ComboBox || _ctrl is NumericBox.NumericBox)
                {
                    /// inibe a ação do Enter para evitar o comportamento de
                    /// Accept em alguns casos
                    _ctrl.KeyDown += delegate (object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Enter)
                            e.SuppressKeyPress = true;
                    };
                    /// adiciona a tratativa à tecla Enter e envia o TAB para
                    /// promover a navegação
                    _ctrl.KeyUp += delegate (object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            // SendKeys.Send("{TAB}");
                            _ctrl.FindForm().SelectNextControl(_ctrl, true, true, true, false);
                        }
                    };
                }
            }
        }

        public static bool VerificaTeclaCapsLook(KeyEventArgs tecla)
        {
            if (tecla.KeyCode==Keys.CapsLock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool VerificaTeclaProssionada(KeyPressEventArgs tecla)
        {

            if (!Char.IsDigit(tecla.KeyChar) && tecla.KeyChar == (char)39)
            {
                return true;
            }
            else
            {
                return VerificaCaratereEspecial(tecla);
            }

        }
        public static bool VerificaCaratereEspecial(KeyPressEventArgs tecla)
        {
            if (tecla.KeyChar == (char)8)
            {
                return false;
            }
            else if (tecla.KeyChar == (char)199)
            {
                return false;
            }
            else if (tecla.KeyChar == (char)32)
            {
                return false;
            }
            else if (tecla.KeyChar == (char)231)
            {
                return false;
            }
            else if ((tecla.KeyChar >= (char)48 &&
                tecla.KeyChar <= (char)57) ||
                (tecla.KeyChar >= (char)65  &&
                tecla.KeyChar <= (char)90) ||
                (tecla.KeyChar >= (char)97 &&
                  tecla.KeyChar <= (char)122))
            {
                return false;
            }
            else
                return true;

        }

        public static String RetiraCaracteresInvalidos(String Texto)
        {
            Texto = Texto.Replace(",", "");
            Texto = Texto.Replace("'", "");
            return Texto;
        }
        public static ArrayList VerificaCep(String Texto)
        {
             ArrayList retorno = new ArrayList();
            string urll = @"http://viacep.com.br/ws/" + Texto+ @"//json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urll);
            string xml = "";
            request.Headers.Clear();
            request.Method = "POST";
            byte[] arrMensagem = Encoding.UTF8.GetBytes(xml);
            request.ContentLength = arrMensagem.Length;
            using (Stream stmRequest = request.GetRequestStream())
            {
                stmRequest.Write(arrMensagem, 0, arrMensagem.Length);
                stmRequest.Close();
            }
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader srResponse = new StreamReader(response.GetResponseStream()))
                {
                    String indice = "\n";
                    var TxtTotal = srResponse.ReadToEnd().Substring(0);

                    int PosicaoIni = TxtTotal.Substring(0).IndexOf("erro");
                    if (PosicaoIni < 0)
                    {
                        //==================================================================//
                        PosicaoIni = TxtTotal.Substring(0).IndexOf("logradouro") + 14;
                        int Posicao = TxtTotal.Substring(PosicaoIni).IndexOf(indice);
                        retorno.Add(TxtTotal.Substring(PosicaoIni, Posicao - 2));
                        //==================================================================//
                        PosicaoIni = TxtTotal.Substring(0).IndexOf("complemento") + 15;
                        Posicao = TxtTotal.Substring(PosicaoIni).IndexOf(indice);
                        retorno.Add(TxtTotal.Substring(PosicaoIni, Posicao - 2));
                        //==================================================================//
                        PosicaoIni = TxtTotal.Substring(0).IndexOf("bairro") + 10;
                        Posicao = TxtTotal.Substring(PosicaoIni).IndexOf(indice);
                        retorno.Add(TxtTotal.Substring(PosicaoIni, Posicao - 2));
                        //==================================================================//
                        PosicaoIni = TxtTotal.Substring(0).IndexOf("localidade") + 14;
                        Posicao = TxtTotal.Substring(PosicaoIni).IndexOf(indice);
                        retorno.Add(TxtTotal.Substring(PosicaoIni, Posicao - 2));
                        //==================================================================//
                        PosicaoIni = TxtTotal.Substring(0).IndexOf("uf") + 6;
                        Posicao = TxtTotal.Substring(PosicaoIni).IndexOf(indice);
                        retorno.Add(TxtTotal.Substring(PosicaoIni, Posicao - 2));
                        //==================================================================//
                    }
                }
                response.Close();
            }
            return retorno;
        }
        
        #region CarregaComboUF
        public static ComboBox Carrega_CombouUF(ComboBox CmbUf)
        {
            ArrayList arr1 = new ArrayList();
            arr1 = Funcoes.Operacoes.CarregaCombo(2, "ESTADOS", "ID,UPPER(SIGLA_ESTADO)", "");
            CmbUf.DataSource = arr1;
            CmbUf.DisplayMember = "nome";
            CmbUf.ValueMember = "valor";

            return CmbUf;
        }
        #endregion
        #region MensagemBalao
        public static ToolTip BalloonGeneratesMessage(int Pos1, 
            int Pos2, 
            String Mensage, 
            Control Control,
            string TypeIcon)
        {
            ToolTip tip = new ToolTip();
            if (TypeIcon == "Info")
                tip.ToolTipIcon = ToolTipIcon.Info;
            if (TypeIcon == "Warnig")
                tip.ToolTipIcon = ToolTipIcon.Warning;
            if (TypeIcon == "Error")
                tip.ToolTipIcon = ToolTipIcon.Error;
            if (TypeIcon == "Error")
                tip.ToolTipIcon = ToolTipIcon.Error;
            if (TypeIcon == "None")
                tip.ToolTipIcon = ToolTipIcon.None;

            tip.IsBalloon = true;
            tip.Show(Mensage, Control, new Point(Pos1, Pos2));
            tip.AutoPopDelay = 50;
            tip.InitialDelay = 100;
            tip.ReshowDelay = 500;
            return tip;
        }



        #endregion



        #region CliptSenha
        /// <summary>
        /// Calcula MD% Hash de uma determinada string passada como parametro
        /// </summary>
        /// <param name="Senha">String contendo a senha que deve ser criptografada para MD5 Hash</param>
        /// <returns>string com 32 caracteres com a senha criptografada</returns>
        public static string CalculaHash(string Senha)
        {
            try
            {
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Senha);
                byte[] hash = md5.ComputeHash(inputBytes);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString(); // Retorna senha criptografada 
            }
            catch (Exception)
            {
                return null; // Caso encontre erro retorna nulo
            }
        }
    #endregion



        #region FormataTextos
        public static string FormataCep(string cep)
        {
            try
            {
                return Convert.ToUInt64(cep).ToString(@"00000\-000");
            }
            catch
            {
                return "";
            }
        }

        public static string FormataCpf(string cpf)
        {
            try
            {
                return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            }
            catch
            {
                return "";
            }
        }

        #endregion
        public static string FormataTelefone(string telefone)
        {

            if (telefone.Length > 0)
            {
                telefone = telefone.Replace("(", "");
                telefone = telefone.Replace(")", "");
                telefone = telefone.Replace("-", "");
                telefone = telefone.Replace(" ", "");
                telefone = telefone.Replace(".", "");
                telefone = telefone.Replace(@"/", "");
                telefone = telefone.Replace(@"\", "");
                int caseSwitch = telefone.Length;
                switch (caseSwitch)
                {
                    case 10:
                        telefone = string.Format("{0:(##) ####-####}", Convert.ToInt64(telefone));
                        return telefone;
                    case 11:
                        telefone = String.Format("{0:(##) #####-####}", Convert.ToInt64(telefone));
                        return telefone;
                    case 8:
                        telefone = string.Format("{0: ####-####}", Convert.ToInt64(telefone));
                        return telefone;
                    case 9:
                        telefone = string.Format("{0: #####-####}", Convert.ToInt64(telefone));
                        return telefone;

                    default:
                        //telefone = string.Format("{0:(##) ####-####}", Convert.ToInt64(telefone));
                        return telefone;
                }
            }
            else
            {
                return telefone;
            }
        }
        public static string RetornaTelefone(string telefone)
        {

            if (telefone.Length > 0)
            {
                telefone = telefone.Replace("(", "");
                telefone = telefone.Replace(")", "");
                telefone = telefone.Replace("-", "");
                telefone = telefone.Replace(" ", "");
                return telefone;
            }
            else
            {
                return telefone;
            }
        }


        public static bool GravaArquivoLog(int Operacao, String Texto)
        {
            String DiretorioPesquisa = Environment.CurrentDirectory + "\\" + "LOGEVENTOS" + System.DateTime.Now.ToShortDateString().Replace(@"/","") + ".TXT";
            if (Operacao == 1)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@DiretorioPesquisa, true))
                {
                    file.WriteLine("======================================================================================================");
                    file.WriteLine("ABERTURA DO SISTEMA " + System.DateTime.Now.ToString().Replace(@"/","_") + "-" +Texto);
                }
            }
            if (Operacao == 2)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@DiretorioPesquisa, true))
                {
                    file.WriteLine("======================================================================================================");
                    file.WriteLine("SAIDA DO SISTEMA " + System.DateTime.Now.ToString().Replace(@"/", "_") + "-" + Texto);
                    file.WriteLine("======================================================================================================");
                }
            }
            if (Operacao == 3)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@DiretorioPesquisa, true))
                {
                    file.WriteLine("======================================================================================================");
                    file.WriteLine("INSERIDO REGISTRO " + System.DateTime.Now.ToString().Replace(@"/", "_") + "-" + Texto);
                    file.WriteLine("======================================================================================================");
                }
            }
            if (Operacao == 4)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@DiretorioPesquisa, true))
                {
                    file.WriteLine("======================================================================================================");
                    file.WriteLine("ALTERADO REGISTRO " + System.DateTime.Now.ToString().Replace(@"/", "_") + "-" + Texto);
                    file.WriteLine("======================================================================================================");
                }
            }
            if (Operacao == 5)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@DiretorioPesquisa, true))
                {
                    file.WriteLine("======================================================================================================");
                    file.WriteLine("EXCLUIDO REGISTRO " + System.DateTime.Now.ToString().Replace(@"/", "_") + "-" + Texto);
                    file.WriteLine("======================================================================================================");
                }
            }
            return true;
        }

        public static bool VerificaHoraMin(String Hora,String Min,String Periodo,MaskedTextBox Mask)
        {
            bool retorno=true;
            if (retorno == true)
            {
                if (Convert.ToInt32(Hora) > 23)
                {
                    MessageBox.Show("Horario digitado Inválido", "Aviso");
                    Mask.Focus();
                    retorno = false;
                    return retorno;
                }
                if (Convert.ToInt32(Min) > 59)
                {
                    MessageBox.Show("Horario digitado Inválido", "Aviso");
                    Mask.Focus();
                    retorno = false;
                    return retorno;
                }
            }
            if (Periodo=="Manha")
            {
                string HoraManha = Hora + ":" + Min;
                if (Convert.ToDateTime(HoraManha)<Convert.ToDateTime("06:00") || Convert.ToDateTime(HoraManha) > Convert.ToDateTime("12:00"))
                {
                    MessageBox.Show("Horario da Manhã Inválido (06:00 as 12:00)", "Aviso");
                    retorno = false;
                    Mask.Focus();
                    return retorno;
                }
            }
            if (Periodo == "Tarde")
            {
                string HoraTarde = Hora + ":" + Min;
                if (Convert.ToDateTime(HoraTarde) < Convert.ToDateTime("12:00") || Convert.ToDateTime(HoraTarde) > Convert.ToDateTime("18:00"))
                {
                    MessageBox.Show("Horario da Tarde Inválido (12:00 as 18:00)", "Aviso");
                    retorno = false;
                    Mask.Focus();
                    return retorno;
                }
            }
            if (Periodo == "Noite")
            {
                string HoraNoite = Hora + ":" + Min;
                if (Convert.ToDateTime(HoraNoite) < Convert.ToDateTime("18:00") )
                {
                    if (Convert.ToDateTime(HoraNoite) == Convert.ToDateTime("00:00"))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Horario da Noite Inválido (18:00 as 00:00)", "Aviso");
                        retorno = false;
                        Mask.Focus();
                        return retorno;
                    }
                }
            }
            if (Periodo == "Madrugada")
            {
                string HoraMadrugada = Hora + ":" + Min;
                if (Convert.ToDateTime(HoraMadrugada) < Convert.ToDateTime("00:00") || Convert.ToDateTime(HoraMadrugada) > Convert.ToDateTime("06:00"))
                {
                    MessageBox.Show("Horario da Madrugada Inválido (00:00 as 06:00)", "Aviso");
                    retorno = false;
                    Mask.Focus();
                    return retorno;
                }
            }


            return retorno;

        }

        public static bool ApagaRegistroEstavelEntrda(int OPERACAO ,string CODIGO, string PROCEDURE)
        {
            try
            {
                string sProc = PROCEDURE;
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Int);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO;
                        oCmd.Parameters.Add("@CODIGOPESAGEM", SqlDbType.VarChar);
                        oCmd.Parameters["@CODIGOPESAGEM"].Value = CODIGO;
                        SqlDataReader dr = oCmd.ExecuteReader();
                    }
                }
                Funcoes.Validacoes.GravadoRegistro = true;
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().Contains("chave duplicada"))
                {
                    Funcoes.Validacoes.MensagemAviso = "Registro com o mesmo CGC ou CPF já existente na base de dados";
                    return false;
                }
                return false;
            }
        }
        public static bool ApagaRegistroFormularioTicket(int OPERACAO, string CODIGO, string PROCEDURE)
        {
            try
            {
                string sProc = PROCEDURE;
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Int);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO;
                        oCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar);
                        oCmd.Parameters["@CODIGO"].Value = CODIGO;
                        SqlDataReader dr = oCmd.ExecuteReader();
                    }
                }
                Funcoes.Validacoes.GravadoRegistro = true;
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().Contains("chave duplicada"))
                {
                    Funcoes.Validacoes.MensagemAviso = "Registro com o mesmo CGC ou CPF já existente na base de dados";
                    return false;
                }
                return false;
            }
        }

        public static bool GravaNovoRegistro(int OPERACAO, string TABELA, string CAMPOID, string CAMPOSGRAVACAO, string VALORESCAMPOS, string CODIGO, string PROCEDURE)
        {
            try
            {
               
               string sProc = PROCEDURE;
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Int);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO;
                        oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                        oCmd.Parameters["@TABELA"].Value = TABELA;
                        oCmd.Parameters.Add("@CAMPOID", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOID"].Value = CAMPOID;
                        oCmd.Parameters.Add("@CAMPOSGRAVACAO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOSGRAVACAO"].Value = CAMPOSGRAVACAO;
                        oCmd.Parameters.Add("@VALORESCAMPOS", SqlDbType.VarChar);
                        oCmd.Parameters["@VALORESCAMPOS"].Value = VALORESCAMPOS;
                        oCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar);
                        oCmd.Parameters["@CODIGO"].Value = CODIGO;
                        SqlDataReader dr = oCmd.ExecuteReader();
                    }
                }
                Funcoes.Validacoes.GravadoRegistro = true;
                return true;
            }
            catch(Exception ex)
            {
                if (ex.Message.ToString().Contains("chave duplicada"))
                {
                    Funcoes.Validacoes.MensagemAviso = "Registro com o mesmo CGC ou CPF já existente na base de dados";
                    return false;
                }
                return false;
            }
        }

        public static String ImprimeTextoTicket()
        {
                //===================================================================================================//
                //                                      VALORES                                                      //
                //===================================================================================================//
                string ValorPesoMeximoEixo = "0";
                string ValorToleranciaEixo = "0";
                string Formato2 = "0";
                string BalancaSaida = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "BALANCA_S", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                string PercentualDifPeso = Funcoes.Operacoes.CapturaCampoTabela(1, "CONFIGURACAO_BALANCA", "TOLERANCIA_PERC_PESO", "ID_CONFBALANCA", BalancaSaida);
                string ValorNotaFiscal = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "NOTAF", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                string Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_INF", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)));
                string ValorPesoInformado = Formato1;
                Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_BRUTO", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)));
                string ValorPesoBruto =Formato1;
                Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_LIQ", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)));
                string ValorPesoLiquido = Formato1;
                Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_TARA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)));
                string ValorPesoTara = Formato1;
                //===================================================================================================//
                // 14/08/2012 MHS        <--->         CAPTURA DO TIPO DE VEICULO PELA TABELA DO DENIT               //
                //===================================================================================================//
                string TipoVeiculo = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_VEICULO", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                string Seq_Eixo = Funcoes.Operacoes.CapturaCampoTabela(1, "VEICULOS", "SEQ_EIXO", "ID_VEICULO", TipoVeiculo.ToString());
               
                Array MeuArray =   VerificaGrupoPesoEixo(Seq_Eixo);
            
                //===================================================================================================//
                String texto = "";
                texto += "\r\n";
                texto += "================================================" + "\r\n"; 
                texto += "EMPRESA : " + Funcoes.Validacoes.EmpresaCadastrada.ToString().ToUpper()+ "\r\n";
                texto += "CNPJ    : " + Funcoes.Validacoes.CnpjEmpresaCadastrada.ToString() + "\r\n";
                texto += Funcoes.Validacoes.EnderecoEmpresaCadastrada.ToString().ToUpper() + "\r\n"; 
                texto += "================================================" + "\r\n";
                texto += "TICKET DE SAIDA PESAGEM NR : " + Funcoes.Validacoes.valorTicket.ToString().PadLeft(6, '0') + "\r\n";
                texto += "DATA : " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss") + "\r\n";
                //----------------------------------
                texto += "PLACA : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PLACA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) +  " - MOTORISTA : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "MOTORISTA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) + "\r\n";
                //----------------------------------
                texto += "ENTRADA : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "DATA_ENTRADA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) + " * TARA -  " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "OPERADOR_E", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) + "\r\n";
                texto += "SAIDA   : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "DATA_SAIDA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) + " * BRUTO - " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "OPERADOR_S", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) + "\r\n";
                string OPERACAO = "";
                if (Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_LIQ", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)) < 0)
                {
                    OPERACAO = "RECEBIMENTO";
                    ValorPesoLiquido = Convert.ToString(Convert.ToDouble(ValorPesoLiquido) * -1);
                }
                else
                {
                    OPERACAO = "EXPEDICAO";
                    
                }
                texto += "OPERACAO ......: " + OPERACAO.ToString() + "\r\n";
                texto += "CLIENTE  ......:" + Funcoes.Operacoes.CapturaCampoTabela(1, "CLIFORN", "NOME", "ID_CLIFORN", Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_CLIFOR", "ID_PESAGEM", Funcoes.Validacoes.valorTicket))+ "\r\n";
                texto += "PRODUTO  ......: " + Funcoes.Operacoes.CapturaCampoTabela(1, "PRODUTOS", "DESCRICAO", "ID_PRODUTO", Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_PRODUTO", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)) + "\r\n";
                texto += "TRANSPORTADOR .: " + Funcoes.Operacoes.CapturaCampoTabela(1, "TRANSPORTADORA", "NOME", "ID_TRANSPORTADORA", Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_TRANSPORTADORA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)) + "\r\n";
                texto += "------------------------------------" + "\r\n";
                texto += "| N.FISCAL / DOC  |     PESO       |"+ "\r\n"; 
                texto += "------------------------------------" + "\r\n";
                texto += ValorNotaFiscal.ToString().PadLeft(10, '0') + "              " + ValorPesoInformado.ToString() + " kg \r\n";
                texto += "-------------------------------------" + "\r\n";
                texto += "PESO BRUTO ....: " + ValorPesoBruto.PadLeft(7,' ') +  " kg \r\n";
                texto += "TARA ..........: " + ValorPesoTara.PadLeft(7, ' ') + " kg \r\n";
                texto += "PESO LIQUIDO...: " + ValorPesoLiquido.PadLeft(7, ' ') + " kg \r\n";
                texto += "-------------------------------------" + "\r\n";
                texto += "            PESAGEM EIXOS                 \r\n";
                texto += "---------------------------------------------------" + "\r\n";
                texto += " PESAGEM          |P.MAX.EIXO|TOLER="+PercentualDifPeso + "%" + " |DIF.EIXOS \r\n";
                texto += "---------------------------------------------------" + "\r\n";
            
            
            
            
                string Swhere = @"ID_PESAGEM=" + Funcoes.Validacoes.valorTicket.ToString() + " " +
                                " AND (OPERACAO='SAIDA' OR OPERACAO='AVULSA')";

                int ContadorEixos = 1;
                int ContadorEixos1 = 1;
                int NrEixos = 1;
                if (Funcoes.Validacoes.TipoPesagem == "2")
                {
                    int ValorEixo = Convert.ToInt16(Funcoes.Operacoes.CapturaCampoTabela(5, "PESAGEMEIXO", "MAX(NR_EIXO)", Swhere.ToString(), Funcoes.Validacoes.IdBalanca.ToString()));
                    for (Int32 i = 0; i < ValorEixo; i++)
                    {
                        ContadorEixos = 1;
                        //NrEixos = 0;
                        if (ContadorEixos1 >= ValorEixo)
                            break;
                        double SomaPesagem = 0;

                        for (Int32 ii = 0; ii < Convert.ToInt16(MeuArray.GetValue(i)); ii++)
                        {
                            if (ContadorEixos == Convert.ToInt16(MeuArray.GetValue(i)))
                            {
                                Swhere = @"ID_PESAGEM=" + Funcoes.Validacoes.valorTicket.ToString() + " AND DELETED='0' AND ISNULL(DATA_DELETED,0)=0 " +
                                " AND NR_EIXO=" + (NrEixos+1) + " AND (OPERACAO='SAIDA' OR OPERACAO='AVULSA')";
                                Formato1 =  String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(5, "PESAGEMEIXO", "VALOR_PESO", Swhere.ToString(), Funcoes.Validacoes.valorTicket)));
                                Formato2 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(5, "PESAGEMEIXO", "VALOR_PESO", Swhere.ToString(), Funcoes.Validacoes.valorTicket)) + SomaPesagem);
                                ValorPesoMeximoEixo =Funcoes.Operacoes.CapturaCampoTabela(8, "VEICULO_EIXO", "PESO_MAXIMO", "ID_VEICULO="+TipoVeiculo + " AND NR_EIXO="+(i+1).ToString(), "");
                                ValorToleranciaEixo =String.Format("{0:#,###,###0}",(Convert.ToDouble(ValorPesoMeximoEixo) * Convert.ToDouble(PercentualDifPeso) / 100));
                                double DiferencaEixo = Convert.ToDouble(ValorPesoMeximoEixo) + Convert.ToDouble(ValorToleranciaEixo) - Convert.ToDouble(Formato2);
                                texto += (i + 1).ToString() + "º EIXO:" + Formato1.ToString().PadLeft(7, ' ') + " Kg|" + String.Format("{0:#,###,###0}", Convert.ToDouble(ValorPesoMeximoEixo.ToString())).PadLeft(7,' ') + " Kg|" + ValorToleranciaEixo.PadLeft(7,' ') + " Kg|"+  String.Format("{0:#,###,###0}", Convert.ToDouble(DiferencaEixo.ToString())).PadLeft(7,' ') + " Kg \r\n";
                            }
                            else
                            {
                                Swhere = @"ID_PESAGEM=" + Funcoes.Validacoes.valorTicket.ToString() + " AND DELETED='0' AND ISNULL(DATA_DELETED,0)=0 " +
                                " AND NR_EIXO=" + (i + 1) + " AND (OPERACAO='SAIDA' OR OPERACAO='AVULSA')";
                                Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(5, "PESAGEMEIXO", "VALOR_PESO", Swhere.ToString(), Funcoes.Validacoes.valorTicket)));
                                SomaPesagem = Convert.ToDouble(Formato1) + SomaPesagem;
                                texto += (i + 1).ToString() + "º EIXO:" + Formato1.ToString().PadLeft(7, ' ') + " Kg \r\n";
                                NrEixos = NrEixos + 1;
                            }
                            ContadorEixos = ContadorEixos + 1;
                            ContadorEixos1 = ContadorEixos1 + 1;
                        }
                       
                    }
                }

                texto += "---------------------------------------------------" + "\r\n";
                texto += "OBS ENTRADA : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "OBS_E", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) +"\r\n";
                texto += "OBS SAIDA   : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "OBS_S", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) + "\r\n";
                texto += "---------------------------------------------------" + "\r\n";
                texto += "" + "\r\n";
                texto += "" + "\r\n";
                texto += "" + "\r\n";
                texto += "" + "\r\n";
                texto += "" + "\r\n";
                texto += "" + "\r\n";
                texto += "-----------------------------------------------\r\n";
                texto += "Motorista : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "MOTORISTA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)+ "                    " + Funcoes.Validacoes.NomeUsuario.ToString()    + "\r\n";
                texto += "" + "\r\n";
                texto += "" + "\r\n";
                texto += "" + "\r\n";
                texto += "" + "\r\n";
                texto += "" + "\r\n";
                //texto += "CLIENTE/FORN. :" + Funcoes.Operacoes.CapturaCampoTabela(1, "CLIFORN", "NOME", "ID_CLIFORN", Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_CLIFOR", "ID_PESAGEM", Funcoes.Validacoes.valorTicket))+ "\r\n";
                ////----------------------------------
                //texto += "PRODUTO       : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PRODUTOS", "DESCRICAO", "ID_PRODUTO", Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_PRODUTO", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)) + "\r\n";
                ////----------------------------------
                //string OPERACAO = "";
                //if (Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_LIQ", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)) < 0)
                //{
                //    OPERACAO = "DESCARREGAMENTO";
                //}
                //else
                //{
                //    OPERACAO = "CARREGAMENTO";
                //}
                //texto += "OPERACAO      : " + OPERACAO.ToString() + "\r\n";
                //texto += "==========================================\r\n";
                //texto += "PESAGEM INICIAL                           \r\n";
                //texto += "==========================================\r\n";
                //texto += "DATA         : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "DATA_ENTRADA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) + "\r\n";
                //string Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_TARA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)));
                //texto += "PESO TARA    : " + Formato1 + " Kg \r\n";
                //texto += "==========================================\r\n";
                //texto += "PESAGEM FINAL                             \r\n";
                //texto += "==========================================\r\n";
                //texto += "DATA         : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "DATA_SAIDA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket) + "\r\n";
                //Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_BRUTO", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)));
                //texto += "PESO BRUTO   : " + Formato1 + " Kg \r\n";
                //Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_LIQ", "ID_PESAGEM", Funcoes.Validacoes.valorTicket)));
                //texto += "PESO LIQUIDO : " + Formato1 + " Kg \r\n";
                ////====================================================================//
                ////                      IMPRIMINDO OS EIXOS                           //  
                ////====================================================================//
                
                //texto += "==========================================\r\n";
                //texto += "PESAGEM EIXOS ENTRADA                      \r\n";
                //texto += "==========================================\r\n";
                //String Swhere = @"ID_PESAGEM=" + Funcoes.Validacoes.valorTicket.ToString() + " " +
                //      " AND OPERACAO='ENTRADA' ";
                //int ValorEixo = Convert.ToInt16(Funcoes.Operacoes.CapturaCampoTabela(5, "PESAGEMEIXO", "MAX(NR_EIXO)", Swhere.ToString(), Funcoes.Validacoes.IdBalanca.ToString()));
                //for (Int32 i = 0; i < ValorEixo; i++)
                //{
                //   Swhere = @"ID_PESAGEM=" + Funcoes.Validacoes.valorTicket.ToString() + " " +
                //      " AND NR_EIXO='" + (i + 1)  + "' AND OPERACAO='ENTRADA' " ;
                //    Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(5, "PESAGEMEIXO", "VALOR_PESO",  Swhere.ToString(), Funcoes.Validacoes.valorTicket)));
                //    texto += (i+1).ToString() +"º EIXO  : " + Formato1.ToString()+" Kg \r\n";
                //}
                ////====================================================================//
                ////                      IMPRIMINDO OS EIXOS                           //  
                ////====================================================================//
                //texto += "==========================================\r\n";
                //texto += "PESAGEM EIXOS SAIDA                      \r\n";
                //texto += "==========================================\r\n";
                //Swhere = @"ID_PESAGEM=" + Funcoes.Validacoes.valorTicket.ToString() + " " +
                //      " AND OPERACAO='SAIDA'";
                //ValorEixo = Convert.ToInt16(Funcoes.Operacoes.CapturaCampoTabela(5, "PESAGEMEIXO", "MAX(NR_EIXO)", Swhere.ToString(), Funcoes.Validacoes.IdBalanca.ToString()));
                //for (Int32 i = 0; i < ValorEixo; i++)
                //{
                //    Swhere = @"ID_PESAGEM=" + Funcoes.Validacoes.valorTicket.ToString() + " " +
                //       " AND OPERACAO='SAIDA' AND NR_EIXO=" + (i + 1);
                //    Formato1 = String.Format("{0:#,###,###0}", Convert.ToDouble(Funcoes.Operacoes.CapturaCampoTabela(5, "PESAGEMEIXO", "VALOR_PESO", Swhere.ToString(), Funcoes.Validacoes.valorTicket)));
                //    texto += (i + 1).ToString() + "º EIXO  : " + Formato1.ToString() + " Kg \r\n";
                //}
                return texto;
        
        
        }

        public static String ImprimeTextoTicketFerrous()
        {
            try
            {
                //===================================================================================================//
                //                                      VALORES                                                      //
                //===================================================================================================//
                //CarregaGrade_FormatoImpressao(36, "", "","", "1", ListaImpressao, "SPR_PESQUISA_CAMPOS_TABELA");

                string sProc = "SPR_PESQUISA_CAMPOS_TABELA";
                int OPERACAO = 37;
                string TABELA = "";
                string CAMPOSSELECAO = "";
                string CAMPO = "";
                string Numero_ticket = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "NR_TICKET", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                string CODIGO = "1";
                if (Numero_ticket != "0")
                {
                    Funcoes.Validacoes.TipoImpressao = "TICKET";
                    CODIGO = "1";
                }
                else
                {
                    Funcoes.Validacoes.TipoImpressao = "COMPROVANTE";
                    CODIGO = "2";
                }


                String texto = "";
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Int);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO;
                        oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                        oCmd.Parameters["@TABELA"].Value = TABELA;
                        oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSSELECAO;
                        oCmd.Parameters.Add("@CAMPO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPO"].Value = CAMPO;
                        oCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar);
                        oCmd.Parameters["@CODIGO"].Value = CODIGO;
                        oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();
                         int i1 = 0;
                        int ContadorLinha = 0;
                        int ValorLinha = 1;
                        string Espaco = "";
                        while (dr.Read())
                        {


                            for (int i = 1; i < dr.FieldCount; i++)
                            {
                                if (dr.GetValue(i - 1).ToString() == "BRANCO")
                                {
                                    texto += "\r\n";
                                    break;
                                }
                                else
                                {
                                    if (Funcoes.Validacoes.TipoImpressao == "TICKET")
                                    {
                                        Int32 Recui1 = Convert.ToInt32(dr.GetValue(1).ToString());
                                        string Campo1 = dr.GetValue(2).ToString();
                                        Int32 Recui2 = Convert.ToInt32(dr.GetValue(3).ToString());
                                        string Campo2 = dr.GetValue(4).ToString();
                                        Int32 Recui3 = Convert.ToInt32(dr.GetValue(5).ToString());
                                        string Campo3 = dr.GetValue(6).ToString();


                                        if (Campo1.ToString() == "NR_TICKET")
                                        {
                                            texto += Espaco.PadLeft(Recui1, ' ') + "" + "\r\n";
                                            break;
                                        }

                                        string codigo_cliente = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_CLIFOR", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                        if (Campo1.ToString() == "NOME")
                                        {
                                            string nome_cliente = "Nome ......:" + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "NOME", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui1, ' ') + nome_cliente + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "ENDERECO")
                                        {
                                            string Endereco_cliente = "Endereço ...: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "ENDERECO", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui1, ' ') + Endereco_cliente + "\r\n";

                                            break;
                                        }
                                        if (Campo1.ToString() == "CIDADE")
                                        {
                                            string Cidade_cliente = "Cidade ....: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "CIDADE", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui1, ' ') + Cidade_cliente + "";
                                            string Cep_cliente = "Cep ...: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "CEP", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui2, ' ') + Cep_cliente + "";
                                            string Uf_cliente = "UF .: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "ESTADO", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui3, ' ') + Uf_cliente + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "CNPJ_CPF")
                                        {
                                            string Cnpj_cliente = "CNPJ ....: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "CNPJ_CPF", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui1, ' ') + Cnpj_cliente + "";
                                            string InscEst_cliente = "Insc. Estadual..: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "INSTEST", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui2, ' ') + InscEst_cliente + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "ID_PESAGEM")
                                        {
                                            texto += Espaco.PadLeft(Recui1, ' ') + Numero_ticket.PadLeft(8, '0') + "";
                                            string Nome_impressao = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "NOME_IMPRESSAO", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + Nome_impressao + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "DATA_SAIDA")
                                        {
                                            string Data_Saida = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "DATA_SAIDA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui1, ' ') + Data_Saida.Substring(0, 10) + "";
                                            string Nome_impressao = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_BRUTO", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + Nome_impressao + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "HORA_SAIDA")
                                        {
                                            string Hora_Saida = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "DATA_SAIDA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui1, ' ') + Convert.ToDateTime(Hora_Saida).ToLongTimeString();// .ToString("hh:mm:ss") + "";
                                            string Peso_tara = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_TARA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + Peso_tara + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "PLACA")
                                        {
                                            string Placa = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PlacaCarreta", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui1, ' ') + Placa.ToString() + "";
                                            string Peso_liq = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_LIQ", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + Peso_liq + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "TRANSPORTADORA")
                                        {
                                            string CodTransportadora = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_TRANSPORTADORA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            string NomeTransportadora = Funcoes.Operacoes.CapturaCampoTabela(1, "TRANSPORTADORA", "NOME", "ID_TRANSPORTADORA", CodTransportadora.ToString());
                                            texto += Espaco.PadLeft(Recui1, ' ') + NomeTransportadora.ToString() + "";
                                            string Obs = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "OBS_S", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + Obs + "\r\n";
                                            break;
                                        }
                                    }
                                    if (Funcoes.Validacoes.TipoImpressao != "TICKET")
                                    {
                                        Int32 Recui1 = Convert.ToInt32(dr.GetValue(1).ToString());
                                        string Campo1 = dr.GetValue(2).ToString();
                                        Int32 Recui2 = Convert.ToInt32(dr.GetValue(3).ToString());
                                        string Campo2 = dr.GetValue(4).ToString();
                                        Int32 Recui3 = Convert.ToInt32(dr.GetValue(5).ToString());
                                        string Campo3 = dr.GetValue(6).ToString();

                                        string Valor_Nota = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "NOTAF", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);

                                        if (Campo1.ToString() == "NR_TICKET")
                                        {
                                            texto += Espaco.PadLeft(Recui1, ' ') + " Nota Nr.: " + Valor_Nota.PadLeft(8, '0') + "\r\n";
                                            break;
                                        }

                                        string codigo_cliente = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_CLIFOR", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                        if (Campo1.ToString() == "NOME")
                                        {
                                            string nome_cliente = "Nome ......:" + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "NOME", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui1, ' ') + nome_cliente + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "ENDERECO")
                                        {
                                            string Endereco_cliente = "Endereço ...: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "ENDERECO", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui1, ' ') + Endereco_cliente + "\r\n";

                                            break;
                                        }
                                        if (Campo1.ToString() == "CIDADE")
                                        {
                                            string Cidade_cliente = "Cidade ....: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "CIDADE", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui1, ' ') + Cidade_cliente + "";
                                            string Cep_cliente = "Cep ...: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "CEP", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui2, ' ') + Cep_cliente + "";
                                            string Uf_cliente = "UF .: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "ESTADO", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui3, ' ') + Uf_cliente + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "CNPJ_CPF")
                                        {
                                            string Cnpj_cliente = "CNPJ ....: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "CNPJ_CPF", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui1, ' ') + Cnpj_cliente + "";
                                            string InscEst_cliente = "Insc. Estadual..: " + Funcoes.Operacoes.CapturaCampoTabela(2, "CLIFORN", "INSTEST", "ID_CLIFORN", codigo_cliente.ToString());
                                            texto += Espaco.PadLeft(Recui2, ' ') + InscEst_cliente + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "ID_PESAGEM")
                                        {
                                            texto += Espaco.PadLeft(Recui1, ' ') + "Seq...: " + Funcoes.Validacoes.valorTicket.ToString().PadLeft(8, '0') + "";
                                            string Nome_impressao = "Prod..:" + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "NOME_IMPRESSAO", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + Nome_impressao + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "DATA_SAIDA")
                                        {
                                            string Data_Saida = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "DATA_SAIDA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui1, ' ') + "Data : " + Data_Saida.Substring(0, 10) + "";
                                            string P_Bruto = "P.Bruto : " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_BRUTO", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + P_Bruto + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "HORA_SAIDA")
                                        {
                                            string Hora_Saida = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "DATA_SAIDA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui1, ' ') + "Hora : " + Convert.ToDateTime(Hora_Saida).ToLongTimeString();//.ToString("hh:mm:ss") + "";
                                            string Peso_tara = "Tara ..: " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_TARA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + Peso_tara + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "PLACA")
                                        {
                                            string Placa = "Placa ..: " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PlacaCarreta", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui1, ' ') + Placa.ToString() + "";
                                            string Peso_liq = "P.Liq ..:" + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "PESO_LIQ", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + Peso_liq + "\r\n";
                                            break;
                                        }
                                        if (Campo1.ToString() == "TRANSPORTADORA")
                                        {
                                            string CodTransportadora = "Transp..: " + Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_TRANSPORTADORA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            string NomeTransportadora = Funcoes.Operacoes.CapturaCampoTabela(1, "TRANSPORTADORA", "NOME", "ID_TRANSPORTADORA", Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "ID_TRANSPORTADORA", "ID_PESAGEM", Funcoes.Validacoes.valorTicket));
                                            texto += Espaco.PadLeft(Recui1, ' ') + NomeTransportadora.ToString() + "";
                                            string Obs = Funcoes.Operacoes.CapturaCampoTabela(1, "PESAGENS", "OBS_S", "ID_PESAGEM", Funcoes.Validacoes.valorTicket);
                                            texto += Espaco.PadLeft(Recui2, ' ') + Obs + "\r\n";
                                            break;
                                        }



                                    }
                                }

                            }
                            i1 = i1 + 1;
                            ContadorLinha = ContadorLinha + 1;
                            ValorLinha = ValorLinha + 1;
                        }

                    }
                    return texto;
                }





            }
            catch
            {
                return "";
            }
     }
        public static Array VerificaGrupoPesoEixo(string Seq_Eixo)
        {
            Seq_Eixo = Seq_Eixo.ToString().Replace("-", "");
            int TamanhoTexto = Convert.ToInt16(Seq_Eixo.ToString().Length);
            
            int[] myArray = new int[TamanhoTexto];


            for (int i = 0; i < TamanhoTexto; i++)
            {
                myArray[i]= Convert.ToInt16(Seq_Eixo.ToString().Substring(i, 1));
            }



            
            return myArray;
        
        }
        public static String ProcuraCampoTabela(int OPERACAO,string TABELA,string CAMPOSELECAO,string CAMPO,string CODIGO,string PROCEDURE)
        {
            String ValorRetorno="";
            try
            {
                string sProc = PROCEDURE;
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                       
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Int);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO;
                        oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                        oCmd.Parameters["@TABELA"].Value = TABELA;
                        oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSELECAO;
                        oCmd.Parameters.Add("@CAMPO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPO"].Value = CAMPO;
                        oCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar);
                        oCmd.Parameters["@CODIGO"].Value = CODIGO;
                        
                        oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();
                        
                        while (dr.Read())
                        {
                               ValorRetorno=dr.GetValue(0).ToString();

                        }
                    }
                    return ValorRetorno;
                }
            }
            catch
            {
                return "";
            }
        }

        public static ListView CarregaGrade(int OPERACAO, String TABELA, string CAMPOSSELECAO, string CAMPO, string CODIGO,ListView Lista,  string PROCEDURE)
        {
            try
            {
                string sProc = PROCEDURE;
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        Lista.Clear();
                        int tamanho = 0;
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Int);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO;
                        oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                        oCmd.Parameters["@TABELA"].Value = TABELA;
                        oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSSELECAO;
                        oCmd.Parameters.Add("@CAMPO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPO"].Value = CAMPO;
                        oCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar);
                        oCmd.Parameters["@CODIGO"].Value = CODIGO;


                        oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();

                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = dr.GetName(i);
                            tamanho = Convert.ToInt32(ch.Text.Length.ToString());
                            tamanho = tamanho * 10;
                            //joga padrão



                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.String")
                            {
                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Left);
                            }
                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Decimal" || dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Int32")
                            {
                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Right);
                            }
                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.String" &&
                                dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Decimal" &&
                                dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Int32")
                            {

                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Left);
                            }


                        }
                        ListViewItem item;
                        bool ZEBRADO = true;
                        int i1 = 0;
                        while (dr.Read())
                        {
                            item = new ListViewItem();
                            item.Text = dr.GetValue(0).ToString();
                            //preenche o listview com itens
                            for (int i =1; i < dr.FieldCount; i++)
                            {
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.String")
                                {
                                    item.SubItems.Add(dr.GetValue(i).ToString());
                                }
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Decimal")
                                {
                                    string Formato1 = String.Format("{0:#,###,###,##0.00}", Convert.ToDouble(dr.GetValue(i).ToString()));
                                   // Formato1 = String.Format("{0:#,###,###,##000}", Convert.ToDouble(dr.GetValue(i).ToString()));
                                    item.SubItems.Add(Formato1.ToString());
                                }
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.String" &&
                                    dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Decimal" &&
                                    dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Int32")
                                {

                                    item.SubItems.Add(dr.GetValue(i).ToString());
                                }
                               
                            }
                                Lista.Items.Add(item);
                                if (ZEBRADO == true)
                                {
                                    Lista.Items[i1].BackColor = Color.LightBlue;
                                    ZEBRADO = false;
                                }
                                else
                                {
                                    ZEBRADO = true;
                                }
                                i1 = i1 + 1;
                        }
                        }
                        return (Lista);
                  
                }
            }
            catch (Exception Erro)
            {
                var ERRO = Erro;
                return (Lista);
            }
        }

        public static ListView CarregaGradeTransacao(String FILTRO,ListView Lista, string PROCEDURE)
        {
            try
            {
                string sProc = PROCEDURE;
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        Lista.Clear();
                        int tamanho = 0;
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@FILTRO", SqlDbType.VarChar);
                        oCmd.Parameters["@FILTRO"].Value = FILTRO;
                        
                        oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();

                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = dr.GetName(i);
                            tamanho = Convert.ToInt32(ch.Text.Length.ToString());
                            tamanho = tamanho * 10;
                            //joga padrão



                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.String")
                            {
                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Left);
                            }
                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Decimal" || dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Int32")
                            {
                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Right);
                            }
                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.String" &&
                                dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Decimal" &&
                                dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Int32")
                            {

                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Left);
                            }


                        }
                        ListViewItem item;
                        bool ZEBRADO = true;
                        int i1 = 0;
                        while (dr.Read())
                        {
                            item = new ListViewItem();
                            item.Text = dr.GetValue(0).ToString();
                            //preenche o listview com itens
                            for (int i = 1; i < dr.FieldCount; i++)
                            {
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.String")
                                {
                                    item.SubItems.Add(dr.GetValue(i).ToString());
                                }
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Decimal")
                                {
                                    string Formato1 = String.Format("{0:#,###,###,##0.00}", Convert.ToDouble(dr.GetValue(i).ToString()));
                                    // Formato1 = String.Format("{0:#,###,###,##000}", Convert.ToDouble(dr.GetValue(i).ToString()));
                                    item.SubItems.Add(Formato1.ToString());
                                }
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.String" &&
                                    dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Decimal" &&
                                    dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Int32")
                                {

                                    item.SubItems.Add(dr.GetValue(i).ToString());
                                }

                            }
                            Lista.Items.Add(item);
                            if (ZEBRADO == true)
                            {
                                Lista.Items[i1].BackColor = Color.LightBlue;
                                ZEBRADO = false;
                            }
                            else
                            {
                                ZEBRADO = true;
                            }
                            i1 = i1 + 1;
                        }
                    }
                    return (Lista);

                }
            }
            catch (Exception Erro)
            {
                var ERRO = Erro;
                return (Lista);
            }
        }
        public static ListView CarregaSomaTransacaoReceita(String FILTRO, ListView Lista, string PROCEDURE)
        {
            try
            {
                string sProc = PROCEDURE;
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        Lista.Clear();
                        int tamanho = 0;
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@FILTRO", SqlDbType.VarChar);
                        oCmd.Parameters["@FILTRO"].Value = FILTRO;

                        oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();

                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = dr.GetName(i);
                            tamanho = Convert.ToInt32(ch.Text.Length.ToString());
                            tamanho = tamanho * 10;
                            //joga padrão



                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.String")
                            {
                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Left);
                            }
                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Decimal" || dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Int32")
                            {
                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Right);
                            }
                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.String" &&
                                dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Decimal" &&
                                dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Int32")
                            {

                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Left);
                            }


                        }
                        ListViewItem item;
                        bool ZEBRADO = true;
                        int i1 = 0;
                        while (dr.Read())
                        {
                            item = new ListViewItem();
                            item.Text = dr.GetValue(0).ToString();
                            //preenche o listview com itens
                            for (int i = 1; i < dr.FieldCount; i++)
                            {
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.String")
                                {
                                    item.SubItems.Add(dr.GetValue(i).ToString());
                                }
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Decimal")
                                {
                                    string Formato1 = String.Format("{0:#,###,###,##0.00}", Convert.ToDouble(dr.GetValue(i).ToString()));
                                    // Formato1 = String.Format("{0:#,###,###,##000}", Convert.ToDouble(dr.GetValue(i).ToString()));
                                    item.SubItems.Add(Formato1.ToString());
                                }
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.String" &&
                                    dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Decimal" &&
                                    dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Int32")
                                {

                                    item.SubItems.Add(dr.GetValue(i).ToString());
                                }

                            }
                            Lista.Items.Add(String.Format("{0:#,###,###,##0.00}", Convert.ToDouble(item.Text)));
                            if (ZEBRADO == true)
                            {
                                Lista.Items[i1].BackColor = Color.LightBlue;
                                ZEBRADO = false;
                            }
                            else
                            {
                                ZEBRADO = true;
                            }
                            i1 = i1 + 1;
                        }
                    }
                    return (Lista);

                }
            }
            catch (Exception Erro)
            {
                var ERRO = Erro;
                return (Lista);
            }
        }

        public static ListView CarregaGradeOrdem(int OPERACAO, String TABELA, string CAMPOSSELECAO, 
                                                string CAMPO, string CODIGO, ListView Lista, string PROCEDURE)
        {
            try
            {
                string sProc = PROCEDURE;
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        Lista.Clear();
                        int tamanho = 0;
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Int);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO;
                        oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                        oCmd.Parameters["@TABELA"].Value = TABELA;
                        oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSSELECAO;
                        oCmd.Parameters.Add("@CAMPO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPO"].Value = CAMPO;
                        oCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar);
                        oCmd.Parameters["@CODIGO"].Value = CODIGO;
                       
                        oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();

                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = dr.GetName(i);
                            tamanho = Convert.ToInt32(ch.Text.Length.ToString());
                            tamanho = tamanho * 10;
                            //joga padrão



                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.String")
                            {
                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Left);
                            }
                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Decimal" || dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Int32")
                            {
                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Right);
                            }
                            if (dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.String" &&
                                dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Decimal" &&
                                dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Int32")
                            {

                                Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Left);
                            }


                        }
                        ListViewItem item;
                        bool ZEBRADO = true;
                        int i1 = 0;
                        while (dr.Read())
                        {
                            item = new ListViewItem();
                            item.Text = dr.GetValue(0).ToString();
                            //preenche o listview com itens
                            for (int i = 1; i < dr.FieldCount; i++)
                            {
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.String")
                                {
                                    item.SubItems.Add(dr.GetValue(i).ToString());
                                }
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() == "System.Decimal")
                                {
                                    string Formato1 = String.Format("{0:#,###,###,##0.00}", Convert.ToDouble(dr.GetValue(i).ToString()));
                                    // Formato1 = String.Format("{0:#,###,###,##000}", Convert.ToDouble(dr.GetValue(i).ToString()));
                                    item.SubItems.Add(Formato1.ToString());
                                }
                                if (dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.String" &&
                                    dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Decimal" &&
                                    dr.GetFieldType(i).UnderlyingSystemType.ToString() != "System.Int32")
                                {

                                    item.SubItems.Add(dr.GetValue(i).ToString());
                                }

                            }
                            Lista.Items.Add(item);
                            if (ZEBRADO == true)
                            {
                                Lista.Items[i1].BackColor = Color.LightBlue;
                                ZEBRADO = false;
                            }
                            else
                            {
                                ZEBRADO = true;
                            }
                            i1 = i1 + 1;
                        }
                    }
                    return (Lista);

                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.ToString(), "Atenção");
                return (Lista);
            }
        }

        public static ListView CarregaGrade2Tabelas(int OPERACAO, string CAMPOID,string TABELA1, string TABELA2, string CAMPOSSELECAO, string CAMPO, string CODIGO, ListView Lista, string PROCEDURE)
        {
            try
            {
                string sProc = PROCEDURE;
                using (SqlConnection oCn = new SqlConnection(conexaoprincipal.StrConexao))
                {
                    using (SqlCommand oCmd = new SqlCommand(sProc, oCn))
                    {
                        Lista.Clear();
                        int tamanho = 0;
                        oCn.Open();
                        oCmd.CommandType = CommandType.StoredProcedure;
                        oCmd.Parameters.Add("@OPERACAO", SqlDbType.Int);
                        oCmd.Parameters["@OPERACAO"].Value = OPERACAO;
                        oCmd.Parameters.Add("@TABELA", SqlDbType.VarChar);
                        oCmd.Parameters["@TABELA"].Value = TABELA1;
                        oCmd.Parameters.Add("@CAMPOSELECAO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPOSELECAO"].Value = CAMPOSSELECAO;
                        oCmd.Parameters.Add("@CAMPO", SqlDbType.VarChar);
                        oCmd.Parameters["@CAMPO"].Value = CAMPO;
                        oCmd.Parameters.Add("@CODIGO", SqlDbType.VarChar);
                        oCmd.Parameters["@CODIGO"].Value = CODIGO;

                        oCmd.ExecuteNonQuery();
                        SqlDataReader dr = oCmd.ExecuteReader();

                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = dr.GetName(i);
                            tamanho = Convert.ToInt32(ch.Text.Length.ToString());
                            tamanho = tamanho * 10;
                            //joga padrão
                            Lista.Columns.Add(ch.Text, tamanho, HorizontalAlignment.Left);

                        }
                        ListViewItem item;
                        bool ZEBRADO = true;
                        int i1 = 0;
                        while (dr.Read())
                        {
                            item = new ListViewItem();
                            item.Text = dr.GetValue(0).ToString();
                            //preenche o listview com itens
                            for (int i = 1; i < dr.FieldCount; i++)
                            {
                                item.SubItems.Add(dr.GetValue(i).ToString());

                            }
                            Lista.Items.Add(item);
                            if (ZEBRADO == true)
                            {
                                Lista.Items[i1].BackColor = Color.LightYellow;
                                ZEBRADO = false;
                            }
                            else
                            {
                                ZEBRADO = true;
                            }
                            i1 = i1 + 1;
                        }
                    }
                    return (Lista);
                }
            }
            catch
            {
                return (Lista);
            }
        }


        public class ParametrosLabel
        {
            private Label label;
            private Form formPai;

            public ParametrosLabel(Label label1, Form formPai1)
            {
                this.label = label1;
                this.formPai = formPai1;
            }

            public void DefineTexto(String texto)
            {
                try
                {
                    // Verifica se o método está rodando numa thread diferente
                    // daquela que criou o controle.
                    if (label.InvokeRequired)
                    {
                        // A thread é diferente
                        DefineTextoCallback c = new DefineTextoCallback(this.DefineTextoLocal);
                        //this.Invoke(c, new object[] { texto, label });
                        this.formPai.Invoke(c, new object[] { texto });
                    }
                    else
                    {
                        // É a mesma thread
                        this.DefineTextoLocal(texto);
                    }
                }
                catch
                {
                }
            }



            private delegate void DefineTextoCallback(String texto);

            private void DefineTextoLocal(String texto)
            {
                this.label.Text = texto;
                this.label.Visible = true;
            }

            public void DefineCorLetra(Color cor)
            {
                try
                {
                    // Verifica se o método está rodando numa thread diferente
                    // daquela que criou o controle.
                    if (this.label.InvokeRequired)
                    {
                        // A thread é diferente
                        DefineCorLetraCallback c = new DefineCorLetraCallback(this.DefineCorL);
                        this.formPai.Invoke(c, new object[] { cor });
                    }
                    else
                    {
                        // É a mesma thread
                        this.DefineCorL(cor);
                    }
                }
                catch
                {
                }
            }

            private delegate void DefineCorLetraCallback(Color cor);

            private void DefineCorL(Color cor)
            {
                this.label.ForeColor = cor;
            }

            public void DefineCorFundo(Color cor)
            {
                try
                {
                    // Verifica se o método está rodando numa thread diferente
                    // daquela que criou o controle.
                    if (this.label.InvokeRequired)
                    {
                        // A thread é diferente
                        DefineCorFundoCallback c = new DefineCorFundoCallback(this.DefineCorF);
                        this.formPai.Invoke(c, new object[] { cor });
                    }
                    else
                    {
                        // É a mesma thread
                        this.DefineCorF(cor);
                    }
                }
                catch
                {
                }
            }

            private delegate void DefineCorFundoCallback(Color cor);

            private void DefineCorF(Color cor)
            {
                this.label.BackColor = cor;
            }
        }
    }
    
}
