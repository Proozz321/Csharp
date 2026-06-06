using System;
namespace OCP2poo
{
    class Sms : Notificacao, Inot
    {
        public Sms(string msg) : base(msg)
        {
        }

        public override void Enviar(string msg)
        {
            Console.WriteLine($"Enviando notificação por sms: {msg}");
        }
    }
}