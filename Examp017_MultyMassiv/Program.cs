﻿Console.Clear();
// string[,] table = new string[2, 5];
// table[1, 2] = "Слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for ( int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine("");
    }
}
PrintArray(matrix);
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine(" ");
// }