using System;
namespace Eventos1
{
    
    public class Monitor
    {
        public event Action<int> Atemp;
        public void Verificar(int temp)
        {
            if(temp > 80){ Atemp?.Invoke(temp);}
            else{Console.WriteLine("Seguro");}
        }
    }
}