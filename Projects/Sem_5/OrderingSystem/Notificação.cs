using System;
namespace OrderingSystem
{
    public abstract class Notificação : Inot
    {
        public abstract void Enviar(string mensagem);
    }

    class Email : Notificação
    {
        public override void Enviar(string mensagem)
        {
            Console.WriteLine("Enviando email: " + mensagem);
        }
    }

    class SMS : Notificação
    {
        public override void Enviar(string mensagem)
        {
            Console.WriteLine("Enviando SMS: " + mensagem);
        }
    }
}