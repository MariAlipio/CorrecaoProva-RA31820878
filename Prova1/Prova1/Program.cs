using System;

namespace Prova1
{
    class Program
    {
        //Exercicio 1
        static int Maior(int A, int B)
        {
            if (A > B)
                return A;
            else
                return B;
        }
        //SEGUNDA FORMA
        static int Maior2(int A, int B)
        {
            return (A > B) ? A : B;
            // Operador ternario - : se sim retorna o primeiro senao retorna o segundo
        }
        //Exercicio 3
        static bool Par(int numero)
        {
            return (numero % 2 == 0) ? true : false;
        }

        //Para escrever se é par ou impar
        static string Par1(int numero)
        {
            return (numero % 2 == 0) ? "O numero é par" : "O numero é impar";
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Maior2(1, 2));

            //Console.WriteLine(Par1(2));
            Console.ReadKey();
        }


    }
}
