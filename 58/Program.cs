// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int Prompt(string massege)
// {
//     System.Console.Write(massege);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }


int[,] CreaateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}


void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],4}  ");
        }
        System.Console.WriteLine();
    }
}


int[,] FillArrayRandom(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(-9, 10);
        }
    }
    return coll;
}


int[,] MultiplicationMatrix(int[,] Matrix, int[,] Matrix1, int[,] Matrix2)
{
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        //int[,] Matrix = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix2.GetLength(0); k++)
            {
                Matrix[i, j] += Matrix1[i, k] * Matrix2[k, j];
            }
        }
    }
    return Matrix;
}

void Main()
{
    //int m = Prompt("Введите количество строк: ");
    //int n = Prompt("Введите количество столбцов: ");
    int[,] arr = CreaateArray(5, 5);
    arr = FillArrayRandom(arr);
    PrintArr(arr);
    System.Console.WriteLine();
    int[,] arr1 = CreaateArray(5, 5);
    int[,] arr2 = CreaateArray(5, 5);
    arr1 = FillArrayRandom(arr1);
    PrintArr(arr1);
    System.Console.WriteLine();
    PrintArr(MultiplicationMatrix(arr2, arr, arr1));
}

Main();