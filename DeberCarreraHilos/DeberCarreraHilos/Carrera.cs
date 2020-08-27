using System;
using System.Threading;

namespace DeberCarreraHilos
{
    class Carrera
    {
        public static void Participante1()
        {
            int p = 0;
            while (p <= 10)
            {
                Random rnd = new Random();
                Console.WriteLine(" | a |   |   |   |   |");
                p += 1;
                Thread.Sleep(1000);
            }
        }
        public static void Participante2()
        {
            int p = 0;
            while (p <= 10)
            {
                Random rnd = new Random();
                Console.WriteLine(" |   | b |   |   |   |");
                p += 1;
                Thread.Sleep(1000);
            }
        }
        public static void Participante3()
        {
            int p = 0;
            while (p <= 10)
            {
                Random rnd = new Random();
                Console.WriteLine(" |   |   | c |   |   |");
                p += 1;
                Thread.Sleep(1000);
            }
        }
        public static void Participante4()
        {
            int p = 0;
            while (p <= 10)
            {
                Random rnd = new Random();
                Console.WriteLine(" |   |   |   | d |   |");
                p += 1;
                Thread.Sleep(1000);
            }
        }
        public static void Participante5()
        {
            int p = 0;
            while (p <= 10)
            {
                Random rnd = new Random();
                Console.WriteLine(" |   |   |   |   | e |");
                p += 1;
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Empieza la carrera");

            Thread competidor1 = new Thread(new ThreadStart(Participante1));
            Thread competidor2 = new Thread(new ThreadStart(Participante2));
            Thread competidor3 = new Thread(new ThreadStart(Participante3));
            Thread competidor4 = new Thread(new ThreadStart(Participante4));
            Thread competidor5 = new Thread(new ThreadStart(Participante5));

            competidor1.Start();
            competidor2.Start();
            competidor3.Start();
            competidor4.Start();
            competidor5.Start();
        }
    }
} 

