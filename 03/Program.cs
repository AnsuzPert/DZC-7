/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/
void PrintArray(int[,] table)
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
    int[,] FillArray(int m, int n)
    {
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                array[i, j] = new Random().Next(-100, 100);
                

        }
        return array;
    }

    int[,] mas = FillArray(m, n);
    string srarf (int [,] arr)
    {string sre=" ";
        for (int j =0; j < n; j++)
        {double sr = 0;
            for(int i =0; i<m; i++)
            {
                sr = sr+arr[i,j];
            }
        sr = Math.Round(sr/m,2);
        sre = sre + sr+" ";
        }
        return sre;
    }
    PrintArray(mas);
    Console.WriteLine(srarf(mas));

