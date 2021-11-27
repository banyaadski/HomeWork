// 48. Показать двумерный массив размером m×n заполненный целыми числами
// 49. Показать двумерный массив размером m×n заполненный вещественными числами
// 50. В двумерном массиве n×k заменить четные элементы на противоположные
// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет


// 48. Показать двумерный массив размером m×n заполненный целыми числами
int[,] CreateTwoDimensionalArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
int m = 2;
int n = 3;
int[,] Double = new int[m, n];
CreateTwoDimensionalArray(Double, 1, 10);
PrintArray(Double);



// 49. Показать двумерный массив размером m×n заполненный вещественными числами

double[,] CreateTwoDimensionalArrayRealNumbers(double[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
int m = 2;
int n = 3;
double[,] Double = new double[m, n];
CreateTwoDimensionalArrayRealNumbers(Double, 100000, 9999999 );
PrintArray(Double);

// 50. В двумерном массиве n×k заменить четные элементы на противоположные


int[,] ReplaceEvenElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
                array[i, j] = array[i, j] * (-1);
        }
    }
    return array;
}

int m = 2;
int n = 3;
int[,] Double = new int[m, n];
CreateTwoDimensionalArray(Double, 1, 10);
PrintArray(Double);
System.Console.WriteLine();
ReplaceEvenElements(Double);
PrintArray(Double);


// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n(я так понимаю что в одинаковых индексах массива должна находиться сумма индексов)
int[,] SumOfIndexes(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int[,] arr = SumOfIndexes(10, 10);
PrintArray(arr);



// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] ReplaceElementsEvenSquares(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if( i %2==0 && j %2==0)
            array[i,j]= array[i,j]*array[i,j];
        }
    }
    return array;
}

int m = 5;
int n = 7;
int[,] Double = new int[m, n];
CreateTwoDimensionalArray(Double, 1, 10);
PrintArray(Double);
System.Console.WriteLine();
ReplaceElementsEvenSquares(Double);
PrintArray(Double);

// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет


int[,] ShowFindPositionGivenNumber(int[,] array, int findElement)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (array[i, j] == findElement) Console.WriteLine("Индекс заданного элемента равен = [{0},{1}]", i, j);
            else count++;

        }
    }
    if (count == (array.GetLength(0) * array.GetLength(1))) Console.WriteLine("Заданный элемент не обнаружен");
    return array;


}

int m = 2;
int n = 3;
int[,] Double = new int[m, n];
CreateTwoDimensionalArray(Double, 1, 10);
PrintArray(Double);
System.Console.WriteLine();
ShowFindPositionGivenNumber(Double, 3);
