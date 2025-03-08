using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Entidades
{
    class Lancamento
    {
        int id_lancamento;
        string tipo;
        string descricao;
        decimal valor;
        string mes;
        int ano;

        public int Id_lancamento { get => id_lancamento; set => id_lancamento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }
    }
}
