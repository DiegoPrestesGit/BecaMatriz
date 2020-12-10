using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibBecaMatriz
{
    public class CalculadoraMatriz
    {
        // Diego mostrando
        public void MostrarMatriz_Diego(int[,] matriz)
        {
            Console.WriteLine("-------------MATRIZ-------------");
            for (int i = 0; i <= matriz.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= matriz.GetUpperBound(1); j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        // Diego calculando
        public int CalcularMatrizPrincipal_Diego(int[,] matriz)
        {
            Console.WriteLine("-------------CALCULANDO MATRIZ PRINCIPAL-------------");
            int resultado = 0;
            for (int i = 0; i <= matriz.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matriz.GetUpperBound(1); j++)
                {
                    if (i == j)
                    {
                        resultado += matriz[i, j];
                    }
                }
            }
            return resultado;
        }
    }
}
