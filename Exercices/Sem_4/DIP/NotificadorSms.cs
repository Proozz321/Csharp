using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface INotificadorService
    {
        void EnviarNotificacion(string mensagem);
    }

    public class NotificadorSms : INotificadorService
    {
        public void EnviarNotificacion(string mensagem)
        {
            Console.WriteLine($"Enviando SMS: {mensagem}");
        }
    }

    public class NotificadorEmail : INotificadorService
    {
        public void EnviarNotificacion(string mensagem)
        {
            Console.WriteLine($"Enviando Email: {mensagem}");
        }
    }

    public class PedidoProcessador
    {
        private INotificadorService _notificador;

        public PedidoProcessador(INotificadorService notificador)
        {
            _notificador = notificador;
        }

        public void FinalizarPedido()
        {
            // Lógica para finalizar o pedido
            Console.WriteLine("Pedido finalizado.");

            // Enviar notificação
            _notificador.EnviarNotificacion("Seu pedido foi finalizado com sucesso!");
        }
    }
}