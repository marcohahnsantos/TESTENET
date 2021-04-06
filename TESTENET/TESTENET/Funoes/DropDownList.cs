using System;
using System.Collections.Generic;
using System.Text;

namespace TESTENET.Funcoes
{
    public class drop
    {
        public drop(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
        string _nome;
        double _valor;
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
