/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
*/
void PrintArray(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = Math.Round(new Random().Next(-100, 100) + new Random().NextDouble(), 2);


    }
    return array;
}
Console.WriteLine("ВВедите номер искомого столбца");
int stl = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите номер строки");
int str = Convert.ToInt32(Console.ReadLine());

void Vivod(double[,] arr)
{
    if ((str >= n) ^ (stl >= m) ^ (str < 0) ^ (stl < 0)) Console.WriteLine("Ячейки с таким номером нет");
    else
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                if ((i == stl) && (j == str)) Console.WriteLine($"Искомый элемент это {arr[i, j]}");

        }
    }
}
double[,] mas = FillArray(m, n);
PrintArray(mas);
Vivod(mas);
