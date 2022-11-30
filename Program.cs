//Задайте двумерный массив. Найдите сумму
//элементов, находящихся на главной диагонали (с индексами
//(0,0); (1;1) и т.д.



using static System.Console;
Clear();


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 11);
            ;
            Write($"{result[i, j]}\t ");
        }
        WriteLine();
    }
    WriteLine();

    return result;

}

int Summ(int[,] inArray)
{
    int summ = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == j)
                summ += inArray[i, j];

            //Console.Write($"{inArray[i, j]}\t ");
        }
        //Console.WriteLine();
    }
   // WriteLine($" сумма элементов главной диагонали {summ}");
    return summ;
}
void PrintArray(int[,] inArray)
{
    int summ = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == j)
                summ += inArray[i, j];

            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
    WriteLine($" сумма элементов главной диагонали {summ}");
}

Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols);
PrintArray(array);
int result=Summ(array)
WriteLine($" сумма элементов главной диагонали {summ}");
