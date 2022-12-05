//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

using static System.Console;
Clear();

( int rows,int cols) ParametersRandomArray()
{
    (int rows, int cols) parameters;
    Write(" Введите колчество строк массива  ");
    parameters.rows=Convert.ToInt32(ReadLine());
    Write(" Введите количество столбцов ");
    parameters.cols=Convert.ToInt32(ReadLine());
    return parameters;
}

int [,] FillArrayRamdom(int rows, int cols, int minValues, int maxValues)
{
    int[,] array= new int[rows,cols];
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            array[i,j]=new Random().Next(minValues,maxValues+1);
    }   
    return array;
}

void PrintArray(int[,] array)
{
    WriteLine("Массив ");
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Write($" {array[i,j]}\t "); 
        WriteLine();
    }  
}

double[] ArithmeticMean(int[,] array)
{
    double[] mean=new double[array.GetLength(1)];
    for(int j=0; j<array.GetLength(1); j++)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            mean[j]+=array[i,j];
        }
        mean[j]=mean[j]/array.GetLength(0);
    }
    return mean;
}

(int rows, int cols) parametersWork=ParametersRandomArray();
int[,] massiv=FillArrayRamdom(parametersWork.rows, parametersWork.cols, 0, 10);
PrintArray(massiv);
double[] meanWork=ArithmeticMean(massiv);
WriteLine(" Среднее значение элементов по столбцам ");
for(int i=0; i<meanWork.Length; i++)
{
    Write($" {meanWork[i]:f} \t ");
}
WriteLine();