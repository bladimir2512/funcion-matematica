using System;

namespace CalculadoraRaizCuadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para calcular su raíz cuadrada:");
            double numero = double.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine($"La raíz cuadrada de {numero} es: {raiz}");

                Console.WriteLine("\t");
            }

            else
            {
                Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
            }
 
           
            {
                Console.WriteLine("Ingrese los coeficientes de la ecuación ax^2 + bx + c = 0:");

                Console.WriteLine("\t");

                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("c: ");
                double c = double.Parse(Console.ReadLine());

                double discriminante = b * b - 4 * a * c;

                if (discriminante > 0)
                {
                    double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                    Console.WriteLine("\t");
                    Console.WriteLine($"Valores respectivos de X1 Y X2 : {raiz1} y {raiz2}");
                }
                else if (discriminante == 0)
                {
                    double raizUnica = -b / (2 * a);

                    Console.WriteLine("\t");
                    Console.WriteLine($"La raíz única es: {raizUnica}");
                }
                else
                {
                    Console.WriteLine("La ecuación no tiene soluciones reales.");
                    Console.ReadKey();
                }
            }
        }
    }

}
   
