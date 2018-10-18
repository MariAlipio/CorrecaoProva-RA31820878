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
            //Exercicio 1
            //Console.WriteLine(Maior2(1, 2));

            //Exercicio 2
            //Console.WriteLine(Par1(2));
            //Console.ReadKey();

            //Exercicio 2

            IMC imc = new IMC();

            Console.WriteLine("Escreva seu peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu altura:");
            double altura = double.Parse(Console.ReadLine());

            double seuimc = imc.Calcular(peso, altura);

            Console.WriteLine("Seu IMC é:" + seuimc);
            Console.WriteLine("Sua classificação é:" + imc.Classificar(imc.Calcular(peso, altura)));
            Console.ReadKey();
        }


    }
}
