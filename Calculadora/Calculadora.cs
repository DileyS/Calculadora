using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            //Quando digitamos um numero no console, ele entrara como string mas na conversao ele voltaram como um numero inteiro.
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            int resultado = 0;

            switch (operacao)
            {
                //Como se fosse uma condicao se o usuario digitar "1" que seria Adicao, o que sera exibido sera a soma dos dois numeros.
                case 1:
                    {   //Se o usuario digita 1 o resultado sera o metodo "Adicao" que e "num1 + num2".
                        Console.WriteLine("Adição:");
                        Console.WriteLine("=============");
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {   
                        resultado = Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                //caso nao seja nenhum numero de 1 a 4 
                default:
                    Console.WriteLine("Numero invalido, digite outro numero.");
                    break;
            }
            //Quando e colocado um numero dentro da {} e exibido a variavel declarada no fim da condicao.
            Console.WriteLine("O resultado da operacao com os numeros {0} e {1} é: {2}", num1, num2, resultado);
            Console.ReadLine();
        }
        //Metodo novo nao tem nada haver com o metodo de cima.
        //Metodos somente usados para retornar os valores e as operacoes solicitadas no exercicio.
        public static int Adicao (int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        public static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }
}