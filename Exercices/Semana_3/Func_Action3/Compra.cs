using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Func_Action3
{
    class Compra
    {
        public void FinalizarCompra(double valorOrg, Func<double, double> desconto, Action<double> exibir)
        {
          exibir(desconto(valorOrg));
        }
    }
}