using System;
namespace OCP2poo
{
    abstract class Notificacao
    {
        public string Msg { get; set; }

        public Notificacao(string msg)
        {
            this.Msg = msg;
        }

        public abstract void Enviar(string msg);
    }
}