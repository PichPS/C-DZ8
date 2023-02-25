// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


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


int[,] RowDescending(int[,] Row)
{
    int temp;
    for (int i = 0; i < Row.GetLength(0); i++)
    {
        for (int j = 0; j < Row.GetLength(1) - 1; j++)
        {

            for (int k = j + 1; k < Row.GetLength(1); k++)
            {
                if (Row[i, k] > Row[i, j])
                {
                    temp = Row[i, j];
                    Row[i, j] = Row[i, k];
                    Row[i, k] = temp;
                }

            }
        }
    }
    return Row;
}

void Main()
{
    int m = Prompt("Введите количество строк: ");
    int n = Prompt("Введите количество столбцов: ");
    int[,] arr = CreaateArray(m, n);
    arr = FillArrayRandom(arr);
    PrintArr(arr);
    System.Console.WriteLine();
    PrintArr(RowDescending(arr));
}

Main();

