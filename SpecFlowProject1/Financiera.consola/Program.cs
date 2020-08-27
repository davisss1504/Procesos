using Calculos.Negocio;
using System;

namespace Financiera.consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.FirstNumber = 50;
            calculadora.SecondNumber = 70;

            int result = calculadora.suma();
            int result1 = calculadora.suma(60, 70);

            calculadora.PrimerNumero = 80;
            calculadora.SegundoNumero = 80;
            int resultadoE = calculadora.sumaE();
            int resultadoE1 = calculadora.sumaE(80, 90);

            Console.WriteLine($"La suma de {calculadora.FirstNumber} y de {calculadora.SecondNumber} es: {result}");
            Console.WriteLine($"La suma de 60 y de 70 es: {result1}");

            Console.WriteLine($"La suma de {calculadora.PrimerNumero} y de {calculadora.SegundoNumero} es: {resultadoE}");
            Console.WriteLine($"La suma de 80 y de 90 es: {resultadoE1}");

            Console.WriteLine("Algoritmo 'aprobación de una materia'");
            Aprobacion aprobacion = new Aprobacion();
            aprobacion.Estudiante = "David";
            aprobacion.Nota = 6;
            string resp = aprobacion.estado();
            Console.WriteLine($"El estudiante: {aprobacion.Estudiante} tiene la nota de: {aprobacion.Nota} y es: {resp}");
        }
    }
}
