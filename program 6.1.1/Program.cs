using System;

namespace program_6._1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            Console.WriteLine("Introduzca un número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es" + Suma(num1, num2));
            Console.WriteLine("La resta es" + Resta(num1, num2));
            Console.WriteLine("La multiplicación es" + Multi(num1, num2));
            Console.WriteLine("La división es" + Div(num1, num2));
        }
        static int Suma(int num1, int num2)
        {
            var
                  suma = num1 + num2;
            return suma;


        }
        static int Resta(int num1, int num2)
        {
            var
                resta = num1 - num2;
            return resta;

        }
        static int Multi(int num1, int num2) => num1 * num2;
        static double Div(int num1, int num2)
        {
            double numd1 = Convert.ToDouble(num1);
            double numd2 = Convert.ToDouble(num2);
            return numd1 / numd2;
        }
    }
}






