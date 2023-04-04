using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_Secuencial_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            int num = int.Parse(Console.ReadLine());

            if(num < 0)
            {
                Console.WriteLine("El número es negativo");
            }else if(num > 0)
            {
                Console.WriteLine("El número es positivo");
            }else if (num == 0)
            {
                Console.WriteLine("El número es 0");
            }
        }
    }
}
