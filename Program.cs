using System;
using System.Collections.Generic;


namespace Tarefa5
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret1 = new Retangulo(2, 4);
            Retangulo ret2 = new Retangulo(4, 8);
            Retangulo ret3 = new Retangulo(3, 5);
            Retangulo ret4 = new Retangulo(8, 3);
            Retangulo ret5 = new Retangulo(6, 7);

            List<Retangulo> Figuras = new List<Retangulo>
            {
                ret1,
                ret2,
                ret3,
                ret4,
                ret5
            };

            int i = 1;
            foreach (var elemento in Figuras)
            {
                Console.WriteLine("Retangulo {0}", i);
                Console.WriteLine("Área =\t\t {0:0.0}", elemento.Area);
                Console.WriteLine("Perímetro =\t {0:0.0}", elemento.Perimetro);
                Console.WriteLine("-------------------------------------------");
                i++;
            }
        }
    }
}
