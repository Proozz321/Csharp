using System;
namespace RPGpoo
{
    public abstract class Personagem{

        public string nome{ get; set;}
        public int vida{ get; set;}
        public int vidaMax{ get; set;}
        public int nivel{ get; set;}

        public Personagem(string nome, int vidaMax, int nivel)
        {
            this.nome = nome;
            this.vidaMax = vidaMax;
            this.vida = vidaMax;
            this.nivel = nivel;
        }

        public abstract int calcularDano();

        public void atacar(){
            int dano = calcularDano();
            Console.WriteLine($"{nome} causou {dano} de dano!");
        }
    
        public void receberDano(int dano)
        {
            vida -= dano;
            if (vida < 0)
            {
                vida = 0;
            }
        }

        public void exibir()
        {
            Console.WriteLine($"Personagem:===== {nome}======");
            Console.WriteLine($"Vida: {vida}/{vidaMax}");
            Console.WriteLine($"Nível: {nivel}");

        }
    }
}