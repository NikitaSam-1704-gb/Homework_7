﻿/*// Задача №46 Задан двухмерный массив mxn
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

/*// Задача №48 Задан двухмерный массив mxn
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
PrintArray(massiv);*/

/*// Задача 49. Задайте двухмерный массив
//Значения элементов с четными индексами заменить на их квадраты

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
    return array;
}
int[,] SquaresEvenElements(int[,] array)
{
   for(int i=0; i < array.GetLength(0); i+=2)
    {
        for(int j=0; j < array.GetLength(1); j+=2)
        {
            if(i%2==0 && j%2==0)
                array[i,j]=Convert.ToInt32(Math.Pow(array[i,j], 2));
        }
        WriteLine();
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
int[,] massiv=FillRandomArray();
PrintArray( massiv);

WriteLine(" Значения элементов с четными индексами возведены в квадрат ");
int[,] massivSquares=SquaresEvenElements(massiv);
PrintArray(massivSquares);*/

/*// Задача №51. Подсчет суммы значений элементов главной диагонали

using static System.Console;
Clear();

(int rows, int cols) InputParametrRamdomArray()
{
    (int rows, int cols) parametrs;
    Write(" Введите количество строк массива ->");
    parametrs.rows=Convert.ToInt16(ReadLine());
    Write(" Введите количество столбцов массива ->");
    parametrs.cols=Convert.ToInt16(ReadLine());
    return parametrs;
}

int[,] FillRandomArray(int minValue, int maxValue)
{
    (int rows, int cols)parametrs=InputParametrRamdomArray();
    int[,] array= new int[parametrs.rows,parametrs.cols];
    for(int i=0; i < parametrs.rows; i++)
    {
        for(int j=0; j < parametrs.cols; j++)
            array[i,j]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}
void SumElementsMainDiagonal(int[,] array)
{
    int size;
    if(array.GetLength(0)<=array.GetLength(1))
        size=array.GetLength(0);
    else
        size=array.GetLength(1);

    int summ=0;
   for(int i=0; i < size; i++)
        summ+=array[i,i];
    WriteLine($" Сумма значений элементов главной диагонали -> {summ}");
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
int[,] massiv=FillRandomArray(-10,10);
PrintArray( massiv);
SumElementsMainDiagonal(massiv);*/

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

//0,5  7  -2  -0,2
//1  -3,3  8  -9,9
//8  7,8  -7,1  9



using static System.Console;
Clear();

/*( int sizeI, int sizeJ, int minValue, int maxValues) ParametersRandomArray()
{
    (int sizeI,int sizeJ, int minValues, int maxValues) parameters;
    Write(" Введите количество строк  массива-> ");
    parameters.sizeI=Convert.ToInt32(ReadLine());
    Write(" Введите количество столбцов массива-> ");
    parameters.sizeJ=Convert.ToInt32(ReadLine());
    Write(" Введите минимальное Значение ");
    parameters.minValues=Convert.ToInt32(ReadLine());
    Write(" Введите максимальное Значение  ");
    parameters.maxValues=Convert.ToInt32(ReadLine());
    return parameters;
}*/

double [,] FillArrayRamdom(int sizeI, int sizeJ, int minValues, int maxValues)
{
    double[,] array=new double[sizeI, sizeJ];
    for(int i=0; i<array.GetLength(0); i++ )
    {
        for(int j=0; j<array.GetLength(1);j++ )
            array[i,j]=new Random().NextDouble()* new Random().Next(minValues,maxValues+1);
    }    
    return array;
}

void PrintArray(double[,] array)
{
    WriteLine("Массив ");
    for(int i=0; i<array.GetLength(0); i++ )
    {
        for(int j=0; j<array.GetLength(1);j++ )
            Write($" \t {array[i,j]:f} \t "); 
    }
}


//(int sizeI,int sizeJ, int minValues, int maxValues) parametersWork=ParametersRandomArray();
double[,] massiv=FillArrayRamdom(3, 4, -10, 10);
PrintArray(massiv);