// See https://aka.ms/new-console-template for more information

//Ubaldo Bermúdez Carrera

using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables para almacenar el número de filas y columnas de la matriz.
        int filas, columnas;

        // Se solicita al usuario que introduzca el número de filas de la matriz y se almacena en la variable 'filas'.
        Console.WriteLine("Introduzca el número de filas de la matriz: ");
        filas = int.Parse(Console.ReadLine());

        // Se solicita al usuario que introduzca el número de columnas de la matriz y se almacena en la variable 'columnas'.
        Console.WriteLine("Introduzca el número de columnas de la matriz: ");
        columnas = int.Parse(Console.ReadLine());

        // Se crea una matriz de enteros con el número de filas y columnas especificado por el usuario.
        int[,] matriz = new int[filas, columnas];

        // Bucle externo que itera a través de las filas de la matriz.
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            // Bucle interno que itera a través de las columnas de la matriz.
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                // Se solicita al usuario que introduzca un valor para la posición [i, j] de la matriz.
                Console.WriteLine("Introduzca el valor para la fila {0} y columna {1}: ", i + 1, j + 1);

                // Se lee la entrada del usuario y se almacena en la posición correspondiente de la matriz.
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Variable para almacenar la suma de la diagonal principal.
        int sumaDiagonalPrincipal = 0;

        // Bucle que itera a través de la diagonal principal y suma sus elementos.
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            sumaDiagonalPrincipal += matriz[i, i];
        }

        // Variable para almacenar la suma de la diagonal secundaria.
        int sumaDiagonalSecundaria = 0;

        // Bucle que itera a través de la diagonal secundaria y suma sus elementos.
        for (int i = 0, j = matriz.GetLength(1) - 1; i < matriz.GetLength(0); i++, j--)
        {
            sumaDiagonalSecundaria += matriz[i, j];
        }

        // Se imprime el resultado de la suma de la diagonal principal.
        Console.WriteLine("La suma de la diagonal principal es: {0}", sumaDiagonalPrincipal);

        // Se imprime el resultado de la suma de la diagonal secundaria.
        Console.WriteLine("La suma de la diagonal secundaria es: {0}", sumaDiagonalSecundaria);
    }
}
