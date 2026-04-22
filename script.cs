using System;

class Program
{
    static void Main(string[] args)
    

    {
        
        
        //Operations
        Console.WriteLine("Operações: \n Soma: + \t Subtração: - \t Multiplicação: x \t Divisão: /");
        
        // Loop infinito para permitir múltiplos cálculos
        while(true){
    
        // Array de sinais para verificar qual operação está presente na string de cálculo
        Console.WriteLine("\nCalculo: "); string calculo = Console.ReadLine().Replace(" ", ""); // Remove espaços em branco
        char[] sinais = { '+', '-', 'x', '/' };
        char sinal = ' ';


        // Verificar qual operação está presente na string de cálculo
        foreach(char op in sinais){ if(calculo.Contains(op)){ sinal = op; break;}}


        // Separa os numeros em n1 e n2 com base no sinal encontrado
        String[] conta = calculo.Split(sinal); 
        double n1 = double.Parse(conta[0]);
        double n2 = double.Parse(conta[1]);


        // Realizar a operação com base no sinal encontrado
        switch (sinal){
            case '+': Console.WriteLine("Resultado: " + (n1 + n2)); break;
            case '-': Console.WriteLine("Resultado: " + (n1 - n2)); break;
            case 'x': Console.WriteLine("Resultado: " + (n1 * n2)); break;
            case '/':
                if (n2 != 0){
                    Console.WriteLine("Resultado: " + (n1 / n2));
                }else{
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
            }
        }
    }
}
