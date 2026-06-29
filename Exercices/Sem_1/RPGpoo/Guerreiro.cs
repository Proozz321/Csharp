using System;

namespace RPGpoo
{
    public class Guerreiro : Personagem, IAtacavel
    {
       public Guerreiro(string nome, int vidaMax, int nivel): base(nome, vidaMax, nivel)
       {
       }

       public override int calcularDano(){
          
            return new Random().Next(15, 36);
       }
    }
    
}