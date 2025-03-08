using ControleGastos.Controllers;
using ControleGastos.Entidades;
using System.Collections.Generic;

namespace ControleGastos.Models
{
    public class AnoModel
    {
        public static int Inserir(Anos obj)
        {
            return new AnoControllers().Inserir(obj);
        }

        public List<Anos> Buscar(Anos obj)
        {
            return new AnoControllers().Buscar(obj);
        }

        public List<Anos> Listar()
        {
            return new AnoControllers().Listar();
        }
    }
}
