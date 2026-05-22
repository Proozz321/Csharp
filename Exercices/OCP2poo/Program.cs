using System;
namespace OCP2poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Notificacao sms = new Sms("Olá, isso é um SMS!");
            Notificacao whats = new Whats("Olá, isso é um WhatsApp!");
            Notificacao push = new Push("Olá, isso é um Push!");

            sms.Enviar(sms.Msg);
            whats.Enviar(whats.Msg);
            push.Enviar(push.Msg);
        }
    }
}