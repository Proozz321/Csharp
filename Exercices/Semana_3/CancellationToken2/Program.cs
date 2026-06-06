using System;
using System.Threading.Tasks;
namespace CancellationToken2
{
    class Program
    {
        static async Task Main(string[] args)
        {
           // No seu Main:
            var ctsUsuario = new CancellationTokenSource();
            var ctsErro = new CancellationTokenSource();

            // Cria um token que cancela se QUALQUER UM dos dois for cancelado
            using var ctsLinkado = CancellationTokenSource.CreateLinkedTokenSource(ctsUsuario.Token, ctsErro.Token);

            var download1 = new Donwload("Arquivo1", 5000);
            var download2 = new Donwload("Corrompido", 2000);

            try 
            {
                // Inicia os dois simultaneamente
                await Task.WhenAll(
                    download1.StartDownload(download1.Nome, download1.Tempo, ctsLinkado.Token, ctsErro),
                    download2.StartDownload(download2.Nome, download2.Tempo, ctsLinkado.Token, ctsErro)
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro capturado: {ex.Message}");
            }
        }
    }
}