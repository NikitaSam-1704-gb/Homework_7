// Задача №51. Подсчет суммы значений элементов главной диагонали

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
SumElementsMainDiagonal(massiv);
