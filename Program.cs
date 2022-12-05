// Задача 49. Задайте двухмерный массив
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
PrintArray(massivSquares);



