using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseDosProgramacion2_01
{
    class Calculadora
    {
        /// <summary>
        /// Este metodo debera sumar dos numeros.
        /// </summary>
        private static void Sumar(double Numero1, double Numero2)
        {
            double resultado;
            Console.Write("Estoy sumando. ");
            resultado = Numero1 + Numero2;
            Console.WriteLine("El resultado es " + resultado);
            //Console.ReadKey();
        }

        private static void Restar(double Numero1, double Numero2)
        {
            Console.Write("Estoy restando. ");
            double resultado;
            resultado = Numero1 - Numero2;
            Console.WriteLine("El resultado es " + resultado);
            //Console.ReadKey();
        }

        private static void Multiplicar(double Numero1, double Numero2)
        {
            Console.Write("Estoy multiplicando. ");
            double resultado;
            resultado = Numero1 * Numero2;
            Console.WriteLine("El resultado es " + resultado);
            //Console.ReadKey();
        }

        private static void Dividir(double Numero1, double Numero2)
        {
            if (Calculadora.ValidarSiEsDistintoACero(Numero2) == true)
            {
                Console.Write("Estoy dividiendo. ");
                double resultado;
                resultado = Numero1 / Numero2;
                Console.WriteLine("El resultado es " + resultado);
            }
            else
            {
                Console.WriteLine("0");
            }
            //Console.ReadKey();
        }

        private static bool ValidarSiEsDistintoACero(double NumeroUno)
        {
            bool rta;

            if (NumeroUno != 0)
            {
                rta = true;
            }
            else
            {
                rta = false;
            }

            return rta;
        }

        public static void Calcular(double NumeroUno, double NumeroDos, string Operacion)
        {

            switch (Operacion)
            {
                case "1":
                    Calculadora.Sumar(NumeroUno, NumeroDos);
                    Console.ReadKey();
                    break;

                case "2":
                    Calculadora.Restar(NumeroUno, NumeroDos);
                    Console.ReadKey();
                    break;

                case "3":
                    Calculadora.Multiplicar(NumeroUno, NumeroDos);
                    Console.ReadKey();
                    break;

                case "4":
                    Calculadora.Dividir(NumeroUno, NumeroDos);
                    Console.ReadKey();
                    break;
            }
        }

        public static double Mayor(double NumUno, double NumDos, double NumTres)
        {
            double max;

            if (NumUno > NumDos && NumUno > NumTres)
            {
                max = NumUno;
            }

            else if (NumDos > NumUno && NumDos > NumTres)
            {
                max = NumDos;
            }

            else
            {
                max = NumTres;
            }

            return max;
        }
    }
}
