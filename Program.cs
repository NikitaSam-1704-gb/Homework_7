//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

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
            Write($"\t {array[i,j]}\t "); 
        WriteLine();
    }  
}

void SearchAddress(int[,] array)
{
    Write("Введите адрес элемента [i,j] -> ");
    int adress=Convert.ToInt32(ReadLine());
    int adressCols=adress%10;
    int adressRows=(adress/10)%10;
    if(adressRows<=array.GetLength(0) && adressCols<=array.GetLength(1)==true)
    WriteLine($" {array[adressRows-1,adressCols-1]} ");
    else WriteLine("Элемента с данным адресом не существует");
}

(int rows, int cols) parametersWork=ParametersRandomArray();
int[,] massiv=FillArrayRamdom(parametersWork.rows, parametersWork.cols, 0, 10);
PrintArray(massiv);
SearchAddress(massiv);