/*// Задача №46 Задан двухмерный массив mxn
// заполнить случайными числами

using static System.Console;
Clear();

(int rows, int cols, int minValue, int maxValue) InputParametrRamdomArray()
{
    (int rows, int cols, int minValue, int maxValue) parametrs;
    Write(" Введите количество строк массива ->");
    parametrs.rows=Convert.ToInt16(ReadLine());
    Write(" Введите количество столбцов массива ->");
    parametrs.cols=Convert.ToInt16(ReadLine());
    Write(" Введите нижнию  границы интервала случайных чисел ->");
    parametrs.minValue=Convert.ToInt16(ReadLine());
    Write(" Введите вехнию границы интервала случайных чисел ->");
    parametrs.maxValue=Convert.ToInt16(ReadLine());
    return parametrs;

}

int[,] FillRandomArray()
{
    (int rows, int cols, int minValue, int maxValue)parametrs=InputParametrRamdomArray();
    int[,] array= new int[parametrs.rows,parametrs.cols];
    for(int i=0; i < parametrs.rows; i++)
    {
        for(int j=0; j < parametrs.cols; j++)
            array[i,j]=new Random().Next(parametrs.minValue,parametrs.maxValue+1);
    }
    PrintArray(array);
    string stop="";
    stop=Convert.ToString(ReadLine());
    Clear();
    return array;
}

void PrintArray( int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Write($"{array[i,j]} \t ");
        WriteLine();
    }
}

WriteLine(" Создадим двухмерный массив ");
int[,] massiv=FillRandomArray();
PrintArray( massiv);*/

// Задача №48 Задан двухмерный массив mxn
// Каждый элемент заполнить по формуле А[m,n]=mxn;

using static System.Console;
Clear();

(int rows, int cols ) InputParametrArray()
{
    (int rows, int cols ) parametrs;
    Write(" Введите количество строк массива ->");
    parametrs.rows=Convert.ToInt16(ReadLine());
    Write(" Введите количество столбцов массива ->");
    parametrs.cols=Convert.ToInt16(ReadLine());
    return parametrs;

}

int[,] FillArray()
{
    (int rows, int cols)parametrs=InputParametrArray();
    int[,] array= new int[parametrs.rows,parametrs.cols];
    for(int i=0; i < parametrs.rows; i++)
    {
        for(int j=0; j < parametrs.cols; j++)
            array[i,j]=i+j;
    }
    return array;
}

void PrintArray( int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Write($"{array[i,j]} \t ");
        WriteLine();
    }
}

WriteLine(" Создадим двухмерный массив ");
int[,] massiv=FillArray();
PrintArray(massiv);