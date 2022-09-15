/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

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
                array[i, j] =Math.Round( new Random().Next(-100, 100)+ new Random().NextDouble(),2);
                

        }
        return array;
    }

    double[,] mas = FillArray(m, n);
    PrintArray(mas);
    

