using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2_matrices
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el tamaño de la matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            Console.WriteLine("Ingrese los elementos de la matriz:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Elementos en las esquinas de la matriz:");

            Console.WriteLine("Esquina superior izquierda: " + matriz[0, 0]);
            Console.WriteLine("Esquina superior derecha: " + matriz[0, n - 1]);
            Console.WriteLine("Esquina inferior izquierda: " + matriz[n - 1, 0]);
            Console.WriteLine("Esquina inferior derecha: " + matriz[n - 1, n - 1]);

            Console.ReadLine();
        }
    }
}
