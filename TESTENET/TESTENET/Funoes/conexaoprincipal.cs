using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using db = System.Data.OleDb;
using System.Data.SqlClient;

namespace TESTENET
{

    class conexaoprincipal
    {
        protected static string StrConexaoDados;
        public static string StrConexao
        {
            get
            {
                String SERVIDOR = "";
                String TIPOBANCO = "";
                String DATABASE = "";
                String BALANCA = "";
                String EMPRESA = "";
                String CNPJ = "";
                String ENDERECO_EMPRESA = "";
                String FORMATODATA = "";
                String TIPOCONEXAO = "";

                SaveFileDialog sfDia1 = new SaveFileDialog();
                string dirAtual = Directory.GetCurrentDirectory();
                sfDia1.FileName = dirAtual +"\\Config.cfg";
                System.IO.StreamReader sr = new
                System.IO.StreamReader(sfDia1.FileName);

                //===================================================//
                //                  DADOS DA EMPRESA                 //
                //===================================================//
                EMPRESA = (sr.ReadLine());
                EMPRESA = EMPRESA.ToString().Replace(";", "");
                EMPRESA = EMPRESA.ToString().Substring(10);
                Funcoes.Validacoes.EmpresaCadastrada = EMPRESA;
                /*---------------------------------------------------*/
                CNPJ = (sr.ReadLine());
                CNPJ = CNPJ.ToString().Replace(";", "");
                CNPJ = CNPJ.ToString().Substring(7);
                Funcoes.Validacoes.CnpjEmpresaCadastrada = CNPJ;
                /*---------------------------------------------------*/
                ENDERECO_EMPRESA = (sr.ReadLine());
                ENDERECO_EMPRESA = ENDERECO_EMPRESA.ToString().Replace(";", "");
                ENDERECO_EMPRESA = ENDERECO_EMPRESA.ToString().Substring(19);
                Funcoes.Validacoes.EnderecoEmpresaCadastrada = ENDERECO_EMPRESA;
                /*---------------------------------------------------*/
                SERVIDOR = (sr.ReadLine());
                SERVIDOR = SERVIDOR.ToString().Replace(";", "");
                SERVIDOR = SERVIDOR.ToString().Substring(11);
                Funcoes.Validacoes.NomeServidor = SERVIDOR;
                /*---------------------------------------------------*/
                TIPOBANCO = (sr.ReadLine());
                TIPOBANCO = TIPOBANCO.ToString().Replace(";", "");
                TIPOBANCO = TIPOBANCO.ToString().Substring(12);
                /*---------------------------------------------------*/
                DATABASE = (sr.ReadLine());
                DATABASE = DATABASE.ToString().Replace(";", "");
                DATABASE = DATABASE.ToString().Substring(11);
                /*---------------------------------------------------*/
                FORMATODATA = (sr.ReadLine());
                FORMATODATA = FORMATODATA.ToString().Replace(";", "");
                FORMATODATA = FORMATODATA.ToString().Substring(14);
                Funcoes.Validacoes.FormatoData = FORMATODATA;
                /*---------------------------------------------------*/
                TIPOCONEXAO = (sr.ReadLine());
                TIPOCONEXAO = TIPOCONEXAO.ToString().Replace(";", "");
                TIPOCONEXAO = TIPOCONEXAO.ToString().Substring(14);
             

                Funcoes.Validacoes.NomeBancoDados = DATABASE.ToString().Replace("\t","");
                Funcoes.Validacoes.IdBalanca = BALANCA.ToString();

                /*---------------------------------------------------*/
                StrConexaoDados = "Data Source=" + SERVIDOR + "; Initial Catalog=" + DATABASE + ";PWD=mhs491624;Persist Security Info=True;User ID=USER_PRINCIPAL";

                StrConexaoDados = StrConexaoDados.Replace("\t", "");
                return StrConexaoDados;
            }
            set
            {
                StrConexaoDados = value;
            }

        }
    }
}
