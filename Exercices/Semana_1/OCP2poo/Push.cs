using System;
namespace OCP2poo
{
    class Push : Notificacao, Inot
    {
        public Push(string msg) : base(msg)
        {
        }

        public override void Enviar(string msg)
        {
            Console.WriteLine($"Enviando notificação por push: {msg}");
        }
    }
}