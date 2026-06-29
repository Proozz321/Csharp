using System;

namespace RPGpoo
{
    public class Arqueiro : Personagem, IAtacavel
    {
       public Arqueiro(string nome, int vidaMax, int nivel): base(nome, vidaMax, nivel)
       {
       }

       public override int calcularDano(){
            return new Random().Next(20, 41);
       }
    }
    
}