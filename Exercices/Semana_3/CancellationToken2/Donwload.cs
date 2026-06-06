using System;
using System.Threading.Tasks;
namespace CancellationToken2
{
    class Donwload
    {
        public string Nome { get; set; }
        public int Tempo { get; set; }

        public Donwload(string nome, int tempo)
        {
            this.Nome = nome;
            this.Tempo = tempo;
        }

        public async Task<string> StartDownload(string nome, int tempo, CancellationToken token, CancellationTokenSource ctsErro)
        {
            try
            {
                Console.WriteLine($"Iniciando {nome}...");
                await Task.Delay(tempo, token);

                if(nome == "Corrompido") 
                    throw new Exception("Erro na Conexão!");

                return $"Sucesso: {nome}";
            }
            catch (Exception)
            {
                // Se der erro, cancela TUDO automaticamente
                ctsErro.Cancel();
                throw; // Repassa a exceção para o Main capturar
            }
        }
    }
}