// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} ");
        System.Console.WriteLine();
    }
}

void JoinMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}


Console.Clear();
System.Console.WriteLine("Введите количество строк 1й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов 1й матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов 2й матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());
int[,] firstMartrix = new int[m, n];
int[,] secomdMartrix = new int[n, p];
FillArray(firstMartrix);
PrintArray (firstMartrix);
FillArray(secomdMartrix);
PrintArray (secomdMartrix);
int[,] ResultMatrix = new int[m,p];
JoinMatrix(firstMartrix, secomdMartrix, ResultMatrix);
PrintArray (ResultMatrix);