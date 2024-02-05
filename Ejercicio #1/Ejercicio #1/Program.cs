// See https://aka.ms/new-console-template for more information

//Ubaldo Antonio Bermúdez Carrera

using System;

class Program
{
    static void Main(string[] args)

    {
        // Se crea una matriz de enteros de 5x5.
        int[,] matriz = new int[5,5];


        // Bucle externo que itera a través de las filas de la matriz.
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            // Bucle externo que itera a través de las columnas de la matriz.
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                // Se solicita al usuario que introduzca un valor para la posición [i, j] de la matriz.
                Console.WriteLine("Introduzca el valor para la fila {0} y columna {1}:", i + 1, j + 1);
                // Se lee la entrada del usuario y se almacena en la posición correspondiente de la matriz.
                matriz[i,j] = int.Parse(Console.ReadLine());
            }
        }
        // Se calcula la suma de las esquinas de la matriz.
        int sumaEsquinas = matriz[0, 0] + matriz[0, 4] + matriz[4, 0] + matriz[4, 4];
        // Se imprime el resultado de la suma de las esquinas.
        Console.WriteLine("La suma de la esquinas de la matriz es: {0}", sumaEsquinas);
    
    
    
    
    
    
    }


}