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

int[,] sort(int[,] arr)
{
    int[] mas1 = new int[m * n];
    int per1 = 0;
    for (int i = 0; i < m; i++)   //Преобразуем матрицу в одномерный массив
    {
        for (int j = 0; j < n; j++)
        {
            mas1[per1] = arr[i, j];
            if (per1<(m*n)-1) per1++;
        }
    }
    int ind=0;
    for (int i = 0; i < (m * n)-1; i++)  //Cортируем одномерный массив
    {
        
        for (int j = i+1; j < (m * n); j++)
        {
            if (mas1[i] > mas1[j])
            {
               int temp = mas1[i];
               mas1[i] = mas1[j];
               mas1[j] = temp;
            }
        }
       
    }
    per1=0;
    for (int i = 0; i < m; i++)   //Преобразуем одномерный массив в матрицу
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = mas1[per1];
            per1++;
        }
    }
    return arr;
}
PrintArray(mas);
sort(mas);
Console.WriteLine("");
PrintArray(sort(mas));