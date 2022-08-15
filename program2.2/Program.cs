using System;

namespace program2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nota promedio");
            double nota = double.Parse(Console.ReadLine());
            if (nota >= 0 && nota <= 10)


                if (nota >= 6)
                    Console.WriteLine("Aprobado");


                else if (nota >= 5)
                    Console.WriteLine("Reposicion");
                else
                    Console.WriteLine("Reprobado");

            else
                Console.WriteLine("Nota invalida");
            ;
        }
    }
}
