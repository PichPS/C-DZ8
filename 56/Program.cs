// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int Prompt(string massege)
// {
//     System.Console.Write(massege);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }


int[,] CreaateArray(int m = 5, int n = 4)
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
void PrintArr1(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

int[,] FillArrayRandom(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(1, 10);
        }
    }
    return coll;
}


int[] moreSumRow(int[,] Row)
{
    int[] arrayRow = new int[Row.GetLength(0)];
    for (int i = 0; i < Row.GetLength(0); i++)
    {
        int SumRow = 0;
        for (int j = 0; j < Row.GetLength(1); j++)
        {
            SumRow += Row[i, j];
        }
        arrayRow[i] = SumRow;
    }
    return arrayRow;
}

int MinNumber(int[] array)
{
    int min = array[0];
    int minPos = 0;
    for (int i = 1; i < array.Length; i++)

    {
        if (array[i] < min)
        {
            min = array[i];
            minPos = i;
        }
    }
    return minPos;

}

void Main()
{
    // int m = Prompt("Введите количество строк: ");
    // int n = Prompt("Введите количество столбцов: ");
    int[,] arr = CreaateArray();
    arr = FillArrayRandom(arr);
    PrintArr(arr);
    System.Console.WriteLine();
    int[] array = moreSumRow(arr);
    PrintArr1(array);
    int minNumber = MinNumber(array);
    System.Console.WriteLine($" номер строки с наименьшей суммой элементов: {minNumber+1} строка");
}

Main();

