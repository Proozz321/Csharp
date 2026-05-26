using System;
namespace OCP2poo
{
    class Whats : Notificacao, Inot
    {
        public Whats(string msg) : base(msg)
        {
        }

        public override void Enviar(string msg)
        {
            Console.WriteLine($"Enviando notificação por whatsapp: {msg}");
        }
    }
}