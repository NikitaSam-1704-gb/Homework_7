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