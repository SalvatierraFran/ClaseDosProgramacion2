using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseDosProgramacion2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora.Sumar(5, 5);
            //Calculadora.Restar(10, 8);
            //Calculadora.Multiplicar(5, 6);
            //Calculadora.Dividir(6, 0);

            //Console.Write(Calculadora.ValidarSiEsDistintoACero(0));

            Console.WriteLine("Menu de calculadora");
            Console.WriteLine("1.Suma\n2.resta\n3.Multiplicacion\n4.Division");

            Calculadora.Calcular(5, 6, "4");

            Console.WriteLine(Calculadora.Mayor(5, 6, 8));

            Console.ReadKey();
        }
    }
}
