using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Объем: ");
         double V = Convert.ToDouble(Console.ReadLine());
         double r = Math.Pow(0.75*V/Math.PI, 0.333);
         double S = 3*V/Math.Pow(0.75*V/Math.PI, 0.333);
         Console.Write("Радиус = " + r + "\n" + "Площадь = " + S);
         Console.ReadKey();
        }
    }
}