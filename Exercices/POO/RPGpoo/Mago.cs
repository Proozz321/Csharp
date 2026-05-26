using System;

namespace RPGpoo
{
    public class Mago : Personagem, IAtacavel
    {
       public Mago(string nome, int vidaMax, int nivel)
          :base(nome, vidaMax, nivel)
       {
       }
       public override int calcularDano(){
            return new Random().Next(30, 51);
       }
    }
    
}