using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBecaMatriz;

namespace BecaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diego esteve aqui
            int[,] matriz = new int[3,3];
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;
            matriz[2, 0] = 7;
            matriz[2, 1] = 8;
            matriz[2, 2] = 9;


            CalculadoraMatriz calc = new CalculadoraMatriz();
            calc.MostrarMatriz_Diego(matriz);
            
            int resultado = calc.CalcularMatrizPrincipal_Diego(matriz);
            Console.WriteLine($"CALCULO MATRIZ PRINCIPAL: {resultado}");
            Console.Read();
        }
    }
}
