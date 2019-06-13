using System;

namespace QuatroOperacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            /*
            Vamos declarar 7 variáveis, sendo 2 para o usuário inserir dados e as outras serão para guardar os resultados */
            int numero1, numero2;
            int soma, subtrair, multiplicar, dividir, resto;
            
            //pedir ao usuário que entre o primeiro número 
            Console.WriteLine("Digite um número:");

            //  Vamos pegar o valor que o usuário digitou, e colocar na variavel número1
            // utilizamos o comando int.Parse para passar a captura de texto do Console.ReadLine em número. Mesmo sabendo que o usuário irá digitar um número, infelizmente o ReadLine sempre lê como texto
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número:");
            numero2 = int.Parse(Console.ReadLine());

            // Abixo iremos realizar as 5 operações aritiméticas
            soma = numero1 + numero2;
            subtrair = numero1 - numero2;
            dividir = numero1 / numero2;
            multiplicar = numero1 * numero2;
            resto = numero1 % numero2; 

            Console.WriteLine( "A soma é "+soma);
            Console.WriteLine("A subtração é "+subtrair);
            Console.WriteLine("A divisão é "+dividir);
            Console.WriteLine("A multiplicação é "+multiplicar);
            Console.WriteLine("O resto é "+resto);

    
        }
    }
}
