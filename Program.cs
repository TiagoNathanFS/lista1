using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String nome;
            int n1, n2, soma, subtracao, multiplicacao, divisao;
            Console.Write("informe sue nome:");
            nome = Console.ReadLine();
            Console.Write("Digite o primeiro numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero:");
            n2 = int.Parse(Console.ReadLine());
            
            soma = n1 + n2;
            subtracao = n1 - n2;
            divisao = n1 / n2;
            multiplicacao = n1 * n2;
            Console.Write(nome + " a soma de {0} e {1} é {2} \n",n1, n2, soma);
            Console.Write(nome + " a subtracao de {0} e {1} é {2} \n", n1, n2, subtracao);
            Console.Write(nome + " a multiplicacao de {0} e {1} é {2} \n", n1, n2, multiplicacao);
            Console.Write(nome + " a divisao de {0} e {1} é {2} \n", n1, n2, divisao);
            Console.ReadKey();


        }
    }
}
