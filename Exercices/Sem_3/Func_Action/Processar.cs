using System;
namespace Func_Action
{
    public class Processar
    {
       public void ProcessarConv(int valor, Func<double, double> calc, Action<double> exibir)
       {
           exibir(calc(valor));
       }
    }
}