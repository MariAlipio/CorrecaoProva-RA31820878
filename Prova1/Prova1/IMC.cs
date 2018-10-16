using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    class IMC
    {
        private double peso;
        private double altura;

        //Construtores
        public IMC() { }
        public IMC(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        //Método que calcula o IMC
        public double Calcular(double peso, double altura)
        {
            return peso / (altura * altura);
            
        }

        public double Classificar(double imc)
        {
            return 0.0;
        }
    }
}
