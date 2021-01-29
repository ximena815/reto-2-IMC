using System;

namespace reto2_tutoria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas peso y altura
            
            Console.WriteLine("Ingrese peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese altura: ");
            double altura = double.Parse(Console.ReadLine());

            //Proceso
            // IMC = Peso (kg) / altura (m)2
            double IMC = peso / ((altura) * (altura));
            Console.WriteLine("IMC: " + IMC);

            //Condicionales
            //Peso inferior a lo normal
            if (IMC <= 18.5)
            {
                Console.WriteLine("El peso es inferior a lo normal");
            }
            else if (18.5 <= IMC && IMC <= 24.9)
            {
                Console.WriteLine("El peso es normal");
            }
            else if (25.0 <= IMC && IMC <= 29.9)
            {
                Console.WriteLine("El peso superior al normal");
            }
            else if (IMC >= 30.0)
            {
                Console.WriteLine("Estas obeso ;3");
            }

        }
    }
}
