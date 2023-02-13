using System;
using System.Collections.Generic; //Representação de uma coleção somente leitura genérica de pares chave/valor.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        
        static void Main()
        {
            int num1, num2, resultado = 0;
            int operacao = 0;
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Resto da Divisão");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("0 - Sair \n");
           
            operacao = Convert.ToInt32(Console.ReadLine());
            switch (operacao)
            {
                //Como se fosse uma condicao se o usuario digitar "1" que seria Adicao, o que sera exibido sera a soma dos dois numeros.
                case 1:
                    {   //Se o usuario digita 1 o resultado sera o metodo "Adicao" que e "num1 + num2".
                        Console.WriteLine("Adição:");          
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Subtração:");                       
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Multiplicação:");                        
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Divisão:");                       
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Resto da Divisão:");                        
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Potenciação:");                       
                        break;
                    }
                case 0:
                    {
                        Console.WriteLine("Obrigado por utilizar nossa calculadora !");
                        break;
                    }
                //caso nao seja nenhum numero de 1 a 6 
                default:
                    Console.Clear();
                    Console.WriteLine("Numero invalido, digite outro numero.");
                    Console.WriteLine("=====================================");
                    Main();
                    break;
            }
            if (operacao == 1)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                resultado = num1 + num2;
                Console.WriteLine("===========================");
                Console.WriteLine("O resultado da operação foi de: {0}", resultado);
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }
            if (operacao == 2)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                resultado = num1 - num2;
                Console.WriteLine("===========================");
                Console.WriteLine("O resultado da operação foi de: {0}", resultado);
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }
            if (operacao == 3)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                resultado = num1 * num2;
                Console.WriteLine("===========================");
                Console.WriteLine("O resultado da operação foi de: {0}", resultado);
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }
            if (operacao == 4)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                if(num2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                    Console.WriteLine("===========================");
                    Console.WriteLine("Digite o segundo numero: ");
                    num2 = int.Parse(Console.ReadLine());
                }
                resultado = num1 / num2;
                Console.WriteLine("===========================");
                Console.WriteLine("O resultado da operação foi de: {0}", resultado);
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }
            if (operacao == 5)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                resultado = num1 % num2;
                Console.WriteLine("===========================");
                Console.WriteLine("O resultado da operação foi de: {0}", resultado);
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }
            if (operacao == 6)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("===========================");
                Console.WriteLine("Digite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                resultado = (int)Math.Pow(num1,num2);
                Console.WriteLine("===========================");
                Console.WriteLine("O resultado da operação foi de: {0}", resultado);
                Thread.Sleep(2000);
                Console.Clear();
                Main();
            }
        }
    }
}
