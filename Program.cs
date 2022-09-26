using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_es01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2; 

            Console.WriteLine("A soma entre {0} e {1} é : {2}", n1, n2, soma);

            Console.ReadLine();

        }
    }
}
