using System;
namespace Func_Action2
{
    public class Validador
    {
       public void Validar(string dado, Func<string, bool> func, Action n, Action s)
       {
           if(func(dado))
           {
               n();
           }
           else
           {
               s();
           }
       }
    }
}