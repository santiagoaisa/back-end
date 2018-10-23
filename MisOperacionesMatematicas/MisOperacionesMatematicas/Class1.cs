using System;

namespace MisOperacionesMatematicas
{
    public class Profesor
    {

        public double sumar(double numero1, double numero2)
        {
            return numero1 + numero2;            
        }

        public double restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

        public double multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public double potencia(double numero1, double numero2)
        {
            return Math.Pow(numero1, numero2);
        }

        public double raiz(double numero1, double numero2)
        {
            return Math.Pow(numero1, 1 / numero2);
        }

        public double resto(double numero1, double numero2)
        {
            return numero1 % numero2;
        }

        public bool esPrimo(double numero1)
        {

            int conteo = 0;

            for (int i = 1; i <= numero1; i++)
            {

                if (numero1 % i == 0)
                {
                    conteo = conteo + 1;
                }

            }

            return conteo == 2;

        }

    }
}
